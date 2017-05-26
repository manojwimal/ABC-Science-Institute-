Imports System.Data.OleDb

Public Class frmMakePayment
    Dim S1 As Double
    Dim S2 As Double
    Dim S3 As Double
    Dim S4 As Double

    Private Sub PayCHemi()
        Dim sql As String = "SELECT COUNT(*) FROM tblPayment WHERE payStdID='" + TextBox1.Text + "' AND paySubID='1' AND payDate='" + NumericUpDown1.Value.ToString & "/" & NumericUpDown2.Value.ToString + "'"
        'MsgBox(sql.ToString)
        Dim sqlcommand As OleDbCommand
        sqlcommand = New OleDbCommand(sql, frmMain.connection)
        Dim datareader As OleDbDataReader = sqlcommand.ExecuteReader()
        Try
            While datareader.Read()
                If Val(datareader.Item(0)) > 0 Then
                    MsgBox("This Student has already made a payment for Chemistry " + NumericUpDown1.Value.ToString & "/" & NumericUpDown2.Value.ToString + ". Payment for Chemistry has being skipped.", MsgBoxStyle.Exclamation)
                    CheckBox1.Checked = False
                Else
                    Dim sqlc As New OleDbCommand("INSERT INTO tblPayment (payStdID,paySubID,payDate,payAmount) VALUES('" + TextBox1.Text + "','1','" + NumericUpDown1.Value.ToString & "/" & NumericUpDown2.Value.ToString + "','" + S1.ToString + "')", frmMain.connection)
                    Dim I As Integer
                    Try
                        I = sqlc.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString, MsgBoxStyle.Exclamation)
                    End Try
                End If
            End While
            'End Try

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation)

        End Try
        Exit Sub
    End Sub

    Private Sub PayPhy()
        Dim sql As String = "SELECT COUNT(*) FROM tblPayment WHERE payStdID='" + TextBox1.Text + "' AND paySubID='2' AND payDate='" + NumericUpDown1.Value.ToString & "/" & NumericUpDown2.Value.ToString + "'"
        'MsgBox(sql.ToString)
        Dim sqlcommand As OleDbCommand
        sqlcommand = New OleDbCommand(sql, frmMain.connection)
        Dim datareader As OleDbDataReader = sqlcommand.ExecuteReader()
        Try
            While datareader.Read()
                If Val(datareader.Item(0)) > 0 Then
                    MsgBox("This Student has already made a payment for Physics " + NumericUpDown1.Value.ToString & "/" & NumericUpDown2.Value.ToString + ". Payment for Physics has being skipped.", MsgBoxStyle.Exclamation)
                    CheckBox2.Checked = False
                Else
                    Dim sqlc As New OleDbCommand("INSERT INTO tblPayment (payStdID,paySubID,payDate,payAmount) VALUES('" + TextBox1.Text + "','2','" + NumericUpDown1.Value.ToString & "/" & NumericUpDown2.Value.ToString + "','" + S2.ToString + "')", frmMain.connection)
                    Dim I As Integer
                    Try
                        I = sqlc.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString, MsgBoxStyle.Exclamation)
                    End Try
                End If
            End While
            'End Try

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation)

        End Try
        Exit Sub
    End Sub

    Private Sub PayMaths()
        Dim sql As String = "SELECT COUNT(*) FROM tblPayment WHERE payStdID='" + TextBox1.Text + "' AND paySubID='3' AND payDate='" + NumericUpDown1.Value.ToString & "/" & NumericUpDown2.Value.ToString + "'"
        'MsgBox(sql.ToString)
        Dim sqlcommand As OleDbCommand
        sqlcommand = New OleDbCommand(sql, frmMain.connection)
        Dim datareader As OleDbDataReader = sqlcommand.ExecuteReader()
        Try
            While datareader.Read()
                If Val(datareader.Item(0)) > 0 Then
                    MsgBox("This Student has already made a payment for Combined Mathematics " + NumericUpDown1.Value.ToString & "/" & NumericUpDown2.Value.ToString + ". Payment for Combined Mathematics has being skipped.", MsgBoxStyle.Exclamation)
                    CheckBox3.Checked = False
                Else
                    Dim sqlc As New OleDbCommand("INSERT INTO tblPayment (payStdID,paySubID,payDate,payAmount) VALUES('" + TextBox1.Text + "','3','" + NumericUpDown1.Value.ToString & "/" & NumericUpDown2.Value.ToString + "','" + S3.ToString + "')", frmMain.connection)
                    Dim I As Integer
                    Try
                        I = sqlc.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString, MsgBoxStyle.Exclamation)
                    End Try
                End If
            End While
            'End Try

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation)

        End Try
        Exit Sub
    End Sub

    Private Sub PayBio()
        Dim sql As String = "SELECT COUNT(*) FROM tblPayment WHERE payStdID='" + TextBox1.Text + "' AND paySubID='4' AND payDate='" + NumericUpDown1.Value.ToString & "/" & NumericUpDown2.Value.ToString + "'"
        'MsgBox(sql.ToString)
        Dim sqlcommand As OleDbCommand
        sqlcommand = New OleDbCommand(sql, frmMain.connection)
        Dim datareader As OleDbDataReader = sqlcommand.ExecuteReader()
        Try
            While datareader.Read()
                If Val(datareader.Item(0)) > 0 Then
                    MsgBox("This Student has already made a payment for Biology " + NumericUpDown1.Value.ToString & "/" & NumericUpDown2.Value.ToString + ". Payment for Biology has being skipped.", MsgBoxStyle.Exclamation)
                    CheckBox4.Checked = False
                Else
                    Dim sqlc As New OleDbCommand("INSERT INTO tblPayment (payStdID,paySubID,payDate,payAmount) VALUES('" + TextBox1.Text + "','4','" + NumericUpDown1.Value.ToString & "/" & NumericUpDown2.Value.ToString + "','" + S4.ToString + "')", frmMain.connection)
                    Dim I As Integer
                    Try
                        I = sqlc.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString, MsgBoxStyle.Exclamation)
                    End Try
                End If
            End While
            'End Try

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation)

        End Try
        Exit Sub
    End Sub

    Private Function isStudentThere()
        On Error GoTo erh
        Dim sql As String = "SELECT COUNT(*) FROM tblStudent WHERE stdID=" + Val(TextBox1.Text).ToString
        'MsgBox(sql.ToString)
        Dim sqlcommand As OleDbCommand
        sqlcommand = New OleDbCommand(sql, frmMain.connection)
        Dim datareader As OleDbDataReader = sqlcommand.ExecuteReader()
        While datareader.Read()
            Return datareader.Item(0)
            Exit Function
        End While
        Return 0
        Exit Function
erh:
        Return 0
        Exit Function
    End Function

    Private Function getStudentName()
        On Error GoTo erh
        Dim sql As String = "SELECT stdFirstName,stdLastName,stdPhoneNo FROM tblStudent WHERE stdID=" + Val(TextBox1.Text).ToString
        'MsgBox(sql.ToString)
        Dim sqlcommand As OleDbCommand
        sqlcommand = New OleDbCommand(sql, frmMain.connection)
        Dim datareader As OleDbDataReader = sqlcommand.ExecuteReader()
        While datareader.Read()
            Return datareader.Item(0) + " " + datareader.Item(1) + " owner of mobile number " + datareader.Item(2)
            Exit Function
        End While
        Return 0
        Exit Function
erh:
        Return 0
        Exit Function
    End Function

    Private Sub frmMakePayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String = "SELECT * FROM tblSubject"
        Dim sqlcommand As OleDbCommand
        'MsgBox(sql)
        sqlcommand = New OleDbCommand(sql, frmMain.connection)
        Dim datareader As OleDbDataReader = sqlcommand.ExecuteReader()

        Try
            While datareader.Read()
                If datareader.Item(0).ToString = "1" Then
                    S1 = Val(datareader.Item(2).ToString)
                ElseIf datareader.Item(0).ToString = "2" Then
                    S2 = Val(datareader.Item(2).ToString)
                ElseIf datareader.Item(0).ToString = "3" Then
                    S3 = Val(datareader.Item(2).ToString)
                ElseIf datareader.Item(0).ToString = "4" Then
                    S4 = Val(datareader.Item(2).ToString)

                End If
                'MsgBox(datareader.Item(0).ToString + " " + datareader.Item(1).ToString)

            End While
            'End Try

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation)

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim NN As Integer = isStudentThere()
        If NN = 0 Then
            MsgBox("Unbale to locate a student with the student ID of " & TextBox1.Text, MsgBoxStyle.Critical)
            Exit Sub
        Else
            Dim SN As String
            SN = getStudentName()
            If SN.ToString <> "0" Then
                If MsgBox("Procees this payment for " & SN, MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Sub
                End If
            Else
                MsgBox("Unbale to locate a student with the student ID of " & TextBox1.Text, MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If


        If CheckBox1.Checked = True Then
            PayCHemi()
        End If
        If CheckBox2.Checked = True Then
            PayPhy()
        End If
        If CheckBox3.Checked = True Then
            PayMaths()
        End If
        If CheckBox4.Checked = True Then
            PayBio()
        End If
        MsgBox("Payment processed successfully", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Dim total As Double
        If CheckBox1.Checked = True Then
            total = total + S1
        End If
        If CheckBox2.Checked = True Then
            total = total + S2
        End If
        If CheckBox3.Checked = True Then
            total = total + S3
        End If
        If CheckBox4.Checked = True Then
            total = total + S4
        End If
        Label4.Text = String.Format("{0:n2}", total)
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Dim total As Double
        If CheckBox1.Checked = True Then
            total = total + S1
        End If
        If CheckBox2.Checked = True Then
            total = total + S2
        End If
        If CheckBox3.Checked = True Then
            total = total + S3
        End If
        If CheckBox4.Checked = True Then
            total = total + S4
        End If
        Label4.Text = String.Format("{0:n2}", total)
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        Dim total As Double
        If CheckBox1.Checked = True Then
            total = total + S1
        End If
        If CheckBox2.Checked = True Then
            total = total + S2
        End If
        If CheckBox3.Checked = True Then
            total = total + S3
        End If
        If CheckBox4.Checked = True Then
            total = total + S4
        End If
        Label4.Text = String.Format("{0:n2}", total)
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        Dim total As Double
        If CheckBox1.Checked = True Then
            total = total + S1
        End If
        If CheckBox2.Checked = True Then
            total = total + S2
        End If
        If CheckBox3.Checked = True Then
            total = total + S3
        End If
        If CheckBox4.Checked = True Then
            total = total + S4
        End If
        Label4.Text = String.Format("{0:n2}", total)
    End Sub
End Class