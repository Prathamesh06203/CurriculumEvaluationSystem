﻿Public Class frmSearchGrade

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click

        Try
            If TextBox1.Text = "" Then
                MsgBox("Pls enter id number.", MsgBoxStyle.Exclamation)
                Return
            End If
            Dim courseid As Integer = 0
            With frmViewCurriculum
                sql = "SELECT * FROM `tblstudent`  s , `tblcourse` c WHERE s.`CourseId`=c.`CourseId` AND IdNo=" & TextBox1.Text
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
                   " AND g.YearLevel='First' AND Semester= 'First' AND IdNo=" & TextBox1.Text
                    reloadDtgWithGrades(sql, .dtgFirstYearFirst)
                    .dtgFirstYearFirst.Columns(0).Visible = False



                    sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`, `PreRequisite`,Grades FROM `tblsubject` s, `tblgrades` g WHERE s.`SubjectId`=g.`SubjectId` " & _
                          " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='First' AND Semester= 'Second' " & _
                          " AND g.`CourseId`=" & courseid & _
                          " AND IdNo=" & TextBox1.Text
                    reloadDtgWithGrades(sql, .dtgFirstYearSecond)
                    .dtgFirstYearSecond.Columns(0).Visible = False


                    sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`, `PreRequisite`,Grades FROM `tblsubject` s, `tblgrades` g WHERE s.`SubjectId`=g.`SubjectId` " & _
                         " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Second' AND Semester= 'First' " & _
                         " AND g.`CourseId`=" & courseid & _
                         " AND IdNo=" & TextBox1.Text
                    reloadDtgWithGrades(sql, .dtgSecondYearFirst)
                    .dtgSecondYearFirst.Columns(0).Visible = False

                    sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`, `PreRequisite`,Grades FROM `tblsubject` s, `tblgrades` g WHERE s.`SubjectId`=g.`SubjectId` " & _
                         " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Second' AND Semester= 'Second' " & _
                         " AND g.`CourseId`=" & courseid & _
                         " AND IdNo=" & TextBox1.Text
                    reloadDtgWithGrades(sql, .dtgSecondYearSecond)
                    .dtgSecondYearSecond.Columns(0).Visible = False


                    sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`, `PreRequisite`,Grades FROM `tblsubject` s, `tblgrades` g WHERE s.`SubjectId`=g.`SubjectId` " & _
                        " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Third' AND Semester= 'First' " & _
                        " AND g.`CourseId`=" & courseid & _
                        " AND IdNo=" & TextBox1.Text
                    reloadDtgWithGrades(sql, .dtgThirdYearFirst)
                    .dtgThirdYearFirst.Columns(0).Visible = False

                    sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`, `PreRequisite`,Grades FROM `tblsubject` s, `tblgrades` g WHERE s.`SubjectId`=g.`SubjectId` " & _
                         " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Third' AND Semester= 'Second' " & _
                         " AND g.`CourseId`=" & courseid & _
                         " AND IdNo=" & TextBox1.Text
                    reloadDtgWithGrades(sql, .dtgThirdYearSecond)
                    .dtgThirdYearSecond.Columns(0).Visible = False

                    sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`, `PreRequisite`,Grades FROM `tblsubject` s, `tblgrades` g WHERE s.`SubjectId`=g.`SubjectId` " & _
                       " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Fourth' AND Semester= 'First' " & _
                       " AND g.`CourseId`=" & courseid & _
                       " AND IdNo=" & TextBox1.Text
                    reloadDtgWithGrades(sql, .dtgFourthYearFirst)
                    .dtgFourthYearFirst.Columns(0).Visible = False

                    sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`, `PreRequisite`,Grades FROM `tblsubject` s, `tblgrades` g WHERE s.`SubjectId`=g.`SubjectId` " & _
                         " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Fourth' AND Semester= 'Second' " & _
                         " AND g.`CourseId`=" & courseid & _
                         " AND IdNo=" & TextBox1.Text
                    reloadDtgWithGrades(sql, .dtgFourthYearSecond)
                    .dtgFourthYearSecond.Columns(0).Visible = False

                    .Show()
                    .Focus()

                    .lblcoursId.Text = courseid


                    Me.Close()
                Else
                    MsgBox("Id number is not registered.", MsgBoxStyle.Exclamation)
                End If

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
     


    End Sub

    Private Sub frmSearchGrade_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
     
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class