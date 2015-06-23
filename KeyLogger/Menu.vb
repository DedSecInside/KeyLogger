Public Class Menu

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            Errorlbl.Text = " Please Fill all the above Fields to Register!"
        End If
    End Sub
End Class