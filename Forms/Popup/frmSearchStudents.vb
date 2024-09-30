Public Class frmSearchStudents
 
    Private Sub frmSearchStudents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT `IdNo`, `Firstname`, `Lastname`, `MI`, `HomeAddress`, `Sex`,`Course` `YearLevel` FROM `tblstudent` s, `tblcourse` c WHERE s.`CourseId`=c.`CourseId`"
        reloadDtg(sql, dtgList)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        sql = " SELECT `IdNo`, `Firstname`, `Lastname`, `MI`, `HomeAddress`, `Sex`,`Course` `YearLevel` FROM `tblstudent` s, `tblcourse` c WHERE s.`CourseId`=c.`CourseId` AND Firstname LIKE '%" & TextBox1.Text & "%' AND Lastname LIKE '%" & TextBox1.Text & "%'"
        reloadDtg(sql, dtgList)
    End Sub

    Private Sub btnAddGrades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddGrades.Click
        Try
            Dim courseid As Integer = 0
            With frmViewCurriculum
                sql = "SELECT * FROM `tblstudent`  s , `tblcourse` c WHERE s.`CourseId`=c.`CourseId` AND IdNo=" & dtgList.CurrentRow.Cells(0).Value
                reloadtxt(sql)

                If dt.Rows.Count > 0 Then

                    courseid = dt.Rows(0).Item("CourseId")


                    .lblName.Text = dt.Rows(0).Item("Firstname") & " " & dt.Rows(0).Item("Lastname")
                    .lblCourse.Text = dt.Rows(0).Item("Course")
                    .lblYearLevel.Text = dt.Rows(0).Item("YearLevel")
                    .lblIdNo.Text = dt.Rows(0).Item("IdNo")
                    .lblSemester.Text = dt.Rows(0).Item("IdNo")


                    sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`, `PreRequisite`,Grades FROM `tblsubject` s, `tblgrades` g WHERE s.`SubjectId`=g.`SubjectId` " & _
                   " AND s.`SubjectId`=g.`SubjectId` " & _
                   " AND g.`CourseId`=" & courseid & _
                   " AND g.YearLevel='First' AND Semester= 'First' AND IdNo=" & dtgList.CurrentRow.Cells(0).Value
                    reloadDtgWithGrades(sql, .dtgFirstYearFirst)
                    .dtgFirstYearFirst.Columns(0).Visible = False



                    sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`, `PreRequisite`,Grades FROM `tblsubject` s, `tblgrades` g WHERE s.`SubjectId`=g.`SubjectId` " & _
                          " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='First' AND Semester= 'Second' " & _
                          " AND g.`CourseId`=" & courseid & _
                          " AND IdNo=" & dtgList.CurrentRow.Cells(0).Value
                    reloadDtgWithGrades(sql, .dtgFirstYearSecond)
                    .dtgFirstYearSecond.Columns(0).Visible = False


                    sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`, `PreRequisite`,Grades FROM `tblsubject` s, `tblgrades` g WHERE s.`SubjectId`=g.`SubjectId` " & _
                         " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Second' AND Semester= 'First' " & _
                         " AND g.`CourseId`=" & courseid & _
                         " AND IdNo=" & dtgList.CurrentRow.Cells(0).Value
                    reloadDtgWithGrades(sql, .dtgSecondYearFirst)
                    .dtgSecondYearFirst.Columns(0).Visible = False

                    sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`, `PreRequisite`,Grades FROM `tblsubject` s, `tblgrades` g WHERE s.`SubjectId`=g.`SubjectId` " & _
                         " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Second' AND Semester= 'Second' " & _
                         " AND g.`CourseId`=" & courseid & _
                         " AND IdNo=" & dtgList.CurrentRow.Cells(0).Value
                    reloadDtgWithGrades(sql, .dtgSecondYearSecond)
                    .dtgSecondYearSecond.Columns(0).Visible = False


                    sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`, `PreRequisite`,Grades FROM `tblsubject` s, `tblgrades` g WHERE s.`SubjectId`=g.`SubjectId` " & _
                        " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Third' AND Semester= 'First' " & _
                        " AND g.`CourseId`=" & courseid & _
                        " AND IdNo=" & dtgList.CurrentRow.Cells(0).Value
                    reloadDtgWithGrades(sql, .dtgThirdYearFirst)
                    .dtgThirdYearFirst.Columns(0).Visible = False

                    sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`, `PreRequisite`,Grades FROM `tblsubject` s, `tblgrades` g WHERE s.`SubjectId`=g.`SubjectId` " & _
                         " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Third' AND Semester= 'Second' " & _
                         " AND g.`CourseId`=" & courseid & _
                         " AND IdNo=" & dtgList.CurrentRow.Cells(0).Value
                    reloadDtgWithGrades(sql, .dtgThirdYearSecond)
                    .dtgThirdYearSecond.Columns(0).Visible = False

                    sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`, `PreRequisite`,Grades FROM `tblsubject` s, `tblgrades` g WHERE s.`SubjectId`=g.`SubjectId` " & _
                       " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Fourth' AND Semester= 'First' " & _
                       " AND g.`CourseId`=" & courseid & _
                       " AND IdNo=" & dtgList.CurrentRow.Cells(0).Value
                    reloadDtgWithGrades(sql, .dtgFourthYearFirst)
                    .dtgFourthYearFirst.Columns(0).Visible = False

                    sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`, `PreRequisite`,Grades FROM `tblsubject` s, `tblgrades` g WHERE s.`SubjectId`=g.`SubjectId` " & _
                         " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Fourth' AND Semester= 'Second' " & _
                         " AND g.`CourseId`=" & courseid & _
                         " AND IdNo=" & dtgList.CurrentRow.Cells(0).Value
                    reloadDtgWithGrades(sql, .dtgFourthYearSecond)
                    .dtgFourthYearSecond.Columns(0).Visible = False

                    .Show()
                    .Focus()

                    .lblcoursId.Text = courseid

                    Me.Close()
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class