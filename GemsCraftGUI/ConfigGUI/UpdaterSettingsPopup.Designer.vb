<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdaterSettingsPopup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gMode = New System.Windows.Forms.GroupBox()
        Me.rAutomatic = New System.Windows.Forms.RadioButton()
        Me.rPrompt = New System.Windows.Forms.RadioButton()
        Me.rNotify = New System.Windows.Forms.RadioButton()
        Me.rDisabled = New System.Windows.Forms.RadioButton()
        Me.gOptions = New System.Windows.Forms.GroupBox()
        Me.tRunAfterUpdate = New System.Windows.Forms.TextBox()
        Me.xRunAfterUpdate = New System.Windows.Forms.CheckBox()
        Me.tRunBeforeUpdate = New System.Windows.Forms.TextBox()
        Me.xRunBeforeUpdate = New System.Windows.Forms.CheckBox()
        Me.xBackupBeforeUpdating = New System.Windows.Forms.CheckBox()
        Me.bCancel = New System.Windows.Forms.Button()
        Me.bOK = New System.Windows.Forms.Button()
        Me.gMode.SuspendLayout()
        Me.gOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'gMode
        '
        Me.gMode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gMode.Controls.Add(Me.rAutomatic)
        Me.gMode.Controls.Add(Me.rPrompt)
        Me.gMode.Controls.Add(Me.rNotify)
        Me.gMode.Controls.Add(Me.rDisabled)
        Me.gMode.Location = New System.Drawing.Point(12, 13)
        Me.gMode.Name = "gMode"
        Me.gMode.Size = New System.Drawing.Size(322, 119)
        Me.gMode.TabIndex = 4
        Me.gMode.TabStop = False
        Me.gMode.Text = "Updater preference"
        '
        'rAutomatic
        '
        Me.rAutomatic.AutoSize = True
        Me.rAutomatic.Location = New System.Drawing.Point(15, 92)
        Me.rAutomatic.Name = "rAutomatic"
        Me.rAutomatic.Size = New System.Drawing.Size(274, 17)
        Me.rAutomatic.TabIndex = 3
        Me.rAutomatic.TabStop = True
        Me.rAutomatic.Text = "Automatic - Download and apply all updates at once."
        Me.rAutomatic.UseVisualStyleBackColor = True
        '
        'rPrompt
        '
        Me.rPrompt.AutoSize = True
        Me.rPrompt.Location = New System.Drawing.Point(15, 69)
        Me.rPrompt.Name = "rPrompt"
        Me.rPrompt.Size = New System.Drawing.Size(282, 17)
        Me.rPrompt.TabIndex = 2
        Me.rPrompt.TabStop = True
        Me.rPrompt.Text = "Prompt - Prepare updates to install, and ask to confirm."
        Me.rPrompt.UseVisualStyleBackColor = True
        '
        'rNotify
        '
        Me.rNotify.AutoSize = True
        Me.rNotify.Location = New System.Drawing.Point(15, 46)
        Me.rNotify.Name = "rNotify"
        Me.rNotify.Size = New System.Drawing.Size(278, 17)
        Me.rNotify.TabIndex = 1
        Me.rNotify.TabStop = True
        Me.rNotify.Text = "Notify - Show a message when updates are available."
        Me.rNotify.UseVisualStyleBackColor = True
        '
        'rDisabled
        '
        Me.rDisabled.AutoSize = True
        Me.rDisabled.Location = New System.Drawing.Point(15, 23)
        Me.rDisabled.Name = "rDisabled"
        Me.rDisabled.Size = New System.Drawing.Size(199, 17)
        Me.rDisabled.TabIndex = 0
        Me.rDisabled.TabStop = True
        Me.rDisabled.Text = "Disabled - Do not check for updates."
        Me.rDisabled.UseVisualStyleBackColor = True
        '
        'gOptions
        '
        Me.gOptions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gOptions.Controls.Add(Me.tRunAfterUpdate)
        Me.gOptions.Controls.Add(Me.xRunAfterUpdate)
        Me.gOptions.Controls.Add(Me.tRunBeforeUpdate)
        Me.gOptions.Controls.Add(Me.xRunBeforeUpdate)
        Me.gOptions.Controls.Add(Me.xBackupBeforeUpdating)
        Me.gOptions.Location = New System.Drawing.Point(12, 138)
        Me.gOptions.Name = "gOptions"
        Me.gOptions.Size = New System.Drawing.Size(322, 147)
        Me.gOptions.TabIndex = 5
        Me.gOptions.TabStop = False
        Me.gOptions.Text = "Optional features"
        '
        'tRunAfterUpdate
        '
        Me.tRunAfterUpdate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tRunAfterUpdate.Enabled = False
        Me.tRunAfterUpdate.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRunAfterUpdate.Location = New System.Drawing.Point(43, 118)
        Me.tRunAfterUpdate.Name = "tRunAfterUpdate"
        Me.tRunAfterUpdate.Size = New System.Drawing.Size(273, 20)
        Me.tRunAfterUpdate.TabIndex = 4
        '
        'xRunAfterUpdate
        '
        Me.xRunAfterUpdate.AutoSize = True
        Me.xRunAfterUpdate.Location = New System.Drawing.Point(15, 95)
        Me.xRunAfterUpdate.Name = "xRunAfterUpdate"
        Me.xRunAfterUpdate.Size = New System.Drawing.Size(215, 17)
        Me.xRunAfterUpdate.TabIndex = 3
        Me.xRunAfterUpdate.Text = "Run a script or command after updating:"
        Me.xRunAfterUpdate.UseVisualStyleBackColor = True
        '
        'tRunBeforeUpdate
        '
        Me.tRunBeforeUpdate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tRunBeforeUpdate.Enabled = False
        Me.tRunBeforeUpdate.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRunBeforeUpdate.Location = New System.Drawing.Point(43, 69)
        Me.tRunBeforeUpdate.Name = "tRunBeforeUpdate"
        Me.tRunBeforeUpdate.Size = New System.Drawing.Size(273, 20)
        Me.tRunBeforeUpdate.TabIndex = 2
        '
        'xRunBeforeUpdate
        '
        Me.xRunBeforeUpdate.AutoSize = True
        Me.xRunBeforeUpdate.Location = New System.Drawing.Point(15, 46)
        Me.xRunBeforeUpdate.Name = "xRunBeforeUpdate"
        Me.xRunBeforeUpdate.Size = New System.Drawing.Size(224, 17)
        Me.xRunBeforeUpdate.TabIndex = 1
        Me.xRunBeforeUpdate.Text = "Run a script or command before updating:"
        Me.xRunBeforeUpdate.UseVisualStyleBackColor = True
        '
        'xBackupBeforeUpdating
        '
        Me.xBackupBeforeUpdating.AutoSize = True
        Me.xBackupBeforeUpdating.Location = New System.Drawing.Point(15, 23)
        Me.xBackupBeforeUpdating.Name = "xBackupBeforeUpdating"
        Me.xBackupBeforeUpdating.Size = New System.Drawing.Size(284, 17)
        Me.xBackupBeforeUpdating.TabIndex = 0
        Me.xBackupBeforeUpdating.Text = "Back up server data and configuration before updating"
        Me.xBackupBeforeUpdating.UseVisualStyleBackColor = True
        '
        'bCancel
        '
        Me.bCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bCancel.Location = New System.Drawing.Point(259, 291)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(75, 23)
        Me.bCancel.TabIndex = 7
        Me.bCancel.Text = "Cancel"
        Me.bCancel.UseVisualStyleBackColor = True
        '
        'bOK
        '
        Me.bOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bOK.Location = New System.Drawing.Point(178, 291)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(75, 23)
        Me.bOK.TabIndex = 6
        Me.bOK.Text = "OK"
        Me.bOK.UseVisualStyleBackColor = True
        '
        'UpdaterSettingsPopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 326)
        Me.Controls.Add(Me.gMode)
        Me.Controls.Add(Me.gOptions)
        Me.Controls.Add(Me.bCancel)
        Me.Controls.Add(Me.bOK)
        Me.Name = "UpdaterSettingsPopup"
        Me.Text = "UpdaterSettingsPopup"
        Me.gMode.ResumeLayout(False)
        Me.gMode.PerformLayout()
        Me.gOptions.ResumeLayout(False)
        Me.gOptions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents gMode As System.Windows.Forms.GroupBox
    Private WithEvents rAutomatic As System.Windows.Forms.RadioButton
    Private WithEvents rPrompt As System.Windows.Forms.RadioButton
    Private WithEvents rNotify As System.Windows.Forms.RadioButton
    Private WithEvents rDisabled As System.Windows.Forms.RadioButton
    Private WithEvents gOptions As System.Windows.Forms.GroupBox
    Private WithEvents tRunAfterUpdate As System.Windows.Forms.TextBox
    Private WithEvents xRunAfterUpdate As System.Windows.Forms.CheckBox
    Private WithEvents tRunBeforeUpdate As System.Windows.Forms.TextBox
    Private WithEvents xRunBeforeUpdate As System.Windows.Forms.CheckBox
    Private WithEvents xBackupBeforeUpdating As System.Windows.Forms.CheckBox
    Private WithEvents bCancel As System.Windows.Forms.Button
    Private WithEvents bOK As System.Windows.Forms.Button
End Class
