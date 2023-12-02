Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SQLSTATEMENT As String = "UPDATE 'user' SET' Fullname'='" & TextBox1.Text & "',TextBox2' ='" & TextBox1.Text & "' ,'TextBox3'='" & TextBox2.Text
        save(SQLSTATEMENT)
        MsgBox("Data update successfuly", vbInformation)
    End Sub
End Class