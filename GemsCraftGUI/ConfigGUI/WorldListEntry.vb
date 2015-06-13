Imports System.IO
Imports System.Windows.Forms
Imports System.Xml.Linq
Imports fCraft.MapConversion
Imports System.Linq
Imports fCraft
Imports GemsCraftGUI.ConfigGUI
Imports JetBrains.Annotations

Namespace fCraft.ConfigGUI
    ''' <summary>
    ''' A wrapper for per-World metadata, designed to be usable with SortableBindingList.
    ''' All these properties map directly to the UI controls.
    ''' </summary>
    NotInheritable Class WorldListEntry
        Implements ICloneable
        Public Const WorldInfoSignature As String = "(ConfigGUI)"
        Public Const DefaultRankOption As String = "(everyone)"
        Const MapFileExtension As String = ".fcm"

        Friend Property LoadingFailed() As Boolean
            Get
                Return m_LoadingFailed
            End Get
            Private Set(value As Boolean)
                m_LoadingFailed = value
            End Set
        End Property
        Private m_LoadingFailed As Boolean


        Public Sub New(<NotNull> newName As String)
            If newName Is Nothing Then
                Throw New ArgumentNullException("newName")
            End If
            m_name = newName
        End Sub


        Public Sub New(<NotNull> original As WorldListEntry)
            If original Is Nothing Then
                Throw New ArgumentNullException("original")
            End If
            m_name = original.Name
            Hidden = original.Hidden
            Backup = original.Backup
            BlockDBEnabled = original.BlockDBEnabled
            blockDBIsPreloaded = original.blockDBIsPreloaded
            blockDBLimit = original.blockDBLimit
            blockDBTimeLimit = original.blockDBTimeLimit
            accessSecurity = New SecurityController(original.accessSecurity)
            buildSecurity = New SecurityController(original.buildSecurity)
            LoadedBy = original.LoadedBy
            LoadedOn = original.LoadedOn
            MapChangedBy = original.MapChangedBy
            MapChangedOn = original.MapChangedOn
            environmentEl = original.environmentEl
        End Sub


        Public Sub New(<NotNull> el As XElement)
            If el Is Nothing Then
                Throw New ArgumentNullException("el")
            End If
            Dim temp As XAttribute

            If (InlineAssignHelper(temp, el.Attribute("name"))) Is Nothing Then
                Throw New FormatException("WorldListEntity: Cannot parse XML: Unnamed worlds are not allowed.")
            End If
            If Not World.IsValidName(temp.Value) Then
                Throw New FormatException("WorldListEntity: Cannot parse XML: Invalid world name skipped """ + temp.Value + """.")
            End If
            m_name = temp.Value

            If (InlineAssignHelper(temp, el.Attribute("hidden"))) IsNot Nothing AndAlso Not [String].IsNullOrEmpty(temp.Value) Then
                Dim hidden__1 As Boolean
                If [Boolean].TryParse(temp.Value, hidden__1) Then
                    Hidden = hidden__1
                Else
                    Throw New FormatException("WorldListEntity: Cannot parse XML: Invalid value for ""hidden"" attribute.")
                End If
            Else
                Hidden = False
            End If

            If (InlineAssignHelper(temp, el.Attribute("backup"))) IsNot Nothing Then
                Dim realBackupTimer As TimeSpan
                If temp.Value.ToTimeSpan(realBackupTimer) Then
                    Backup = BackupNameFromValue(realBackupTimer)
                Else
                    Logger.Log(LogType.[Error], "WorldListEntity: Cannot parse backup settings for world ""{0}"". Assuming default.", m_name)
                    Backup = BackupEnumNames(0)
                End If
            Else
                Backup = BackupEnumNames(0)
            End If

            Dim tempEl As XElement
            If (InlineAssignHelper(tempEl, el.Element(WorldManager.AccessSecurityXmlTagName))) IsNot Nothing OrElse (InlineAssignHelper(tempEl, el.Element("accessSecurity"))) IsNot Nothing Then
                accessSecurity = New SecurityController(tempEl, False)
            End If
            If (InlineAssignHelper(tempEl, el.Element(WorldManager.BuildSecurityXmlTagName))) IsNot Nothing OrElse (InlineAssignHelper(tempEl, el.Element("buildSecurity"))) IsNot Nothing Then
                buildSecurity = New SecurityController(tempEl, False)
            End If

            Dim blockEl As XElement = el.Element(BlockDB.XmlRootName)
            If blockEl Is Nothing Then
                BlockDBEnabled = YesNoAuto.Auto
            Else
                If (InlineAssignHelper(temp, blockEl.Attribute("enabled"))) IsNot Nothing Then
                    Dim enabledStateTemp As YesNoAuto
                    If EnumUtil.TryParse(temp.Value, enabledStateTemp, True) Then
                        BlockDBEnabled = enabledStateTemp
                    Else
                        Logger.Log(LogType.Warning, "WorldListEntity: Could not parse BlockDB ""enabled"" attribute of world ""{0}"", assuming ""Auto"".", m_name)
                        BlockDBEnabled = YesNoAuto.Auto
                    End If
                End If

                If (InlineAssignHelper(temp, blockEl.Attribute("preload"))) IsNot Nothing Then
                    Dim isPreloaded As Boolean
                    If [Boolean].TryParse(temp.Value, isPreloaded) Then
                        blockDBIsPreloaded = isPreloaded
                    Else
                        Logger.Log(LogType.Warning, "WorldListEntity: Could not parse BlockDB ""preload"" attribute of world ""{0}"", assuming NOT preloaded.", m_name)
                    End If
                End If
                If (InlineAssignHelper(temp, blockEl.Attribute("limit"))) IsNot Nothing Then
                    Dim limit As Integer
                    If Int32.TryParse(temp.Value, limit) Then
                        blockDBLimit = limit
                    Else
                        Logger.Log(LogType.Warning, "WorldListEntity: Could not parse BlockDB ""limit"" attribute of world ""{0}"", assuming NO limit.", m_name)
                    End If
                End If
                If (InlineAssignHelper(temp, blockEl.Attribute("timeLimit"))) IsNot Nothing Then
                    Dim timeLimitSeconds As Integer
                    If Int32.TryParse(temp.Value, timeLimitSeconds) Then
                        blockDBTimeLimit = System.TimeSpan.FromSeconds(timeLimitSeconds)
                    Else
                        Logger.Log(LogType.Warning, "WorldListEntity: Could not parse BlockDB ""timeLimit"" attribute of world ""{0}"", assuming NO time limit.", m_name)
                    End If
                End If
            End If

            If (InlineAssignHelper(tempEl, el.Element("LoadedBy"))) IsNot Nothing Then
                LoadedBy = tempEl.Value
            End If
            If (InlineAssignHelper(tempEl, el.Element("MapChangedBy"))) IsNot Nothing Then
                MapChangedBy = tempEl.Value
            End If

            If (InlineAssignHelper(tempEl, el.Element("LoadedOn"))) IsNot Nothing Then
                If Not tempEl.Value.ToDateTime(LoadedOn) Then
                    LoadedOn = DateTime.MinValue
                End If
            End If
            If (InlineAssignHelper(tempEl, el.Element("MapChangedOn"))) IsNot Nothing Then
                If Not tempEl.Value.ToDateTime(MapChangedOn) Then
                    MapChangedOn = DateTime.MinValue
                End If
            End If
            environmentEl = el.Element(WorldManager.EnvironmentXmlTagName)
        End Sub

        Public LoadedBy As String, MapChangedBy As String
        Public LoadedOn As DateTime, MapChangedOn As DateTime
        ReadOnly environmentEl As XElement


#Region "List Properties"

        Private m_name As String
        <SortableProperty(GetType(WorldListEntry), "Compare")> _
        Public Property Name() As String
            Get
                Return m_name
            End Get
            Set(value As String)
                If m_name = value Then
                    Return
                End If
                If Not World.IsValidName(value) Then

                    Throw New FormatException("Invalid world name")
                ElseIf Not value.Equals(m_name, StringComparison.OrdinalIgnoreCase) AndAlso MainForm.IsWorldNameTaken(value) Then

                    Throw New FormatException("Duplicate world names are not allowed.")
                Else
                    Dim oldName As String = m_name
                    Dim oldFileName As String = Path.Combine(Paths.MapPath, oldName & Convert.ToString(".fcm"))
                    Dim newFileName As String = Path.Combine(Paths.MapPath, value & Convert.ToString(".fcm"))
                    If File.Exists(oldFileName) Then
                        Dim isSameFile As Boolean
                        If MonoCompat.IsCaseSensitive Then
                            isSameFile = newFileName.Equals(oldFileName, StringComparison.Ordinal)
                        Else
                            isSameFile = newFileName.Equals(oldFileName, StringComparison.OrdinalIgnoreCase)
                        End If
                        If File.Exists(newFileName) AndAlso Not isSameFile Then
                            Dim messageText As String = [String].Format("Map file ""{0}"" already exists. Overwrite?", value & Convert.ToString(".fcm"))
                            Dim result = MessageBox.Show(messageText, "", MessageBoxButtons.OKCancel)
                            If result = DialogResult.Cancel Then
                                Return
                            End If
                        End If
                        Paths.ForceRename(oldFileName, newFileName)
                    End If
                    m_name = value
                    If oldName IsNot Nothing Then
                        MainForm.HandleWorldRename(oldName, m_name)
                    End If
                End If
            End Set
        End Property


        <SortableProperty(GetType(WorldListEntry), "Compare")> _
        Public ReadOnly Property Description() As String
            Get
                Dim mapHeader__1 As Map = MapHeader
                If LoadingFailed Then
                    Return "(cannot load file)"
                Else
                    Return [String].Format("{0} × {1} × {2}", mapHeader__1.Width, mapHeader__1.Length, mapHeader__1.Height)
                End If
            End Get
        End Property


        Public Property Hidden() As Boolean
            Get
                Return m_Hidden
            End Get
            Set(value As Boolean)
                m_Hidden = value
            End Set
        End Property
        Private m_Hidden As Boolean


        ReadOnly accessSecurity As New SecurityController()
        Private accessRankString As String
        Public Property AccessPermission() As String
            Get
                If accessSecurity.HasRankRestriction Then
                    Return MainForm.ToComboBoxOption(accessSecurity.MinRank)
                Else
                    Return DefaultRankOption
                End If
            End Get
            Set(value As String)
                For Each rank As Rank In RankManager.Ranks
                    If MainForm.ToComboBoxOption(rank) = value Then
                        accessSecurity.MinRank = rank
                        accessRankString = rank.FullName
                        Return
                    End If
                Next
                accessSecurity.ResetMinRank()
                accessRankString = ""
            End Set
        End Property


        ReadOnly buildSecurity As New SecurityController()
        Private buildRankString As String
        Public Property BuildPermission() As String
            Get
                If buildSecurity.HasRankRestriction Then
                    Return MainForm.ToComboBoxOption(buildSecurity.MinRank)
                Else
                    Return DefaultRankOption
                End If
            End Get
            Set(value As String)
                For Each rank As Rank In RankManager.Ranks
                    If MainForm.ToComboBoxOption(rank) = value Then
                        buildSecurity.MinRank = rank
                        buildRankString = rank.FullName
                        Return
                    End If
                Next
                buildSecurity.ResetMinRank()
                buildRankString = Nothing
            End Set
        End Property


        Public Property Backup() As String
            Get
                Return m_Backup
            End Get
            Set(value As String)
                m_Backup = value
            End Set
        End Property
        Private m_Backup As String

#End Region


        Friend Function Serialize() As XElement
            Dim element As New XElement("World")
            element.Add(New XAttribute("name", Name))
            element.Add(New XAttribute("hidden", Hidden))
            If Backup <> BackupEnumNames(0) Then
                element.Add(New XAttribute("backup", BackupValueFromName(Backup).ToTickString()))
            End If
            element.Add(accessSecurity.Serialize(WorldManager.AccessSecurityXmlTagName))
            element.Add(buildSecurity.Serialize(WorldManager.BuildSecurityXmlTagName))
            Dim blockDB__1 As New XElement(BlockDB.XmlRootName)
            blockDB__1.Add(New XAttribute("enabled", BlockDBEnabled))
            blockDB__1.Add(New XAttribute("preload", blockDBIsPreloaded))
            blockDB__1.Add(New XAttribute("limit", blockDBLimit))
            blockDB__1.Add(New XAttribute("timeLimit", CInt(blockDBTimeLimit.TotalSeconds)))
            element.Add(blockDB__1)

            If environmentEl IsNot Nothing Then
                element.Add(environmentEl)
            End If

            If Not [String].IsNullOrEmpty(LoadedBy) Then
                element.Add(New XElement("LoadedBy", LoadedBy))
            End If
            If Not [String].IsNullOrEmpty(MapChangedBy) Then
                element.Add(New XElement("MapChangedBy", MapChangedBy))
            End If
            If LoadedOn <> DateTime.MinValue Then
                element.Add(New XElement("LoadedOn", LoadedOn))
            End If
            If MapChangedOn <> DateTime.MinValue Then
                element.Add(New XElement("MapChangedOn", MapChangedOn))
            End If
            Return element
        End Function


        Public Sub ReparseRanks()
            Dim accessMinRank As Rank = Rank.Parse(accessRankString)
            If accessMinRank IsNot Nothing Then
                accessSecurity.MinRank = accessMinRank
            Else
                accessSecurity.ResetMinRank()
            End If

            Dim buildMinRank As Rank = Rank.Parse(buildRankString)
            If buildMinRank IsNot Nothing Then
                buildSecurity.MinRank = buildMinRank
            Else
                buildSecurity.ResetMinRank()
            End If
        End Sub


        Private cachedMapHeader As Map
        Friend ReadOnly Property MapHeader() As Map
            Get
                If cachedMapHeader Is Nothing AndAlso Not LoadingFailed Then
                    Dim fullFileName As String = Path.Combine(Paths.MapPath, m_name & Convert.ToString(".fcm"))
                    LoadingFailed = Not MapUtility.TryLoadHeader(fullFileName, cachedMapHeader)
                End If
                Return cachedMapHeader
            End Get
        End Property


        Friend ReadOnly Property FileName() As String
            Get
                Return Name & MapFileExtension
            End Get
        End Property


        Friend ReadOnly Property FullFileName() As String
            Get
                Return Path.Combine(Paths.MapPath, Name & MapFileExtension)
            End Get
        End Property


#Region "Backup"

        Public Shared Function BackupNameFromValue(value As TimeSpan) As String
            Dim closestMatch As TimeSpan = BackupEnumValues.OrderBy(Function(t) Math.Abs(value.Subtract(t).Ticks)).First()
            Return BackupEnumNames(Array.IndexOf(BackupEnumValues, closestMatch))
        End Function

        Public Shared Function BackupValueFromName(name As String) As TimeSpan
            Return BackupEnumValues(Array.IndexOf(BackupEnumNames, name))
        End Function

        Public Shared ReadOnly BackupEnumNames As String() = {"(default)", "Never", "5 Minutes", "10 Minutes", "15 Minutes", "20 Minutes", _
            "30 Minutes", "45 Minutes", "1 Hour", "2 Hours", "3 Hours", "4 Hours", _
            "6 Hours", "8 Hours", "12 Hours", "24 Hours", "48 Hours"}

        ' default
        Shared ReadOnly BackupEnumValues As TimeSpan() = {TimeSpan.FromSeconds(-1), TimeSpan.Zero, TimeSpan.FromMinutes(5), TimeSpan.FromMinutes(10), TimeSpan.FromMinutes(15), TimeSpan.FromMinutes(20), _
            TimeSpan.FromMinutes(30), TimeSpan.FromMinutes(45), TimeSpan.FromHours(1), TimeSpan.FromHours(2), TimeSpan.FromHours(3), TimeSpan.FromHours(4), _
            TimeSpan.FromHours(6), TimeSpan.FromHours(8), TimeSpan.FromHours(12), TimeSpan.FromHours(24), TimeSpan.FromHours(48)}

#End Region


        Public Property BlockDBEnabled() As YesNoAuto
            Get
                Return m_BlockDBEnabled
            End Get
            Set(value As YesNoAuto)
                m_BlockDBEnabled = value
            End Set
        End Property
        Private m_BlockDBEnabled As YesNoAuto
        ReadOnly blockDBIsPreloaded As Boolean
        ReadOnly blockDBLimit As Integer
        Private blockDBTimeLimit As TimeSpan


        Public Function Clone() As Object
            Return New WorldListEntry(Me)
        End Function


        ' Comparison method used to customize sorting
        <UsedImplicitly> _
        Public Shared Function Compare(propertyName As String, a As Object, b As Object) As Object
            Dim entry1 As WorldListEntry = DirectCast(a, WorldListEntry)
            Dim entry2 As WorldListEntry = DirectCast(b, WorldListEntry)
            Select Case propertyName
                Case "Description"
                    If entry1.MapHeader Is Nothing AndAlso entry2.MapHeader Is Nothing Then
                        Return 0
                    End If
                    If entry1.MapHeader Is Nothing Then
                        Return -1
                    End If
                    If entry2.MapHeader Is Nothing Then
                        Return 1
                    End If
                    Dim volumeDifference As Integer = entry1.MapHeader.Volume - entry2.MapHeader.Volume
                    Return Math.Min(1, Math.Max(-1, volumeDifference))

                Case "Name"
                    Return StringComparer.OrdinalIgnoreCase.Compare(entry1.Name, entry2.Name)
                Case Else

                    Throw New NotImplementedException()
            End Select
        End Function
        Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function

        Public Function ICloneable_Clone() As Object Implements ICloneable.Clone
            Throw New NotImplementedException
        End Function
    End Class
End Namespace