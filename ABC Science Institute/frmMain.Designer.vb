<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MakePaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubjectFeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncomeByMonthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WelcomeScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicationToolStripMenuItem, Me.StudentsToolStripMenuItem, Me.PaymentsToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1193, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ApplicationToolStripMenuItem
        '
        Me.ApplicationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WelcomeScreenToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.ApplicationToolStripMenuItem.Image = Global.ABC_Science_Institute.My.Resources.Resources.ico_alpha_Categories_24x24
        Me.ApplicationToolStripMenuItem.Name = "ApplicationToolStripMenuItem"
        Me.ApplicationToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.ApplicationToolStripMenuItem.Text = "Application"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'StudentsToolStripMenuItem
        '
        Me.StudentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStudentToolStripMenuItem, Me.StudentDetailsToolStripMenuItem, Me.UpdateStudentToolStripMenuItem})
        Me.StudentsToolStripMenuItem.Image = Global.ABC_Science_Institute.My.Resources.Resources.ico_alpha_startupmanager_il_0_16x16
        Me.StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem"
        Me.StudentsToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.StudentsToolStripMenuItem.Text = "Students"
        '
        'AddStudentToolStripMenuItem
        '
        Me.AddStudentToolStripMenuItem.Name = "AddStudentToolStripMenuItem"
        Me.AddStudentToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AddStudentToolStripMenuItem.Text = "Add Students"
        '
        'StudentDetailsToolStripMenuItem
        '
        Me.StudentDetailsToolStripMenuItem.Name = "StudentDetailsToolStripMenuItem"
        Me.StudentDetailsToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.StudentDetailsToolStripMenuItem.Text = "Student Details"
        '
        'UpdateStudentToolStripMenuItem
        '
        Me.UpdateStudentToolStripMenuItem.Name = "UpdateStudentToolStripMenuItem"
        Me.UpdateStudentToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.UpdateStudentToolStripMenuItem.Text = "Update Student"
        '
        'PaymentsToolStripMenuItem
        '
        Me.PaymentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MakePaymentToolStripMenuItem, Me.SubjectFeesToolStripMenuItem})
        Me.PaymentsToolStripMenuItem.Image = Global.ABC_Science_Institute.My.Resources.Resources.ico_alpha_specialfolders_il14_16x16
        Me.PaymentsToolStripMenuItem.Name = "PaymentsToolStripMenuItem"
        Me.PaymentsToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.PaymentsToolStripMenuItem.Text = "Payments"
        '
        'MakePaymentToolStripMenuItem
        '
        Me.MakePaymentToolStripMenuItem.Name = "MakePaymentToolStripMenuItem"
        Me.MakePaymentToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.MakePaymentToolStripMenuItem.Text = "Make Payment"
        '
        'SubjectFeesToolStripMenuItem
        '
        Me.SubjectFeesToolStripMenuItem.Name = "SubjectFeesToolStripMenuItem"
        Me.SubjectFeesToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SubjectFeesToolStripMenuItem.Text = "Subject Fees"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IncomeByMonthToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Image = Global.ABC_Science_Institute.My.Resources.Resources.tfi_rating_optional
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'IncomeByMonthToolStripMenuItem
        '
        Me.IncomeByMonthToolStripMenuItem.Name = "IncomeByMonthToolStripMenuItem"
        Me.IncomeByMonthToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.IncomeByMonthToolStripMenuItem.Text = "Income by Month"
        '
        'WelcomeScreenToolStripMenuItem
        '
        Me.WelcomeScreenToolStripMenuItem.Name = "WelcomeScreenToolStripMenuItem"
        Me.WelcomeScreenToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.WelcomeScreenToolStripMenuItem.Text = "Welcome Screen"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(165, 6)
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 654)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABC Science Institute"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MakePaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubjectFeesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncomeByMonthToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WelcomeScreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
