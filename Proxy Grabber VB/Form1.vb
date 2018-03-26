Imports System.Net
Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        R1.Clear()
        Using X As New WebClient
            AddHandler X.DownloadProgressChanged, AddressOf progress
            AddHandler X.DownloadStringCompleted, AddressOf complete
            X.DownloadStringAsync(New Uri(txtlink.Text))
        End Using
    End Sub

    Private Sub progress(sender As Object, e As DownloadProgressChangedEventArgs)
        On Error Resume Next
        P1.Value = e.ProgressPercentage
    End Sub
    Private Sub complete(sender As Object, e As DownloadStringCompletedEventArgs)
        On Error Resume Next
        For Each o As Match In New Regex("(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}:\d{1,4})").Matches(e.Result)
            R1.AppendText(o.Value & vbCrLf)
        Next
    End Sub

    Private Sub P1_Click(sender As Object, e As EventArgs) Handles P1.Click

    End Sub

    Private Sub R1_TextChanged(sender As Object, e As EventArgs) Handles R1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        txtlink.Text = "sdafs"
    End Sub

    Private Sub txtaeuk_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txtlink.Text = "http://proxy-daily.com/"
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        txtlink.Text = "http://multiproxy.org/txt_all/proxy.txt"
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        txtlink.Text = "http://nntime.com/"
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        txtlink.Text = "https://premproxy.com/socks-list/02.htm"
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        txtlink.Text = "https://proxy-grabber.com/"
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        txtlink.Text = "https://proxy-list.org/english/index.php"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("https://leakedforums.com/search/390384/?q=socks&o=date&c[title_only]=1&c[node]=48")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtlink.Text = "https://leakedforums.com/threads/vn5socks-net-auto-update-24-7-good-socks-9h15-am.1592/"
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://github.com/akalankauk")
    End Sub
End Class
