<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.SubjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddSubjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewSubjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddGradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewGradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ManageUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SubjectsToolStripMenuItem, Me.GradesToolStripMenuItem, Me.ReportToolStripMenuItem, Me.SearchToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(848, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SubjectsToolStripMenuItem
        '
        Me.SubjectsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddSubjectToolStripMenuItem, Me.ViewSubjectsToolStripMenuItem})
        Me.SubjectsToolStripMenuItem.Name = "SubjectsToolStripMenuItem"
        Me.SubjectsToolStripMenuItem.Size = New System.Drawing.Size(88, 23)
        Me.SubjectsToolStripMenuItem.Text = "Curriculum"
        '
        'AddSubjectToolStripMenuItem
        '
        Me.AddSubjectToolStripMenuItem.Name = "AddSubjectToolStripMenuItem"
        Me.AddSubjectToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.AddSubjectToolStripMenuItem.Text = "Update Curriculum"
        '
        'ViewSubjectsToolStripMenuItem
        '
        Me.ViewSubjectsToolStripMenuItem.Name = "ViewSubjectsToolStripMenuItem"
        Me.ViewSubjectsToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.ViewSubjectsToolStripMenuItem.Text = "View Curriculum"
        '
        'GradesToolStripMenuItem
        '
        Me.GradesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddGradesToolStripMenuItem, Me.ViewGradesToolStripMenuItem})
        Me.GradesToolStripMenuItem.Name = "GradesToolStripMenuItem"
        Me.GradesToolStripMenuItem.Size = New System.Drawing.Size(64, 23)
        Me.GradesToolStripMenuItem.Text = "Grades"
        '
        'AddGradesToolStripMenuItem
        '
        Me.AddGradesToolStripMenuItem.Name = "AddGradesToolStripMenuItem"
        Me.AddGradesToolStripMenuItem.Size = New System.Drawing.Size(154, 24)
        Me.AddGradesToolStripMenuItem.Text = "Add Grade"
        '
        'ViewGradesToolStripMenuItem
        '
        Me.ViewGradesToolStripMenuItem.Name = "ViewGradesToolStripMenuItem"
        Me.ViewGradesToolStripMenuItem.Size = New System.Drawing.Size(154, 24)
        Me.ViewGradesToolStripMenuItem.Text = "View Grades"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(62, 23)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentsToolStripMenuItem})
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(61, 23)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'StudentsToolStripMenuItem
        '
        Me.StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem"
        Me.StudentsToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.StudentsToolStripMenuItem.Text = "Students"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Matura MT Script Capitals", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(0, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(848, 77)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Curriculum Evaluation System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.CurriculumEvaluationSystem.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 104)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(848, 379)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(166, 24)
        Me.StudentToolStripMenuItem.Text = "Students"
        Me.StudentToolStripMenuItem.Visible = False
        '
        'CourseToolStripMenuItem
        '
        Me.CourseToolStripMenuItem.Name = "CourseToolStripMenuItem"
        Me.CourseToolStripMenuItem.Size = New System.Drawing.Size(166, 24)
        Me.CourseToolStripMenuItem.Text = "Courses"
        Me.CourseToolStripMenuItem.Visible = False
        '
        'ManageUsersToolStripMenuItem
        '
        Me.ManageUsersToolStripMenuItem.Name = "ManageUsersToolStripMenuItem"
        Me.ManageUsersToolStripMenuItem.Size = New System.Drawing.Size(166, 24)
        Me.ManageUsersToolStripMenuItem.Text = "Manage Users"
        Me.ManageUsersToolStripMenuItem.Visible = False
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentToolStripMenuItem, Me.CourseToolStripMenuItem, Me.ManageUsersToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(41, 23)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 483)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Curriculum Evaluation System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GradesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddGradesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewGradesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubjectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddSubjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewSubjectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CourseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
