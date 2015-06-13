<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PermissionLimitBox
    Inherits System.Windows.Forms.Control

    'Control overrides dispose to clean up the component list.
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

    'Required by the Control Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Component Designer
    ' It can be modified using the Component Designer.  Do not modify it
    ' using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.comboBox = New System.Windows.Forms.ComboBox()
        Me.label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'comboBox
        '
        Me.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox.FormattingEnabled = True
        Me.comboBox.Location = New System.Drawing.Point(80, 0)
        Me.comboBox.Name = "comboBox"
        Me.comboBox.Size = New System.Drawing.Size(150, 21)
        Me.comboBox.TabIndex = 1
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(3, 3)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(33, 13)
        Me.label.TabIndex = 0
        Me.label.Text = "Label"
        Me.label.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents comboBox As System.Windows.Forms.ComboBox
    Private WithEvents label As System.Windows.Forms.Label

End Class

