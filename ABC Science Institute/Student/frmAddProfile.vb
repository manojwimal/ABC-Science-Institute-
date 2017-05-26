Imports System.Data.OleDb

Public Class frmAddProfile

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub frmAddProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String = "SELECT COUNT(*) FROM tblStudent"
        Dim sqlcommand As OleDbCommand
        sqlcommand = New OleDbCommand(sql, frmMain.connection)
        Dim datareader As OleDbDataReader = sqlcommand.ExecuteReader()
        Try
            While datareader.Read()
                txtIndex.Text = Val(datareader.Item(0)) + 1

            End While

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sqlc As New OleDbCommand("INSERT INTO tblStudent (stdFirstName,stdLastName,stdSchool,stdJoinedDate,stdPhoneNo,stdAddress,stdStatus) VALUES('" + txtFN.Text + "','" + txtLN.Text + "','" + txtSchool.Text + "','" + dtpJD.Value.ToShortDateString + "','" + txtTP.Text + "','" + txtAdr.Text.Replace(vbCrLf, " ").ToString + "','" + CheckBox1.Checked.ToString + "')", frmMain.connection)
        Dim I As Integer
        Try
            I = sqlc.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        MsgBox("Student profile saved successfully.", MsgBoxStyle.Information)
        Me.Close()
    End Sub
End Class