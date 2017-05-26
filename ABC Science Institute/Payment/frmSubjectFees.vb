Imports System.Data.OleDb

Public Class frmSubjectFees
    Private Sub sqlCode(ByVal cmd As String)
        Dim sqlc As New OleDbCommand(cmd, frmMain.connection)
        Dim I As Integer
        Try
            I = sqlc.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sqlCode("UPDATE tblSubject SET subFee='" + TextBox1.Text + "' WHERE subID=1")
        sqlCode("UPDATE tblSubject SET subFee='" + TextBox2.Text + "' WHERE subID=2")
        sqlCode("UPDATE tblSubject SET subFee='" + TextBox3.Text + "' WHERE subID=3")
        sqlCode("UPDATE tblSubject SET subFee='" + TextBox4.Text + "' WHERE subID=4")
        MsgBox("Subject Fees updated successfully", MsgBoxStyle.Information)
        Me.Close()

    End Sub

    Private Sub frmSubjectFees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String = "SELECT * FROM tblSubject"
        Dim sqlcommand As OleDbCommand
        'MsgBox(sql)
        sqlcommand = New OleDbCommand(sql, frmMain.connection)
        Dim datareader As OleDbDataReader = sqlcommand.ExecuteReader()




        Try
            While datareader.Read()
                Dim ID As Integer = Val(datareader.Item(0))
                Select Case ID
                    Case 1
                        TextBox1.Text = Val(datareader.Item(2)).ToString
                    Case 2
                        TextBox2.Text = Val(datareader.Item(2)).ToString
                    Case 3
                        TextBox3.Text = Val(datareader.Item(2)).ToString
                    Case 4
                        TextBox4.Text = Val(datareader.Item(2)).ToString
                End Select


            End While
            'End Try

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)

        End Try
    End Sub
End Class