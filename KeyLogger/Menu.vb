Public Class Menu

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            Errorlbl.Text = " Please Fill all the above Fields to Register!"
        ElseIf My.Settings.users = 1 Then
            Errorlbl.ForeColor = Color.Chocolate
            Errorlbl.Text = "Only one user can register on a computer! ->" ' & vbCrLf & "Request Multiple user account @ www.dedsec.weebly.com/request"


        Else

            My.Settings.USER = TextBox1.Text
            My.Settings.PASSWORD = TextBox2.Text
            My.Settings.users = 1
            Errorlbl.ForeColor = Color.Green
            Errorlbl.Text = "Registration Succesful!"

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Settings.USER <> vbNullString Then
            If TextBox1.Text = My.Settings.USER And TextBox2.Text = My.Settings.PASSWORD Then
                Errorlbl.Text = "Login Succesful!"
                controlpanel.Show()

                Me.Hide()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.log = 1 Then
            Form1.Show()
            Form1.Hide()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        MsgBox("Your ID:" + My.Settings.USER + "Your Pass:" + My.Settings.PASSWORD)
    End Sub
End Class