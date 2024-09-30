Public Class Form1

    Private Sub StudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentToolStripMenuItem.Click
        With frmStudent
            .ShowDialog() 
        End With
    End Sub

    Private Sub CourseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseToolStripMenuItem.Click
        frmCourse.ShowDialog()
    End Sub

    Private Sub AddSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSubjectToolStripMenuItem.Click
        frmSubjects.ShowDialog()
    End Sub

    Private Sub ViewSubjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSubjectsToolStripMenuItem.Click
        frmListSubject.Show()
        frmListSubject.Focus()
        frmListSubject.Size = New Size(947, 446)
        frmListSubject.StartPosition = FormStartPosition.CenterScreen
        'frmListSubject.ShowDialog()
    End Sub

   

    Private Sub ViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub CurriculumToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub AddGradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddGradesToolStripMenuItem.Click
        frmSearchGrade.Show()
        frmSearchGrade.Focus() 
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'InvisibleMenu()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'If LoginToolStripMenuItem.Text = "Login" Then
            '    LoginForm1.Show()
            '    LoginForm1.Focus()
            'Else
            '    LoginToolStripMenuItem.Text = "Login"
            '    InvisibleMenu()
            'End If
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub InvisibleMenu()
        StudentToolStripMenuItem.Visible = False
        CourseToolStripMenuItem.Visible = False
        ManageUsersToolStripMenuItem.Visible = False
        'CurriculumToolStripMenuItem.Visible = False
        SubjectsToolStripMenuItem.Visible = False
        GradesToolStripMenuItem.Visible = False
        ReportToolStripMenuItem.Visible = False
    End Sub
    Private Sub VisibleMenu()
        StudentToolStripMenuItem.Visible = True
        CourseToolStripMenuItem.Visible = True
        ManageUsersToolStripMenuItem.Visible = True
        'CurriculumToolStripMenuItem.Visible = True
        SubjectsToolStripMenuItem.Visible = True
        GradesToolStripMenuItem.Visible = True
        ReportToolStripMenuItem.Visible = True
    End Sub

    Private Sub ManageUsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageUsersToolStripMenuItem.Click
        With frmUser
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportToolStripMenuItem.Click
        With frmReport
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        LoginForm1.Show()
        LoginForm1.UsernameTextBox.Clear()
        LoginForm1.PasswordTextBox.Clear()
        LoginForm1.UsernameTextBox.Focus()
    End Sub

    Private Sub StudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsToolStripMenuItem.Click
        frmSearchStudents.Show()
        frmSearchStudents.Focus()

    End Sub
End Class
