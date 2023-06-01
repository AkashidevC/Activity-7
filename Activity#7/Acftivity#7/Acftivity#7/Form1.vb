Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If usernameTxt.Text = "Arjay" And passwordTxt.Text = "1234" Then
            MsgBox("Login Success")
            usernameTxt.Text = ""
            passwordTxt.Text = ""
            Form2.Show()
            Me.Hide()

        Else
            MsgBox("Wrong User or Pass")
            usernameTxt.Text = ""
            passwordTxt.Text = ""
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
