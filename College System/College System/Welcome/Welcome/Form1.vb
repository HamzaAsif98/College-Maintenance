Public Class Welcome
    Private Sub btnteacher_Click(sender As Object, e As EventArgs) Handles btnteacher.Click
        TeacherLogin.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AdminLogin.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Technicianlogin.Show()
    End Sub

    Private Sub btnfault_Click(sender As Object, e As EventArgs) Handles btnfault.Click
        viewfault.Show()

    End Sub

    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
