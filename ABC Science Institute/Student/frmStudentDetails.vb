Imports System.Data.OleDb

Public Class frmStudentDetails
    Private Sub LoadData()
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


            End While
            'End Try

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation)

        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListView1.Items.Clear()
        LoadData()
        Dim sql As String = "SELECT * FROM tblPayment WHERE payStdID='" + Val(txtIndex.Text).ToString + "' ORDER BY payDate ASC"
        Dim sqlcommand As OleDbCommand
        sqlcommand = New OleDbCommand(sql, frmMain.connection)
        Dim datareader As OleDbDataReader = sqlcommand.ExecuteReader()




        Try
            While datareader.Read()

                Dim LI As New ListViewItem
                LI.Text = datareader.Item(0)
                LI.SubItems.Add(getSubjectName(datareader.Item(2)))
                LI.SubItems.Add(datareader.Item(3))
                LI.SubItems.Add(datareader.Item(4))
                ListView1.Items.Add(LI)

            End While
            'End Try

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Function getSubjectName(ByVal SID As Integer) As String
        On Error GoTo erh
        Dim sql As String = "SELECT * FROM tblSubject WHERE subID=" + SID.ToString
        Dim sqlcommand As OleDbCommand
        sqlcommand = New OleDbCommand(sql, frmMain.connection)
        Dim datareader As OleDbDataReader = sqlcommand.ExecuteReader()
        While datareader.Read()
            Return datareader.Item(1)
            Exit Function
        End While
        Return "Unknown"
        'End Try
erh:
        MsgBox(ErrorToString)
        Return "Unknown"
    End Function
End Class