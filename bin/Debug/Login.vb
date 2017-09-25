Imports System.Data
Imports System.Data.SqlClient


Public Class Login
    Private Sub Login_Load()
        txtDate.Text = Convert.ToDateTime(Date.Now)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
        Welcome.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        txtUsername.Text = ""
        txtPasswd.Text = ""
    End Sub

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Welcome.Show()
    End Sub
End Class