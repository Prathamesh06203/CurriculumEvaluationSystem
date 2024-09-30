Public Class frmListSubject

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
     
    End Sub

    Private Sub frmListSubject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT SubjectId, `Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,Course,`YearLevel`, `Semester`,   `PreRequisite` FROM `tblsubject` s,tblcourse c WHERE s.CourseId=c.CourseId"
        reloadDtg(sql, dtgList)
        dtgList.Columns(0).Visible = False

        cbo_fill(cboCourse, "Course", "CourseId", "tblcourse")
        cboCourse.Text = "Select"
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
 
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
 
    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        Try
            If cboCourse.Text = "Select" And cboSemester.Text = "Select" And cboYearLevel.Text = "Select" Then
                sql = "SELECT SubjectId, `Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,Course,`YearLevel`, `Semester`, `AcademicYear`, `PreRequisite` FROM `tblsubject` s,tblcourse c WHERE s.CourseId=c.CourseId"
                reloadDtg(sql, dtgList)
             Else
                sql = "SELECT SubjectId, `Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,Course,`YearLevel`, `Semester`, `AcademicYear`, `PreRequisite` FROM `tblsubject` s,tblcourse c " & _
                    " WHERE s.CourseId=c.CourseId AND c.CourseId = '" & cboCourse.SelectedValue & "' AND YearLevel = '" & cboYearLevel.Text & _
                    "' AND Semester = '" & cboSemester.Text & "'"
                reloadDtg(sql, dtgList)

            End If
            dtgList.Columns(0).Visible = False

        Catch ex As Exception

        End Try
    End Sub
End Class