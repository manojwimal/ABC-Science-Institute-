Public Class Form2

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim tempForm As New frmAddProfile
        tempForm.MdiParent = frmMain
        tempForm.StartPosition = FormStartPosition.CenterScreen
        tempForm.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If frmMain.UpdateStudentToolStripMenuItem.Enabled = True Then
            Dim tempForm As New frmUpdateStudent
            tempForm.MdiParent = frmMain
            tempForm.StartPosition = FormStartPosition.CenterScreen
            tempForm.Show()
            Me.Close()
        Else
            MsgBox("You dont have enough privilidges to perform this task", MsgBoxStyle.Exclamation)
        End If
        
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Dim tempForm As New frmMakePayment
        tempForm.MdiParent = frmMain
        tempForm.StartPosition = FormStartPosition.CenterScreen
        tempForm.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class