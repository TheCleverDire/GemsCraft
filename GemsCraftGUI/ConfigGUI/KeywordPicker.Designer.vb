<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KeywordPicker
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
        Me.bCancel = New System.Windows.Forms.Button()
        Me.pFlow = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'bCancel
        '
        Me.bCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bCancel.Location = New System.Drawing.Point(62, 337)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(60, 23)
        Me.bCancel.TabIndex = 3
        Me.bCancel.Text = "Cancel"
        Me.bCancel.UseVisualStyleBackColor = True
        '
        'pFlow
        '
        Me.pFlow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pFlow.Location = New System.Drawing.Point(13, 13)
        Me.pFlow.Name = "pFlow"
        Me.pFlow.Size = New System.Drawing.Size(159, 318)
        Me.pFlow.TabIndex = 2
        '
        'KeywordPicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 372)
        Me.Controls.Add(Me.bCancel)
        Me.Controls.Add(Me.pFlow)
        Me.Name = "KeywordPicker"
        Me.Text = "KeywordPicker"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents bCancel As System.Windows.Forms.Button
    Private WithEvents pFlow As System.Windows.Forms.FlowLayoutPanel
End Class
