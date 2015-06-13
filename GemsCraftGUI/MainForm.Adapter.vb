' Copyright 2009-2012 Matvei Stefarov <me@matvei.org>
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.IO
Imports System.Windows.Forms
Imports System.Xml.Linq
Imports fCraft
Imports JetBrains.Annotations

' This section handles transfer of settings from Config to the specific UI controls, and vice versa.
' Effectively, it's an adapter between Config's and ConfigUI's representations of the settings
Partial Class MainForm
#Region "Loading & Applying Config"

    Private Sub LoadConfig()
        Dim missingFileMsg As String = Nothing
        If Not File.Exists(Paths.WorldListFileName) AndAlso Not File.Exists(Paths.ConfigFileName) Then
            missingFileMsg = [String].Format("Configuration ({0}) and world list ({1}) were not found. Using defaults.", Paths.ConfigFileName, Paths.WorldListFileName)
        ElseIf Not File.Exists(Paths.ConfigFileName) Then
            missingFileMsg = [String].Format("Configuration ({0}) was not found. Using defaults.", Paths.ConfigFileName)
        ElseIf Not File.Exists(Paths.WorldListFileName) Then
            missingFileMsg = [String].Format("World list ({0}) was not found. Assuming 0 worlds.", Paths.WorldListFileName)
        End If
        If missingFileMsg IsNot Nothing Then
            MessageBox.Show(missingFileMsg)
        End If

        Using loadLogger As New LogRecorder()
            If Config.Load(False, False) Then
                If loadLogger.HasMessages Then
                    MessageBox.Show(loadLogger.MessageString, "Config loading warnings")
                End If
            Else
                MessageBox.Show(loadLogger.MessageString, "Error occured while trying to load config")
            End If
        End Using

        ApplyTabGeneral()
        ApplyTabChat()
        ApplyTabWorlds()
        ' also reloads world list
        ApplyTabRanks()
        ApplyTabSecurity()
        ApplyTabSavingAndBackup()
        ApplyTabLogging()
        ApplyTabIRC()
        ApplyTabAdvanced()

        AddChangeHandler(tabs, SomethingChanged)
        AddChangeHandler(bResetTab, SomethingChanged)
        AddChangeHandler(bResetAll, SomethingChanged)
        dgvWorlds.CellValueChanged += Sub() SomethingChanged(Nothing, Nothing)

        AddChangeHandler(tabChat, HandleTabChatChange)
        bApply.Enabled = False
    End Sub


    Private Sub LoadWorldList()
        If Worlds.Count > 0 Then
            Worlds.Clear()
        End If
        If Not File.Exists(Paths.WorldListFileName) Then
            Return
        End If

        Try
            Dim doc As XDocument = XDocument.Load(Paths.WorldListFileName)
            Dim root As XElement = doc.Root
            If root Is Nothing Then
                MessageBox.Show("Worlds.xml is empty or corrupted.")
                Return
            End If

            Dim errorLog As String = ""
            Using logRecorder As New LogRecorder()
                For Each el As XElement In root.Elements("World")
                    Try
                        Worlds.Add(New WorldListEntry(el))
                    Catch ex As Exception
                        errorLog += ex + Environment.NewLine
                    End Try
                Next
                If logRecorder.HasMessages Then
                    MessageBox.Show(logRecorder.MessageString, "World list loading warnings.")
                End If
            End Using
            If errorLog.Length > 0 Then
                MessageBox.Show(Convert.ToString("Some errors occured while loading the world list:" + Environment.NewLine) & errorLog, "Warning")
            End If

            FillWorldList()
            Dim mainWorldAttr As XAttribute = root.Attribute("main")
            If mainWorldAttr IsNot Nothing Then
                For Each world As WorldListEntry In Worlds
                    If world.Name.ToLower() = mainWorldAttr.Value.ToLower() Then
                        cMainWorld.SelectedItem = world.Name
                        Exit For
                    End If
                Next

            End If
        Catch ex As Exception
            MessageBox.Show("Error occured while loading the world list: " + Environment.NewLine + ex, "Warning")
        End Try

        Worlds.ListChanged += SomethingChanged
    End Sub


    Private Sub ApplyTabGeneral()

        tServerName.Text = ConfigKey.ServerName.GetString()
        CustomName.Text = ConfigKey.CustomChatName.GetString()
        SwearBox.Text = ConfigKey.SwearName.GetString()
        CustomAliases.Text = ConfigKey.CustomAliasName.GetString()
        tMOTD.Text = ConfigKey.MOTD.GetString()
        websiteURL.Text = ConfigKey.WebsiteURL.GetString()
        HeartBeatUrlComboBox.Text = ConfigKey.HeartbeatUrl.GetString()

        nMaxPlayers.Value = ConfigKey.MaxPlayers.GetInt()
        CheckMaxPlayersPerWorldValue()
        nMaxPlayersPerWorld.Value = ConfigKey.MaxPlayersPerWorld.GetInt()

        If ConfigKey.CheckForUpdates.GetString() = "True" Then
            checkUpdate.Checked = True
        Else
            checkUpdate.Checked = False
        End If



        FillRankList(cDefaultRank, "(lowest rank)")
        If ConfigKey.DefaultRank.IsBlank() Then
            cDefaultRank.SelectedIndex = 0
        Else
            RankManager.DefaultRank = Rank.Parse(ConfigKey.DefaultRank.GetString())
            cDefaultRank.SelectedIndex = RankManager.GetIndex(RankManager.DefaultRank)
        End If

        cPublic.SelectedIndex = If(ConfigKey.IsPublic.Enabled(), 0, 1)
        nPort.Value = ConfigKey.Port.GetInt()
        MaxCapsValue.Value = ConfigKey.MaxCaps.GetInt()
        nUploadBandwidth.Value = ConfigKey.UploadBandwidth.GetInt()

        Dim interval As Integer = 0
        xAnnouncements.Checked = ConfigKey.AnnouncementInterval.TryGetInt(interval) AndAlso interval > 0

        If xAnnouncements.Checked Then
            nAnnouncements.Value = ConfigKey.AnnouncementInterval.GetInt()
        Else
            nAnnouncements.Value = 1
        End If

        ' UpdaterSettingsWindow
        updaterWindow.BackupBeforeUpdate = ConfigKey.BackupBeforeUpdate.Enabled()
        updaterWindow.RunBeforeUpdate = ConfigKey.RunBeforeUpdate.GetString()
        updaterWindow.RunAfterUpdate = ConfigKey.RunAfterUpdate.GetString()
        updaterWindow.UpdaterMode = ConfigKey.UpdaterMode.GetEnum(Of UpdaterMode)()
    End Sub


    Private Sub ApplyTabChat()
        xRankColorsInChat.Checked = ConfigKey.RankColorsInChat.Enabled()
        xRankPrefixesInChat.Checked = ConfigKey.RankPrefixesInChat.Enabled()
        xRankPrefixesInList.Checked = ConfigKey.RankPrefixesInList.Enabled()
        xRankColorsInWorldNames.Checked = ConfigKey.RankColorsInWorldNames.Enabled()
        xShowJoinedWorldMessages.Checked = ConfigKey.ShowJoinedWorldMessages.Enabled()
        xShowConnectionMessages.Checked = ConfigKey.ShowConnectionMessages.Enabled()

        colorSys = System.Drawing.Color.ParseToIndex(ConfigKey.SystemMessageColor.GetString())
        ApplyColor(bColorSys, colorSys)
        System.Drawing.Color.Sys = System.Drawing.Color.Parse(colorSys)

        colorCustom = System.Drawing.Color.ParseToIndex(ConfigKey.CustomChatColor.GetString())
        ApplyColor(CustomColor, colorCustom)
        System.Drawing.Color.[Custom] = System.Drawing.Color.Parse(colorCustom)

        colorHelp = System.Drawing.Color.ParseToIndex(ConfigKey.HelpColor.GetString())
        ApplyColor(bColorHelp, colorHelp)
        System.Drawing.Color.Help = System.Drawing.Color.Parse(colorHelp)

        colorSay = System.Drawing.Color.ParseToIndex(ConfigKey.SayColor.GetString())
        ApplyColor(bColorSay, colorSay)
        System.Drawing.Color.Say = System.Drawing.Color.Parse(colorSay)

        colorAnnouncement = System.Drawing.Color.ParseToIndex(ConfigKey.AnnouncementColor.GetString())
        ApplyColor(bColorAnnouncement, colorAnnouncement)
        System.Drawing.Color.Announcement = System.Drawing.Color.Parse(colorAnnouncement)

        colorPM = System.Drawing.Color.ParseToIndex(ConfigKey.PrivateMessageColor.GetString())
        ApplyColor(bColorPM, colorPM)
        System.Drawing.Color.PM = System.Drawing.Color.Parse(colorPM)

        colorWarning = System.Drawing.Color.ParseToIndex(ConfigKey.WarningColor.GetString())
        ApplyColor(bColorWarning, colorWarning)
        System.Drawing.Color.Warning = System.Drawing.Color.Parse(colorWarning)

        colorMe = System.Drawing.Color.ParseToIndex(ConfigKey.MeColor.GetString())
        ApplyColor(bColorMe, colorMe)
        System.Drawing.Color.[Me] = System.Drawing.Color.Parse(colorMe)

        colorGlobal = System.Drawing.Color.ParseToIndex(ConfigKey.GlobalColor.GetString())
        ApplyColor(bColorGlobal, colorGlobal)
        System.Drawing.Color.[Global] = System.Drawing.Color.Parse(colorGlobal)

        UpdateChatPreview()
    End Sub


    Private Sub ApplyTabWorlds()
        If rankNameList Is Nothing Then
            rankNameList = New BindingList(Of String)() From { _
                WorldListEntry.DefaultRankOption _
                }
            For Each rank__1 As Rank In RankManager.Ranks
                rankNameList.Add(MainForm.ToComboBoxOption(rank__1))
            Next
            dgvcAccess.DataSource = rankNameList
            dgvcBuild.DataSource = rankNameList
            dgvcBackup.DataSource = WorldListEntry.BackupEnumNames

            LoadWorldList()

            dgvWorlds.DataSource = Worlds
        Else
            'dgvWorlds.DataSource = null;
            rankNameList.Clear()
            rankNameList.Add(WorldListEntry.DefaultRankOption)
            For Each rank__1 As Rank In RankManager.Ranks
                rankNameList.Add(MainForm.ToComboBoxOption(rank__1))
            Next
            For Each world As WorldListEntry In Worlds
                world.ReparseRanks()
            Next
            'dgvWorlds.DataSource = worlds;
            Worlds.ResetBindings()
        End If

        FillRankList(cDefaultBuildRank, "(default rank)")
        If ConfigKey.DefaultBuildRank.IsBlank() Then
            cDefaultBuildRank.SelectedIndex = 0
        Else
            RankManager.DefaultBuildRank = Rank.Parse(ConfigKey.DefaultBuildRank.GetString())
            cDefaultBuildRank.SelectedIndex = RankManager.GetIndex(RankManager.DefaultBuildRank)
        End If

        If Paths.IsDefaultMapPath(ConfigKey.MapPath.GetString()) Then
            tMapPath.Text = Paths.MapPathDefault
            xMapPath.Checked = False
        Else
            tMapPath.Text = ConfigKey.MapPath.GetString()
            xMapPath.Checked = True
        End If

        xWoMEnableEnvExtensions.Checked = ConfigKey.WoMEnableEnvExtensions.Enabled()
    End Sub


    Private Sub ApplyTabRanks()
        selectedRank = Nothing
        RebuildRankList()
        DisableRankOptions()
    End Sub


    Private Sub ApplyTabSecurity()
        ApplyEnum(cVerifyNames, ConfigKey.VerifyNames, NameVerificationMode.Balanced)

        nMaxConnectionsPerIP.Value = ConfigKey.MaxConnectionsPerIP.GetInt()
        xMaxConnectionsPerIP.Checked = (nMaxConnectionsPerIP.Value > 0)
        xAllowUnverifiedLAN.Checked = ConfigKey.AllowUnverifiedLAN.Enabled()

        nAntispamMessageCount.Value = ConfigKey.AntispamMessageCount.GetInt()
        nAntispamInterval.Value = ConfigKey.AntispamInterval.GetInt()
        nSpamMute.Value = ConfigKey.AntispamMuteDuration.GetInt()

        xAntispamKicks.Checked = (ConfigKey.AntispamMaxWarnings.GetInt() > 0)
        nAntispamMaxWarnings.Value = ConfigKey.AntispamMaxWarnings.GetInt()
        If Not xAntispamKicks.Checked Then
            nAntispamMaxWarnings.Enabled = False
        End If

        xRequireKickReason.Checked = ConfigKey.RequireKickReason.Enabled()
        xRequireBanReason.Checked = ConfigKey.RequireBanReason.Enabled()
        xRequireRankChangeReason.Checked = ConfigKey.RequireRankChangeReason.Enabled()
        xAnnounceKickAndBanReasons.Checked = ConfigKey.AnnounceKickAndBanReasons.Enabled()
        xAnnounceRankChanges.Checked = ConfigKey.AnnounceRankChanges.Enabled()
        xAnnounceRankChangeReasons.Checked = ConfigKey.AnnounceRankChangeReasons.Enabled()
        xAnnounceRankChangeReasons.Enabled = xAnnounceRankChanges.Checked

        FillRankList(cPatrolledRank, "(default rank)")
        If ConfigKey.PatrolledRank.IsBlank() Then
            cPatrolledRank.SelectedIndex = 0
        Else
            RankManager.PatrolledRank = Rank.Parse(ConfigKey.PatrolledRank.GetString())
            cPatrolledRank.SelectedIndex = RankManager.GetIndex(RankManager.PatrolledRank)
        End If


        xBlockDBEnabled.Checked = ConfigKey.BlockDBEnabled.Enabled()
        xBlockDBAutoEnable.Checked = ConfigKey.BlockDBAutoEnable.Enabled()

        FillRankList(cBlockDBAutoEnableRank, "(default rank)")
        If ConfigKey.BlockDBAutoEnableRank.IsBlank() Then
            cBlockDBAutoEnableRank.SelectedIndex = 0
        Else
            RankManager.BlockDBAutoEnableRank = Rank.Parse(ConfigKey.BlockDBAutoEnableRank.GetString())
            cBlockDBAutoEnableRank.SelectedIndex = RankManager.GetIndex(RankManager.BlockDBAutoEnableRank)
        End If
    End Sub


    Private Sub ApplyTabSavingAndBackup()
        xSaveInterval.Checked = (ConfigKey.SaveInterval.GetInt() > 0)
        nSaveInterval.Value = ConfigKey.SaveInterval.GetInt()
        If Not xSaveInterval.Checked Then
            nSaveInterval.Enabled = False
        End If

        xBackupOnStartup.Checked = ConfigKey.BackupOnStartup.Enabled()
        xBackupOnJoin.Checked = ConfigKey.BackupOnJoin.Enabled()
        xBackupOnlyWhenChanged.Checked = ConfigKey.BackupOnlyWhenChanged.Enabled()

        xBackupInterval.Checked = (ConfigKey.DefaultBackupInterval.GetInt() > 0)
        nBackupInterval.Value = ConfigKey.DefaultBackupInterval.GetInt()
        If Not xBackupInterval.Checked Then
            nBackupInterval.Enabled = False
        End If

        xMaxBackups.Checked = (ConfigKey.MaxBackups.GetInt() > 0)
        nMaxBackups.Value = ConfigKey.MaxBackups.GetInt()
        If Not xMaxBackups.Checked Then
            nMaxBackups.Enabled = False
        End If

        xMaxBackupSize.Checked = (ConfigKey.MaxBackupSize.GetInt() > 0)
        nMaxBackupSize.Value = ConfigKey.MaxBackupSize.GetInt()
        If Not xMaxBackupSize.Checked Then
            nMaxBackupSize.Enabled = False
        End If

        xBackupDataOnStartup.Checked = ConfigKey.BackupDataOnStartup.Enabled()
    End Sub


    Private Sub ApplyTabLogging()
        For Each item As ListViewItem In vConsoleOptions.Items
            item.Checked = Logger.ConsoleOptions(item.Index)
        Next
        For Each item As ListViewItem In vLogFileOptions.Items
            item.Checked = Logger.LogFileOptions(item.Index)
        Next

        ApplyEnum(cLogMode, ConfigKey.LogMode, LogSplittingType.OneFile)

        xLogLimit.Checked = (ConfigKey.MaxLogs.GetInt() > 0)
        nLogLimit.Value = ConfigKey.MaxLogs.GetInt()
        If Not xLogLimit.Checked Then
            nLogLimit.Enabled = False
        End If
    End Sub


    Private Sub ApplyTabIRC()
        xIRCBotEnabled.Checked = ConfigKey.IRCBotEnabled.Enabled()
        gIRCNetwork.Enabled = xIRCBotEnabled.Checked
        gIRCOptions.Enabled = xIRCBotEnabled.Checked

        tIRCBotNetwork.Text = ConfigKey.IRCBotNetwork.GetString()
        nIRCBotPort.Value = ConfigKey.IRCBotPort.GetInt()
        nIRCDelay.Value = ConfigKey.IRCDelay.GetInt()

        tIRCBotChannels.Text = ConfigKey.IRCBotChannels.GetString()

        tIRCBotNick.Text = ConfigKey.IRCBotNick.GetString()
        xIRCRegisteredNick.Checked = ConfigKey.IRCRegisteredNick.Enabled()

        tIRCNickServ.Text = ConfigKey.IRCNickServ.GetString()
        tIRCNickServMessage.Text = ConfigKey.IRCNickServMessage.GetString()

        xIRCBotAnnounceIRCJoins.Checked = ConfigKey.IRCBotAnnounceIRCJoins.Enabled()
        xIRCBotAnnounceServerJoins.Checked = ConfigKey.IRCBotAnnounceServerJoins.Enabled()
        xIRCBotForwardFromIRC.Checked = ConfigKey.IRCBotForwardFromIRC.Enabled()
        xIRCBotForwardFromServer.Checked = ConfigKey.IRCBotForwardFromServer.Enabled()


        colorIRC = System.Drawing.Color.ParseToIndex(ConfigKey.IRCMessageColor.GetString())
        ApplyColor(bColorIRC, colorIRC)
        System.Drawing.Color.IRC = System.Drawing.Color.Parse(colorIRC)

        xIRCUseColor.Checked = ConfigKey.IRCUseColor.Enabled()
        xIRCBotAnnounceServerEvents.Checked = ConfigKey.IRCBotAnnounceServerEvents.Enabled()

        'if server pass is in use
        If ConfigKey.IRCBotNetworkPass.GetString() <> "defaultPass" Then
            xServPass.Checked = True
        End If

        'if chan pass is in use
        If ConfigKey.IRCChannelPassword.GetString() <> "password" Then
            xChanPass.Checked = True
        End If

        tChanPass.Text = ConfigKey.IRCChannelPassword.GetString()
        tServPass.Text = ConfigKey.IRCBotNetworkPass.GetString()

    End Sub


    Private Sub ApplyTabAdvanced()
        xRelayAllBlockUpdates.Checked = ConfigKey.RelayAllBlockUpdates.Enabled()
        xNoPartialPositionUpdates.Checked = ConfigKey.NoPartialPositionUpdates.Enabled()
        nTickInterval.Value = ConfigKey.TickInterval.GetInt()

        If ConfigKey.ProcessPriority.IsBlank() Then
            ' Default
            cProcessPriority.SelectedIndex = 0
        Else
            Select Case ConfigKey.ProcessPriority.GetEnum(Of ProcessPriorityClass)()
                Case ProcessPriorityClass.High
                    cProcessPriority.SelectedIndex = 1
                    Exit Select
                Case ProcessPriorityClass.AboveNormal
                    cProcessPriority.SelectedIndex = 2
                    Exit Select
                Case ProcessPriorityClass.Normal
                    cProcessPriority.SelectedIndex = 3
                    Exit Select
                Case ProcessPriorityClass.BelowNormal
                    cProcessPriority.SelectedIndex = 4
                    Exit Select
                Case ProcessPriorityClass.Idle
                    cProcessPriority.SelectedIndex = 5
                    Exit Select
            End Select
        End If



        nThrottling.Value = ConfigKey.BlockUpdateThrottling.GetInt()
        xLowLatencyMode.Checked = ConfigKey.LowLatencyMode.Enabled()
        xAutoRank.Checked = ConfigKey.AutoRankEnabled.Enabled()


        If ConfigKey.MaxUndo.GetInt() > 0 Then
            xMaxUndo.Checked = True
            nMaxUndo.Value = ConfigKey.MaxUndo.GetInt()
        Else
            xMaxUndo.Checked = False
            nMaxUndo.Value = CInt(ConfigKey.MaxUndo.GetDefault())
        End If
        nMaxUndoStates.Value = ConfigKey.MaxUndoStates.GetInt()

        tConsoleName.Text = ConfigKey.ConsoleName.GetString()

        tIP.Text = ConfigKey.IP.GetString()
        xCrash.Checked = ConfigKey.SubmitCrashReports.Enabled()
        If ConfigKey.IP.IsBlank() OrElse ConfigKey.IP.IsDefault() Then
            tIP.Enabled = False
            xIP.Checked = False
        Else
            tIP.Enabled = True
            xIP.Checked = True
        End If

    End Sub


    Private Shared Sub ApplyEnum(Of TEnum As Structure)(<NotNull> box As ComboBox, key As ConfigKey, def As TEnum)
        If box Is Nothing Then
            Throw New ArgumentNullException("box")
        End If
        If Not GetType(TEnum).IsEnum Then
            Throw New ArgumentException("Enum type required")
        End If
        Try
            If key.IsBlank() Then
                box.SelectedIndex = CInt(DirectCast(def, Object))
            Else
                box.SelectedIndex = CInt([Enum].Parse(GetType(TEnum), key.GetString(), True))
            End If
        Catch generatedExceptionName As ArgumentException
            box.SelectedIndex = CInt(DirectCast(def, Object))
        End Try
    End Sub

#End Region


#Region "Saving Config"

    Private Sub SaveConfig()
        ' General

        ConfigKey.ServerName.TrySetValue(tServerName.Text)
        ConfigKey.CustomChatName.TrySetValue(CustomName.Text)
        ConfigKey.SwearName.TrySetValue(SwearBox.Text)
        ConfigKey.CheckForUpdates.TrySetValue(checkUpdate.Checked.ToString())
        ConfigKey.WebsiteURL.TrySetValue(websiteURL.Text)
        ConfigKey.HeartbeatUrl.TrySetValue(HeartBeatUrlComboBox.SelectedItem)
        ConfigKey.CustomAliasName.TrySetValue(CustomAliases.Text)
        ConfigKey.MOTD.TrySetValue(tMOTD.Text)
        ConfigKey.MaxPlayers.TrySetValue(nMaxPlayers.Value)
        ConfigKey.MaxPlayersPerWorld.TrySetValue(nMaxPlayersPerWorld.Value)
        If cDefaultRank.SelectedIndex = 0 Then
            ConfigKey.DefaultRank.TrySetValue("")
        Else
            ConfigKey.DefaultRank.TrySetValue(RankManager.DefaultRank.FullName)
        End If
        ConfigKey.IsPublic.TrySetValue(cPublic.SelectedIndex = 0)
        ConfigKey.Port.TrySetValue(nPort.Value)
        ConfigKey.MaxCaps.TrySetValue(MaxCapsValue.Value)
        If xIP.Checked Then
            ConfigKey.IP.TrySetValue(tIP.Text)
        Else
            ConfigKey.IP.ResetValue()
        End If

        ConfigKey.UploadBandwidth.TrySetValue(nUploadBandwidth.Value)

        If xAnnouncements.Checked Then
            ConfigKey.AnnouncementInterval.TrySetValue(nAnnouncements.Value)
        Else
            ConfigKey.AnnouncementInterval.TrySetValue(0)
        End If

        ' UpdaterSettingsWindow
        ConfigKey.UpdaterMode.TrySetValue(updaterWindow.UpdaterMode)
        ConfigKey.BackupBeforeUpdate.TrySetValue(updaterWindow.BackupBeforeUpdate)
        ConfigKey.RunBeforeUpdate.TrySetValue(updaterWindow.RunBeforeUpdate)
        ConfigKey.RunAfterUpdate.TrySetValue(updaterWindow.RunAfterUpdate)


        ' Chat
        ConfigKey.SystemMessageColor.TrySetValue(System.Drawing.Color.GetName(colorSys))
        ConfigKey.CustomChatColor.TrySetValue(System.Drawing.Color.GetName(colorCustom))
        ConfigKey.HelpColor.TrySetValue(System.Drawing.Color.GetName(colorHelp))
        ConfigKey.SayColor.TrySetValue(System.Drawing.Color.GetName(colorSay))
        ConfigKey.AnnouncementColor.TrySetValue(System.Drawing.Color.GetName(colorAnnouncement))
        ConfigKey.PrivateMessageColor.TrySetValue(System.Drawing.Color.GetName(colorPM))
        ConfigKey.WarningColor.TrySetValue(System.Drawing.Color.GetName(colorWarning))
        ConfigKey.MeColor.TrySetValue(System.Drawing.Color.GetName(colorMe))
        ConfigKey.GlobalColor.TrySetValue(System.Drawing.Color.GetName(colorGlobal))
        ConfigKey.ShowJoinedWorldMessages.TrySetValue(xShowJoinedWorldMessages.Checked)
        ConfigKey.RankColorsInWorldNames.TrySetValue(xRankColorsInWorldNames.Checked)
        ConfigKey.RankColorsInChat.TrySetValue(xRankColorsInChat.Checked)
        ConfigKey.RankPrefixesInChat.TrySetValue(xRankPrefixesInChat.Checked)
        ConfigKey.RankPrefixesInList.TrySetValue(xRankPrefixesInList.Checked)
        ConfigKey.ShowConnectionMessages.TrySetValue(xShowConnectionMessages.Checked)


        ' Worlds
        If cDefaultBuildRank.SelectedIndex = 0 Then
            ConfigKey.DefaultBuildRank.TrySetValue("")
        Else
            ConfigKey.DefaultBuildRank.TrySetValue(RankManager.DefaultBuildRank.FullName)
        End If

        If xMapPath.Checked Then
            ConfigKey.MapPath.TrySetValue(tMapPath.Text)
        Else
            ConfigKey.MapPath.TrySetValue(ConfigKey.MapPath.GetDefault())
        End If

        ConfigKey.WoMEnableEnvExtensions.TrySetValue(xWoMEnableEnvExtensions.Checked)


        ' Security
        WriteEnum(Of NameVerificationMode)(cVerifyNames, ConfigKey.VerifyNames)

        If xMaxConnectionsPerIP.Checked Then
            ConfigKey.MaxConnectionsPerIP.TrySetValue(nMaxConnectionsPerIP.Value)
        Else
            ConfigKey.MaxConnectionsPerIP.TrySetValue(0)
        End If
        ConfigKey.AllowUnverifiedLAN.TrySetValue(xAllowUnverifiedLAN.Checked)

        ConfigKey.AntispamMessageCount.TrySetValue(nAntispamMessageCount.Value)
        ConfigKey.AntispamInterval.TrySetValue(nAntispamInterval.Value)
        ConfigKey.AntispamMuteDuration.TrySetValue(nSpamMute.Value)

        If xAntispamKicks.Checked Then
            ConfigKey.AntispamMaxWarnings.TrySetValue(nAntispamMaxWarnings.Value)
        Else
            ConfigKey.AntispamMaxWarnings.TrySetValue(0)
        End If

        ConfigKey.RequireKickReason.TrySetValue(xRequireKickReason.Checked)
        ConfigKey.RequireBanReason.TrySetValue(xRequireBanReason.Checked)
        ConfigKey.RequireRankChangeReason.TrySetValue(xRequireRankChangeReason.Checked)
        ConfigKey.AnnounceKickAndBanReasons.TrySetValue(xAnnounceKickAndBanReasons.Checked)
        ConfigKey.AnnounceRankChanges.TrySetValue(xAnnounceRankChanges.Checked)
        ConfigKey.AnnounceRankChangeReasons.TrySetValue(xAnnounceRankChangeReasons.Checked)

        If cPatrolledRank.SelectedIndex = 0 Then
            ConfigKey.PatrolledRank.TrySetValue("")
        Else
            ConfigKey.PatrolledRank.TrySetValue(RankManager.PatrolledRank.FullName)
        End If

        ConfigKey.BlockDBEnabled.TrySetValue(xBlockDBEnabled.Checked)
        ConfigKey.BlockDBAutoEnable.TrySetValue(xBlockDBAutoEnable.Checked)
        If cBlockDBAutoEnableRank.SelectedIndex = 0 Then
            ConfigKey.BlockDBAutoEnableRank.TrySetValue("")
        Else
            ConfigKey.BlockDBAutoEnableRank.TrySetValue(RankManager.BlockDBAutoEnableRank.FullName)
        End If


        ' Saving & Backups
        If xSaveInterval.Checked Then
            ConfigKey.SaveInterval.TrySetValue(nSaveInterval.Value)
        Else
            ConfigKey.SaveInterval.TrySetValue(0)
        End If
        ConfigKey.BackupOnStartup.TrySetValue(xBackupOnStartup.Checked)
        ConfigKey.BackupOnJoin.TrySetValue(xBackupOnJoin.Checked)
        ConfigKey.BackupOnlyWhenChanged.TrySetValue(xBackupOnlyWhenChanged.Checked)

        If xBackupInterval.Checked Then
            ConfigKey.DefaultBackupInterval.TrySetValue(nBackupInterval.Value)
        Else
            ConfigKey.DefaultBackupInterval.TrySetValue(0)
        End If
        If xMaxBackups.Checked Then
            ConfigKey.MaxBackups.TrySetValue(nMaxBackups.Value)
        Else
            ConfigKey.MaxBackups.TrySetValue(0)
        End If
        If xMaxBackupSize.Checked Then
            ConfigKey.MaxBackupSize.TrySetValue(nMaxBackupSize.Value)
        Else
            ConfigKey.MaxBackupSize.TrySetValue(0)
        End If

        ConfigKey.BackupDataOnStartup.TrySetValue(xBackupDataOnStartup.Checked)


        ' Logging
        WriteEnum(Of LogSplittingType)(cLogMode, ConfigKey.LogMode)
        If xLogLimit.Checked Then
            ConfigKey.MaxLogs.TrySetValue(nLogLimit.Value)
        Else
            ConfigKey.MaxLogs.TrySetValue("0")
        End If
        For Each item As ListViewItem In vConsoleOptions.Items
            Logger.ConsoleOptions(item.Index) = item.Checked
        Next
        For Each item As ListViewItem In vLogFileOptions.Items
            Logger.LogFileOptions(item.Index) = item.Checked
        Next


        ' IRC
        ConfigKey.IRCBotEnabled.TrySetValue(xIRCBotEnabled.Checked)

        ConfigKey.IRCBotNetwork.TrySetValue(tIRCBotNetwork.Text)
        ConfigKey.IRCBotPort.TrySetValue(nIRCBotPort.Value)
        ConfigKey.IRCDelay.TrySetValue(nIRCDelay.Value)

        ConfigKey.IRCBotChannels.TrySetValue(tIRCBotChannels.Text)

        ConfigKey.IRCBotNick.TrySetValue(tIRCBotNick.Text)
        ConfigKey.IRCRegisteredNick.TrySetValue(xIRCRegisteredNick.Checked)
        ConfigKey.IRCNickServ.TrySetValue(tIRCNickServ.Text)
        ConfigKey.IRCNickServMessage.TrySetValue(tIRCNickServMessage.Text)

        ConfigKey.IRCBotAnnounceIRCJoins.TrySetValue(xIRCBotAnnounceIRCJoins.Checked)
        ConfigKey.IRCBotAnnounceServerJoins.TrySetValue(xIRCBotAnnounceServerJoins.Checked)
        ConfigKey.IRCBotAnnounceServerEvents.TrySetValue(xIRCBotAnnounceServerEvents.Checked)
        ConfigKey.IRCBotForwardFromIRC.TrySetValue(xIRCBotForwardFromIRC.Checked)
        ConfigKey.IRCBotForwardFromServer.TrySetValue(xIRCBotForwardFromServer.Checked)

        ConfigKey.IRCMessageColor.TrySetValue(System.Drawing.Color.GetName(colorIRC))
        ConfigKey.IRCUseColor.TrySetValue(xIRCUseColor.Checked)

        ConfigKey.IRCBotNetworkPass.TrySetValue(tServPass.Text)
        ConfigKey.IRCChannelPassword.TrySetValue(tChanPass.Text)


        ' advanced

        ConfigKey.SubmitCrashReports.TrySetValue(xCrash.Checked)
        ConfigKey.RelayAllBlockUpdates.TrySetValue(xRelayAllBlockUpdates.Checked)
        ConfigKey.NoPartialPositionUpdates.TrySetValue(xNoPartialPositionUpdates.Checked)
        ConfigKey.TickInterval.TrySetValue(Convert.ToInt32(nTickInterval.Value))

        Select Case cProcessPriority.SelectedIndex
            Case 0
                ConfigKey.ProcessPriority.ResetValue()
                Exit Select
            Case 1
                ConfigKey.ProcessPriority.TrySetValue(ProcessPriorityClass.High)
                Exit Select
            Case 2
                ConfigKey.ProcessPriority.TrySetValue(ProcessPriorityClass.AboveNormal)
                Exit Select
            Case 3
                ConfigKey.ProcessPriority.TrySetValue(ProcessPriorityClass.Normal)
                Exit Select
            Case 4
                ConfigKey.ProcessPriority.TrySetValue(ProcessPriorityClass.BelowNormal)
                Exit Select
            Case 5
                ConfigKey.ProcessPriority.TrySetValue(ProcessPriorityClass.Idle)
                Exit Select
        End Select

        ConfigKey.BlockUpdateThrottling.TrySetValue(Convert.ToInt32(nThrottling.Value))

        ConfigKey.LowLatencyMode.TrySetValue(xLowLatencyMode.Checked)

        ConfigKey.AutoRankEnabled.TrySetValue(xAutoRank.Checked)

        If xMaxUndo.Checked Then
            ConfigKey.MaxUndo.TrySetValue(Convert.ToInt32(nMaxUndo.Value))
        Else
            ConfigKey.MaxUndo.TrySetValue(0)
        End If
        ConfigKey.MaxUndoStates.TrySetValue(Convert.ToInt32(nMaxUndoStates.Value))

        ConfigKey.ConsoleName.TrySetValue(tConsoleName.Text)

        SaveWorldList()
    End Sub


    Private Sub SaveWorldList()
        Const worldListTempFileName As String = Paths.WorldListFileName + ".tmp"
        Try
            Dim doc As New XDocument()
            Dim root As New XElement("fCraftWorldList")
            For Each world As WorldListEntry In Worlds
                root.Add(world.Serialize())
            Next
            If cMainWorld.SelectedItem IsNot Nothing Then
                root.Add(New XAttribute("main", cMainWorld.SelectedItem))
            End If
            doc.Add(root)
            doc.Save(worldListTempFileName)
            Paths.MoveOrReplace(worldListTempFileName, Paths.WorldListFileName)
        Catch ex As Exception
            MessageBox.Show([String].Format("An error occured while trying to save world list ({0}): {1}{2}", Paths.WorldListFileName, Environment.NewLine, ex))
        End Try
    End Sub


    Private Shared Sub WriteEnum(Of TEnum As Structure)(<NotNull> box As ComboBox, key As ConfigKey)
        If box Is Nothing Then
            Throw New ArgumentNullException("box")
        End If
        If Not GetType(TEnum).IsEnum Then
            Throw New ArgumentException("Enum type required")
        End If
        Try
            Dim val As TEnum = DirectCast([Enum].Parse(GetType(TEnum), box.SelectedIndex.ToString(), True), TEnum)
            key.TrySetValue(val)
        Catch generatedExceptionName As ArgumentException
            Logger.Log(LogType.[Error], "ConfigUI.WriteEnum<{0}>: Could not parse value for {1}. Using default ({2}).", GetType(TEnum).Name, key, key.GetString())
        End Try
    End Sub

#End Region
End Class