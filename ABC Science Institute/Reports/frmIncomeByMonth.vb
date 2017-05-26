Imports System.Data.OleDb

Public Class frmIncomeByMonth

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String = "SELECT SUM(payAmount) FROM tblPayment WHERE payDate='" + NumericUpDown1.Value.ToString & "/" & NumericUpDown2.Value.ToString + "'"
        Dim sqlcommand As OleDbCommand
        'MsgBox(sql)
        sqlcommand = New OleDbCommand(sql, frmMain.connection)
        Dim datareader As OleDbDataReader = sqlcommand.ExecuteReader()

        Try
            While datareader.Read()
                Label4.Text = String.Format("{0:n2}", datareader.Item(0))

            End While
            'End Try

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation)

        End Try
    End Sub
End Class