<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteRankPopup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeleteRankPopup))
        Me.bCancel = New System.Windows.Forms.Button()
        Me.bDelete = New System.Windows.Forms.Button()
        Me.cSubstitute = New System.Windows.Forms.ComboBox()
        Me.lSubstitute = New System.Windows.Forms.Label()
        Me.lWarning = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bCancel
        '
        Me.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bCancel.Location = New System.Drawing.Point(308, 112)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(100, 25)
        Me.bCancel.TabIndex = 9
        Me.bCancel.Text = "Cancel"
        Me.bCancel.UseVisualStyleBackColor = True
        '
        'bDelete
        '
        Me.bDelete.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bDelete.Enabled = False
        Me.bDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDelete.Location = New System.Drawing.Point(202, 112)
        Me.bDelete.Name = "bDelete"
        Me.bDelete.Size = New System.Drawing.Size(100, 25)
        Me.bDelete.TabIndex = 8
        Me.bDelete.Text = "Delete"
        Me.bDelete.UseVisualStyleBackColor = True
        '
        'cSubstitute
        '
        Me.cSubstitute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cSubstitute.FormattingEnabled = True
        Me.cSubstitute.Location = New System.Drawing.Point(101, 66)
        Me.cSubstitute.Name = "cSubstitute"
        Me.cSubstitute.Size = New System.Drawing.Size(121, 21)
        Me.cSubstitute.TabIndex = 7
        '
        'lSubstitute
        '
        Me.lSubstitute.AutoSize = True
        Me.lSubstitute.Location = New System.Drawing.Point(11, 69)
        Me.lSubstitute.Name = "lSubstitute"
        Me.lSubstitute.Size = New System.Drawing.Size(81, 13)
        Me.lSubstitute.TabIndex = 6
        Me.lSubstitute.Text = "Substitute rank:"
        '
        'lWarning
        '
        Me.lWarning.AutoSize = True
        Me.lWarning.Location = New System.Drawing.Point(11, 9)
        Me.lWarning.Name = "lWarning"
        Me.lWarning.Size = New System.Drawing.Size(393, 39)
        Me.lWarning.TabIndex = 5
        Me.lWarning.Text = resources.GetString("lWarning.Text")
        '
        'DeleteRankPopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 147)
        Me.Controls.Add(Me.bCancel)
        Me.Controls.Add(Me.bDelete)
        Me.Controls.Add(Me.cSubstitute)
        Me.Controls.Add(Me.lSubstitute)
        Me.Controls.Add(Me.lWarning)
        Me.Name = "DeleteRankPopup"
        Me.Text = "DeleteRankPopup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents bCancel As System.Windows.Forms.Button
    Private WithEvents bDelete As System.Windows.Forms.Button
    Private WithEvents cSubstitute As System.Windows.Forms.ComboBox
    Private WithEvents lSubstitute As System.Windows.Forms.Label
    Private WithEvents lWarning As System.Windows.Forms.Label
End Class
