Public Class frmShowAppLocation
    Private Sub frmShowAppLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLoc.Text = Application.StartupPath()
    End Sub

    Private Sub btnCopyClipboard_Click(sender As Object, e As EventArgs) Handles btnCopyClipboard.Click
        Clipboard.SetText(Application.StartupPath())
        MessageBox.Show("Location Copied", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class