Imports System.Data.OleDb

Public Class frmMain
    Public connectionstring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + CurDir() + "\ScienceIns.accdb"
    Public connection As OleDbConnection
    Private Sub AddStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStudentToolStripMenuItem.Click
        Dim tempForm As New frmAddProfile
        tempForm.MdiParent = Me
        tempForm.StartPosition = FormStartPosition.CenterScreen
        tempForm.Show()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection = New OleDbConnection(connectionstring)
        connection.Open()
        Dim CC As New Form2
        CC.MdiParent = Me
        CC.Show()
    End Sub

    Private Sub UpdateStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateStudentToolStripMenuItem.Click
        Dim tempForm As New frmUpdateStudent
        tempForm.MdiParent = Me
        tempForm.StartPosition = FormStartPosition.CenterScreen
        tempForm.Show()
    End Sub

    Private Sub MakePaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MakePaymentToolStripMenuItem.Click
        Dim tempForm As New frmMakePayment
        tempForm.MdiParent = Me
        tempForm.StartPosition = FormStartPosition.CenterScreen
        tempForm.Show()
    End Sub

    Private Sub SubjectFeesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectFeesToolStripMenuItem.Click
        Dim tempForm As New frmSubjectFees
        tempForm.MdiParent = Me
        tempForm.StartPosition = FormStartPosition.CenterScreen
        tempForm.Show()
    End Sub

    Private Sub StudentDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentDetailsToolStripMenuItem.Click
        Dim tempForm As New frmStudentDetails
        tempForm.MdiParent = Me
        tempForm.StartPosition = FormStartPosition.CenterScreen
        tempForm.Show()
    End Sub

    Private Sub IncomeByMonthToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncomeByMonthToolStripMenuItem.Click
        Dim tempForm As New frmIncomeByMonth
        tempForm.MdiParent = Me
        tempForm.StartPosition = FormStartPosition.CenterScreen
        tempForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("Are you sure that you want to exit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            connection.Close()
            Me.Close()

        End If
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Dim tempForm As New frmCredentials
        tempForm.MdiParent = Me
        tempForm.StartPosition = FormStartPosition.CenterScreen
        tempForm.Show()
    End Sub

    Private Sub WelcomeScreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WelcomeScreenToolStripMenuItem.Click
        Dim CC As New Form2
        CC.MdiParent = Me
        CC.Show()
    End Sub
End Class