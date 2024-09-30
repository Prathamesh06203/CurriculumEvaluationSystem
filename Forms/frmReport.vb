Public Class frmReport
 
  
    Private Sub btnListStudents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListStudents.Click
        sql = "SELECT  `IdNo`, `Firstname`, `Lastname`, `MI`, `HomeAddress`, `Sex`,Course,`YearLevel` FROM `tblstudent` s, tblcourse c WHERE s.`CourseId`=c.`CourseId`"
        reports(sql, "ListStudents", CrystalReportViewer1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        sql = "SELECT *  FROM tblcourse c, `tblsubject` s, `tblgrades` g, tblstudent st WHERE c.CourseId=s.CourseId AND s.`SubjectId`=g.`SubjectId`  AND st.`IdNo`=g.`IdNo` AND  st.`IdNo`=" & TextBox1.Text & " ORDER BY GradesId ASC  "
        reports(sql, "EvaluationShit", CrystalReportViewer1)
    End Sub
End Class