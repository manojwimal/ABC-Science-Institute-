Imports System.Data.OleDb

Public Class frmCredentials
    Dim Userlist As New ListBox
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox3.Text = TextBox4.Text Then
            If TextBox3.Text.Length > 4 Then
                If Userlist.Items.Contains(TextBox1.Text.ToLower) = True Then
                    If TextBox2.Text = getOldPassword(TextBox1.Text.ToLower) Then
                        ApplyNewPassword()
                    Else
                        MsgBox("The Old Password is incorrect", MsgBoxStyle.Critical)
                    End If
                Else
                    MsgBox("User not found", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Your new passwords must contain more than 4 letters", MsgBoxStyle.Critical)
            End If
          
        Else
            MsgBox("Your new passwords do not match", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub frmCredentials_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String = "SELECT * FROM tblCredential"
        Dim sqlcommand As OleDbCommand
        sqlcommand = New OleDbCommand(sql, frmMain.connection)
        Dim datareader As OleDbDataReader = sqlcommand.ExecuteReader()
        Try
            While datareader.Read()
                Userlist.Items.Add(datareader.Item(0))
            End While
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical)
           

        End Try
    End Sub

    Private Function getOldPassword(ByVal UN As String) As String
        On Error GoTo erh
        Dim sql As String = "SELECT crdPassword FROM tblCredential WHERE crdUsername='" + UN + "'"
        Dim sqlcommand As OleDbCommand
        sqlcommand = New OleDbCommand(sql, frmMain.connection)
        Dim datareader As OleDbDataReader = sqlcommand.ExecuteReader()
        While datareader.Read()
            Return (datareader.Item(0))
            Exit Function
        End While
        Return "0"
        Exit Function
erh:
        MsgBox(ErrorToString, MsgBoxStyle.Critical)
        Return "0"

    End Function


    Private Sub ApplyNewPassword()
        Dim sqlc As New OleDbCommand("UPDATE tblCredential SET crdPassword='" + TextBox3.Text + "' WHERE crdUsername='" + TextBox1.Text.ToLower + "'", frmMain.connection)
        Dim I As Integer
        Try
            I = sqlc.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation)
        End Try
        MsgBox("Password updated successfully", MsgBoxStyle.Information)
        Me.Close()
    End Sub
End Class