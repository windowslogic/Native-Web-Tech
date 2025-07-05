Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate(Application.StartupPath.ToString & "/webview/index.html")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If WebBrowser1.DocumentTitle.Contains("close") Then
            Me.Close()
        End If
    End Sub
End Class
