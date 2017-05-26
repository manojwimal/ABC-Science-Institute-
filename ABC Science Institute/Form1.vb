Imports System.Data.OleDb

Public Class frmLogin
    Dim connectionstring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + CurDir() + "\ScienceIns.accdb"
    Dim connection As OleDbConnection
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection = New OleDbConnection(connectionstring)
        connection.Open()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim logged As Boolean = False
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            Dim sql As String = "SELECT * FROM tblCredential WHERE crdUsername='" + TextBox1.Text + "'"
            Dim sqlcommand As OleDbCommand
            sqlcommand = New OleDbCommand(sql, connection)
            Dim datareader As OleDbDataReader = sqlcommand.ExecuteReader()
            Try
                While datareader.Read()
                    If datareader.Item(0).ToString.ToLower = (TextBox1.Text.ToLower) Then

                        If datareader.Item(1).ToString = TextBox2.Text Then
                            logged = True
                            connection.Close()
                            frmMain.Show()
                            If TextBox1.Text.ToLower <> "admin" Then
                                With frmMain
                                    .UpdateStudentToolStripMenuItem.Enabled = False
                                    .SubjectFeesToolStripMenuItem.Enabled = False
                                    .IncomeByMonthToolStripMenuItem.Enabled = False
                                End With

                            End If
                            Me.Close()
                        End If
                    End If


                End While
            Catch ex As Exception
                If logged = False Then
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End If

            Finally
                If logged = False Then
                    MsgBox("Username and Password do not match", MsgBoxStyle.Exclamation)
                End If

            End Try

        Else
            MsgBox("Both fields must be filled", MsgBoxStyle.Exclamation)
        End If


    End Sub
End Class
