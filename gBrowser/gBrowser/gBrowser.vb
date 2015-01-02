Public Class gBrowser

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoBtn.Click
        WebBrowser1.Navigate(addressBox.Text)

    End Sub

    Private Sub addressBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addressBox.TextChanged

        '++Need to navigate when pressing Enter in addressBox++
        'If e.KeyCode = Keys.Enter Then
3:      'Add "http://" to the beginning of the URL
4:      'If Not addressBox.Text.StartsWith("http://") Then
5:      'addressBox.Text = "http://" & addressBox.Text
6:      'End If
7:
8:      'WebBrowser1.Navigate(addressBox.Text)
9:      'End If
    End Sub

    Private Sub Home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Home.Click
        WebBrowser1.Navigate("www.duckduckgo.com")
    End Sub
End Class
