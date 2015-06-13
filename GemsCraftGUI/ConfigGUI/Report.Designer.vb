<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.panelRequest = New System.Windows.Forms.Panel()
        Me.bCancel = New System.Windows.Forms.Button()
        Me.bSubmit = New System.Windows.Forms.Button()
        Me.tReport = New System.Windows.Forms.TextBox()
        Me.tEmail = New System.Windows.Forms.TextBox()
        Me.lRequest = New System.Windows.Forms.Label()
        Me.panelRequest.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelRequest
        '
        Me.panelRequest.BackColor = System.Drawing.SystemColors.Control
        Me.panelRequest.Controls.Add(Me.bCancel)
        Me.panelRequest.Controls.Add(Me.bSubmit)
        Me.panelRequest.Controls.Add(Me.tReport)
        Me.panelRequest.Controls.Add(Me.tEmail)
        Me.panelRequest.Location = New System.Drawing.Point(-12, 44)
        Me.panelRequest.Name = "panelRequest"
        Me.panelRequest.Size = New System.Drawing.Size(532, 238)
        Me.panelRequest.TabIndex = 2
        '
        'bCancel
        '
        Me.bCancel.BackColor = System.Drawing.Color.IndianRed
        Me.bCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown
        Me.bCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancel.Location = New System.Drawing.Point(337, 198)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(72, 28)
        Me.bCancel.TabIndex = 4
        Me.bCancel.Text = "Cancel"
        Me.bCancel.UseVisualStyleBackColor = False
        '
        'bSubmit
        '
        Me.bSubmit.BackColor = System.Drawing.Color.LightSteelBlue
        Me.bSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray
        Me.bSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray
        Me.bSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSubmit.Location = New System.Drawing.Point(430, 198)
        Me.bSubmit.Name = "bSubmit"
        Me.bSubmit.Size = New System.Drawing.Size(72, 28)
        Me.bSubmit.TabIndex = 3
        Me.bSubmit.Text = "Submit"
        Me.bSubmit.UseVisualStyleBackColor = False
        '
        'tReport
        '
        Me.tReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tReport.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.tReport.Location = New System.Drawing.Point(19, 62)
        Me.tReport.Multiline = True
        Me.tReport.Name = "tReport"
        Me.tReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tReport.Size = New System.Drawing.Size(455, 123)
        Me.tReport.TabIndex = 0
        Me.tReport.TabStop = False
        Me.tReport.Text = "Type in your bug report/feature request here..."
        '
        'tEmail
        '
        Me.tEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tEmail.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.tEmail.Location = New System.Drawing.Point(19, 17)
        Me.tEmail.Multiline = True
        Me.tEmail.Name = "tEmail"
        Me.tEmail.Size = New System.Drawing.Size(181, 25)
        Me.tEmail.TabIndex = 0
        Me.tEmail.TabStop = False
        Me.tEmail.Text = "Email..."
        '
        'lRequest
        '
        Me.lRequest.AutoSize = True
        Me.lRequest.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lRequest.Location = New System.Drawing.Point(39, 4)
        Me.lRequest.Name = "lRequest"
        Me.lRequest.Size = New System.Drawing.Size(400, 28)
        Me.lRequest.TabIndex = 3
        Me.lRequest.Text = "Request a feature or report a bug fix here"
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(509, 286)
        Me.Controls.Add(Me.panelRequest)
        Me.Controls.Add(Me.lRequest)
        Me.Name = "Report"
        Me.Text = "Report"
        Me.panelRequest.ResumeLayout(False)
        Me.panelRequest.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents panelRequest As System.Windows.Forms.Panel
    Private WithEvents bCancel As System.Windows.Forms.Button
    Private WithEvents bSubmit As System.Windows.Forms.Button
    Private WithEvents tReport As System.Windows.Forms.TextBox
    Private WithEvents tEmail As System.Windows.Forms.TextBox
    Private WithEvents lRequest As System.Windows.Forms.Label
End Class
