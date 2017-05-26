Imports System.Data.OleDb

Public Class frmUpdateStudent

    Private Sub frmUpdateStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sql As String = "SELECT stdFirstName,stdLastName,stdSchool,stdJoinedDate,stdPhoneNo,stdAddress,stdStatus FROM tblStudent WHERE stdID=" + Val(txtIndex.Text).ToString
        Dim sqlcommand As OleDbCommand
        'MsgBox(sql)
        sqlcommand = New OleDbCommand(sql, frmMain.connection)
        Dim datareader As OleDbDataReader = sqlcommand.ExecuteReader()




        Try
            While datareader.Read()
                txtFN.Text = datareader.Item(0)
                txtLN.Text = datareader.Item(1)
                txtSchool.Text = datareader.Item(2)
                dtpJD.Value = CDate(datareader.Item(3))
                txtTP.Text = datareader.Item(4)
                txtAdr.Text = datareader.Item(5)
                If datareader.Item(6).ToString.ToLower = "true" Then
                    CheckBox1.Checked = True
                Else
                    CheckBox1.Checked = False
                End If
                txtFN.Enabled = True
                txtLN.Enabled = True
                txtSchool.Enabled = True
                dtpJD.Enabled = True
                txtTP.Enabled = True
                txtAdr.Enabled = True
                txtIndex.Enabled = False
                Button1.Enabled = True
                CheckBox1.Enabled = True
                Button2.Enabled = False

            End While
            'End Try

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation)

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sqlc As New OleDbCommand("UPDATE tblStudent SET " + _
                                     "stdFirstName='" + txtFN.Text + "'," + _
                                     "stdLastName='" + txtLN.Text + "'," + _
                                     "stdSchool='" + txtSchool.Text + "'," + _
                                     "stdJoinedDate='" + dtpJD.Value.ToShortDateString + "'," + _
                                     "stdPhoneNo='" + txtTP.Text + "'," + _
                                     "stdAddress='" + txtAdr.Text + "'," + _
                                     "stdStatus='" + CheckBox1.Checked.ToString + "' WHERE stdID=" + Val(txtIndex.Text).ToString, _
                                     frmMain.connection)
        Dim I As Integer
        Try
            I = sqlc.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation)
        End Try
        MsgBox("Student profile updated successfully", MsgBoxStyle.Information)
        Me.Close()
    End Sub
End Class