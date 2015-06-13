<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextEditorPopup
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
        Me.bReset = New System.Windows.Forms.Button()
        Me.bInsertColor = New System.Windows.Forms.Button()
        Me.bInsertKeyword = New System.Windows.Forms.Button()
        Me.lWarning = New System.Windows.Forms.Label()
        Me.bCancel = New System.Windows.Forms.Button()
        Me.bOK = New System.Windows.Forms.Button()
        Me.tText = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bReset
        '
        Me.bReset.Location = New System.Drawing.Point(408, 12)
        Me.bReset.Name = "bReset"
        Me.bReset.Size = New System.Drawing.Size(90, 23)
        Me.bReset.TabIndex = 12
        Me.bReset.Text = "Reset"
        Me.bReset.UseVisualStyleBackColor = True
        '
        'bInsertColor
        '
        Me.bInsertColor.Location = New System.Drawing.Point(12, 12)
        Me.bInsertColor.Name = "bInsertColor"
        Me.bInsertColor.Size = New System.Drawing.Size(90, 23)
        Me.bInsertColor.TabIndex = 9
        Me.bInsertColor.Text = "Insert Color"
        Me.bInsertColor.UseVisualStyleBackColor = True
        '
        'bInsertKeyword
        '
        Me.bInsertKeyword.Location = New System.Drawing.Point(108, 12)
        Me.bInsertKeyword.Name = "bInsertKeyword"
        Me.bInsertKeyword.Size = New System.Drawing.Size(90, 23)
        Me.bInsertKeyword.TabIndex = 10
        Me.bInsertKeyword.Text = "Insert Keyword"
        Me.bInsertKeyword.UseVisualStyleBackColor = True
        '
        'lWarning
        '
        Me.lWarning.AutoSize = True
        Me.lWarning.Location = New System.Drawing.Point(12, 283)
        Me.lWarning.Name = "lWarning"
        Me.lWarning.Size = New System.Drawing.Size(272, 13)
        Me.lWarning.TabIndex = 11
        Me.lWarning.Text = "Warning: Lines over 64 characters long will be wrapped."
        '
        'bCancel
        '
        Me.bCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCancel.Location = New System.Drawing.Point(398, 274)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(100, 28)
        Me.bCancel.TabIndex = 8
        Me.bCancel.Text = "Cancel"
        '
        'bOK
        '
        Me.bOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bOK.Location = New System.Drawing.Point(292, 274)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(100, 28)
        Me.bOK.TabIndex = 7
        Me.bOK.Text = "OK"
        '
        'tText
        '
        Me.tText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tText.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tText.Location = New System.Drawing.Point(13, 41)
        Me.tText.Multiline = True
        Me.tText.Name = "tText"
        Me.tText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tText.Size = New System.Drawing.Size(485, 227)
        Me.tText.TabIndex = 6
        Me.tText.WordWrap = False
        '
        'TextEditorPopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 314)
        Me.Controls.Add(Me.bReset)
        Me.Controls.Add(Me.bInsertColor)
        Me.Controls.Add(Me.bInsertKeyword)
        Me.Controls.Add(Me.lWarning)
        Me.Controls.Add(Me.bCancel)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.tText)
        Me.Name = "TextEditorPopup"
        Me.Text = "TextEditorPopup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents bReset As System.Windows.Forms.Button
    Private WithEvents bInsertColor As System.Windows.Forms.Button
    Private WithEvents bInsertKeyword As System.Windows.Forms.Button
    Private WithEvents lWarning As System.Windows.Forms.Label
    Private WithEvents bCancel As System.Windows.Forms.Button
    Private WithEvents bOK As System.Windows.Forms.Button
    Private WithEvents tText As System.Windows.Forms.TextBox
End Class
