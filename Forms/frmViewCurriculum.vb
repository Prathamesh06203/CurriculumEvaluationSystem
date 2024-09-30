Public Class frmViewCurriculum
 
    Private Sub frmViewCurriculum_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BringToFront()
        'dtgFirstYearFirst.EditMode = DataGridViewEditMode.EditProgrammatically
        dtgFirstYearFirst.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dtgFirstYearSecond.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dtgSecondYearFirst.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dtgSecondYearSecond.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dtgThirdYearFirst.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dtgThirdYearSecond.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dtgFourthYearFirst.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dtgFourthYearSecond.DefaultCellStyle.WrapMode = DataGridViewTriState.True
    
    End Sub
 Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub lblIdNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblIdNo.Click

    End Sub

    Private Sub lblIdNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblIdNo.TextChanged
  
    End Sub

    

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try


            Dim row As DataGridViewRow
            ''''''''''''''first year
            For Each row In dtgFirstYearFirst.Rows 
                sql = "SELECT * FROM `tblgrades` WHERE `GradesId`=" & row.Cells(0).FormattedValue 
                sqladd = ""
                sqledit = "UPDATE `tblgrades` SET `Grades`=" & row.Cells(6).FormattedValue & " WHERE `GradesId`=" & row.Cells(0).FormattedValue
                SaveUpdateNoMsq(sql, sqladd, sqledit)
            Next

            For Each row In dtgFirstYearSecond.Rows
                sql = "SELECT * FROM `tblgrades` WHERE `GradesId`=" & row.Cells(0).FormattedValue
                sqladd = ""
                sqledit = "UPDATE `tblgrades` SET `Grades`=" & row.Cells(6).FormattedValue & " WHERE `GradesId`=" & row.Cells(0).FormattedValue
                SaveUpdateNoMsq(sql, sqladd, sqledit)
            Next
            '''''''''''''''''Second Year
            For Each row In dtgSecondYearFirst.Rows
                sql = "SELECT * FROM `tblgrades` WHERE `GradesId`=" & row.Cells(0).FormattedValue
                sqladd = ""
                sqledit = "UPDATE `tblgrades` SET `Grades`=" & row.Cells(6).FormattedValue & " WHERE `GradesId`=" & row.Cells(0).FormattedValue
                SaveUpdateNoMsq(sql, sqladd, sqledit)
            Next

            For Each row In dtgSecondYearSecond.Rows
                sql = "SELECT * FROM `tblgrades` WHERE `GradesId`=" & row.Cells(0).FormattedValue
                sqladd = ""
                sqledit = "UPDATE `tblgrades` SET `Grades`=" & row.Cells(6).FormattedValue & " WHERE `GradesId`=" & row.Cells(0).FormattedValue
                SaveUpdateNoMsq(sql, sqladd, sqledit)
            Next
            '''''''''''''''''Third Year
            For Each row In dtgThirdYearFirst.Rows
                sql = "SELECT * FROM `tblgrades` WHERE `GradesId`=" & row.Cells(0).FormattedValue
                sqladd = ""
                sqledit = "UPDATE `tblgrades` SET `Grades`=" & row.Cells(6).FormattedValue & " WHERE `GradesId`=" & row.Cells(0).FormattedValue
                SaveUpdateNoMsq(sql, sqladd, sqledit)
            Next


            For Each row In dtgThirdYearSecond.Rows
                sql = "SELECT * FROM `tblgrades` WHERE `GradesId`=" & row.Cells(0).FormattedValue
                sqladd = ""
                sqledit = "UPDATE `tblgrades` SET `Grades`=" & row.Cells(6).FormattedValue & " WHERE `GradesId`=" & row.Cells(0).FormattedValue
                SaveUpdateNoMsq(sql, sqladd, sqledit)
            Next
            ''''''''''''''''''''Fourth Year
            For Each row In dtgFourthYearFirst.Rows
                sql = "SELECT * FROM `tblgrades` WHERE `GradesId`=" & row.Cells(0).FormattedValue
                sqladd = ""
                sqledit = "UPDATE `tblgrades` SET `Grades`=" & row.Cells(6).FormattedValue & " WHERE `GradesId`=" & row.Cells(0).FormattedValue
                SaveUpdateNoMsq(sql, sqladd, sqledit)
            Next

            For Each row In dtgFourthYearSecond.Rows
                sql = "SELECT * FROM `tblgrades` WHERE `GradesId`=" & row.Cells(0).FormattedValue
                sqladd = ""
                sqledit = "UPDATE `tblgrades` SET `Grades`=" & row.Cells(6).FormattedValue & " WHERE `GradesId`=" & row.Cells(0).FormattedValue
                SaveUpdateNoMsq(sql, sqladd, sqledit)
            Next
            ''''''''''''''end

            MsgBox("Grades have been updated.")
            LoadData()

        Catch ex As Exception

        End Try
    End Sub
    'Dim btn As New DataGridViewButtonColumn()
    '    dtg.Columns.Add(btn)
    '    btn.HeaderText = "Click Data"
    '    btn.Text = "Click Here"
    '    btn.Name = "btn"
    '    btn.UseColumnTextForButtonValue = True

    'End Sub
    'Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
    '    If e.ColumnIndex = 3 Then
    '        MsgBox(("Row : " + e.RowIndex.ToString & "  Col : ") + e.ColumnIndex.ToString)
    '    End If
    'End Sub
    Private Sub LoadData()
        Try
            sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`, `PreRequisite`,Grades FROM `tblsubject` s, `tblgrades` g WHERE s.`SubjectId`=g.`SubjectId` " & _
                            " AND s.`SubjectId`=g.`SubjectId` " & _
                            " AND g.`CourseId`=" & lblcoursId.Text & _
                            " AND g.YearLevel='First' AND Semester= 'First' AND IdNo=" & lblIdNo.Text
            reloadDtgWithGrades(sql, dtgFirstYearFirst)
            dtgFirstYearFirst.Columns(0).Visible = False



            sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`, `PreRequisite`,Grades FROM `tblsubject` s, `tblgrades` g WHERE s.`SubjectId`=g.`SubjectId` " & _
                  " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='First' AND Semester= 'Second' " & _
                  " AND g.`CourseId`=" & lblcoursId.Text & _
                  " AND IdNo=" & lblIdNo.Text
            reloadDtgWithGrades(sql, dtgFirstYearSecond)
            dtgFirstYearSecond.Columns(0).Visible = False


            sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`, `PreRequisite`,Grades FROM `tblsubject` s, `tblgrades` g WHERE s.`SubjectId`=g.`SubjectId` " & _
                       " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Second' AND Semester= 'First' " & _
                       " AND g.`CourseId`=" & lblcoursId.Text & _
                       " AND IdNo=" & lblIdNo.Text
            reloadDtgWithGrades(sql, dtgSecondYearFirst)
            dtgSecondYearFirst.Columns(0).Visible = False

            sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`, `PreRequisite`,Grades FROM `tblsubject` s, `tblgrades` g WHERE s.`SubjectId`=g.`SubjectId` " & _
                 " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Second' AND Semester= 'Second' " & _
                 " AND g.`CourseId`=" & lblcoursId.Text & _
                 " AND IdNo=" & lblIdNo.Text
            reloadDtgWithGrades(sql, dtgSecondYearSecond)
            dtgSecondYearSecond.Columns(0).Visible = False


            sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`, `PreRequisite`,Grades FROM `tblsubject` s, `tblgrades` g WHERE s.`SubjectId`=g.`SubjectId` " & _
                " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Second' AND Semester= 'First' " & _
                " AND g.`CourseId`=" & lblcoursId.Text & _
                " AND IdNo=" & lblIdNo.Text
            reloadDtgWithGrades(sql, dtgThirdYearFirst)
            dtgThirdYearFirst.Columns(0).Visible = False

            sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`, `PreRequisite`,Grades FROM `tblsubject` s, `tblgrades` g WHERE s.`SubjectId`=g.`SubjectId` " & _
                 " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Second' AND Semester= 'Second' " & _
                 " AND g.`CourseId`=" & lblcoursId.Text & _
                 " AND IdNo=" & lblIdNo.Text
            reloadDtgWithGrades(sql, dtgThirdYearSecond)
            dtgThirdYearSecond.Columns(0).Visible = False

            sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`, `PreRequisite`,Grades FROM `tblsubject` s, `tblgrades` g WHERE s.`SubjectId`=g.`SubjectId` " & _
               " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Second' AND Semester= 'First' " & _
               " AND g.`CourseId`=" & lblcoursId.Text & _
               " AND IdNo=" & lblIdNo.Text
            reloadDtgWithGrades(sql, dtgFourthYearFirst)
            dtgFourthYearFirst.Columns(0).Visible = False

            sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`, `PreRequisite`,Grades FROM `tblsubject` s, `tblgrades` g WHERE s.`SubjectId`=g.`SubjectId` " & _
                 " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Second' AND Semester= 'Second' " & _
                 " AND g.`CourseId`=" & lblcoursId.Text & _
                 " AND IdNo=" & lblIdNo.Text
            reloadDtgWithGrades(sql, dtgFourthYearSecond)
            dtgFourthYearSecond.Columns(0).Visible = False

        Catch ex As Exception

        End Try

    End Sub
    'Private Sub dtgFirstYearSecond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgFirstYearSecond.Click
    '    If dtgFirstYearSecond.CurrentRow.Cells(6).Selected Then
    '        dtgFirstYearSecond.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2

    '        dtgFirstYearSecond.CurrentRow.Cells(6).ReadOnly = False
    '    Else
    '        dtgFirstYearSecond.EditMode = DataGridViewEditMode.EditProgrammatically

    '        dtgFirstYearSecond.CurrentRow.Cells(6).ReadOnly = True
    '    End If
    'End Sub

    'Private Sub dtgSecondYearFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgSecondYearFirst.Click
    '    If dtgSecondYearFirst.CurrentRow.Cells(6).Selected Then
    '        dtgSecondYearFirst.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2

    '        dtgSecondYearFirst.CurrentRow.Cells(6).ReadOnly = False
    '    Else
    '        dtgSecondYearFirst.EditMode = DataGridViewEditMode.EditProgrammatically

    '        dtgSecondYearFirst.CurrentRow.Cells(6).ReadOnly = True
    '    End If
    'End Sub

    'Private Sub dtgSecondYearSecond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgSecondYearSecond.Click
    '    If dtgSecondYearSecond.CurrentRow.Cells(6).Selected Then
    '        dtgSecondYearSecond.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2

    '        dtgSecondYearSecond.CurrentRow.Cells(6).ReadOnly = False
    '    Else
    '        dtgSecondYearSecond.EditMode = DataGridViewEditMode.EditProgrammatically

    '        dtgSecondYearSecond.CurrentRow.Cells(6).ReadOnly = True
    '    End If
    'End Sub

    'Private Sub dtgThirdYearFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgThirdYearFirst.Click
    '    Try
    '        If dtgThirdYearFirst.CurrentRow.Cells(6).Selected Then
    '            dtgThirdYearFirst.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2

    '            dtgThirdYearFirst.CurrentRow.Cells(6).ReadOnly = False
    '        Else
    '            dtgThirdYearFirst.EditMode = DataGridViewEditMode.EditProgrammatically

    '            dtgThirdYearFirst.CurrentRow.Cells(6).ReadOnly = True
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub dtgThirdYearSecond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgThirdYearSecond.Click
    '    Try
    '        If dtgThirdYearSecond.CurrentRow.Cells(6).Selected Then
    '            dtgThirdYearSecond.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2

    '            dtgThirdYearSecond.CurrentRow.Cells(6).ReadOnly = False
    '        Else
    '            dtgThirdYearSecond.EditMode = DataGridViewEditMode.EditProgrammatically

    '            dtgThirdYearSecond.CurrentRow.Cells(6).ReadOnly = True
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub dtgFourthYearFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgFourthYearFirst.Click
    '    Try
    '        If dtgFourthYearFirst.CurrentRow.Cells(6).Selected Then
    '            dtgFourthYearFirst.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2

    '            dtgFourthYearFirst.CurrentRow.Cells(6).ReadOnly = False
    '        Else
    '            dtgFourthYearFirst.EditMode = DataGridViewEditMode.EditProgrammatically

    '            dtgFourthYearFirst.CurrentRow.Cells(6).ReadOnly = True
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub dtgFourthYearSecond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgFourthYearSecond.Click
    '    Try
    '        If dtgFourthYearSecond.CurrentRow.Cells(6).Selected Then
    '            dtgFourthYearSecond.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2

    '            dtgFourthYearSecond.CurrentRow.Cells(6).ReadOnly = False
    '        Else
    '            dtgFourthYearSecond.EditMode = DataGridViewEditMode.EditProgrammatically

    '            dtgFourthYearSecond.CurrentRow.Cells(6).ReadOnly = True
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub dtgFirstYearFirst_CellClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgFirstYearSecond.CellClick, dtgFirstYearFirst.CellClick
    '    If e.ColumnIndex = 7 Then
    '        frmAddingGrades.Show()
    '        frmAddingGrades.Focus()

    '    End If
    'End Sub

    Private Sub dtgFirstYearFirst_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgFirstYearFirst.CellClick
        If e.ColumnIndex = 6 Then
            frmAddingGrades.Show()
            frmAddingGrades.Focus()
            frmAddingGrades.lblGrades.Text = "dtgFirstYearFirst"
            frmAddingGrades.txtaddgrades.Text = dtgFirstYearFirst.CurrentRow.Cells(6).Value
            frmAddingGrades.lblPreRequisite.Text = dtgFirstYearFirst.CurrentRow.Cells(5).Value
            frmAddingGrades.txtPreRequisite.Text = dtgFirstYearFirst.CurrentRow.Cells(5).Value
            frmAddingGrades.lblidno.Text = lblIdNo.Text
            frmAddingGrades.txtaddgrades.Focus()
            frmAddingGrades.txtaddgrades.SelectAll()
        End If
    End Sub 
    Private Sub dtgFirstYearSecond_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgFirstYearSecond.CellClick
        If e.ColumnIndex = 6 Then
            frmAddingGrades.Show()
            frmAddingGrades.Focus()
            frmAddingGrades.lblGrades.Text = "dtgFirstYearSecond"
            frmAddingGrades.txtaddgrades.Text = dtgFirstYearSecond.CurrentRow.Cells(6).Value
            frmAddingGrades.lblPreRequisite.Text = dtgFirstYearSecond.CurrentRow.Cells(5).Value
            frmAddingGrades.txtPreRequisite.Text = dtgFirstYearSecond.CurrentRow.Cells(5).Value
            frmAddingGrades.lblidno.Text = lblIdNo.Text
            frmAddingGrades.txtaddgrades.Focus() 
            frmAddingGrades.txtaddgrades.SelectAll()
        End If
    End Sub

    Private Sub dtgSecondYearFirst_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgSecondYearFirst.CellClick
        If e.ColumnIndex = 6 Then
            frmAddingGrades.Show()
            frmAddingGrades.Focus()
            frmAddingGrades.lblGrades.Text = "dtgSecondYearFirst"
            frmAddingGrades.txtaddgrades.Text = dtgSecondYearFirst.CurrentRow.Cells(6).Value
            frmAddingGrades.lblPreRequisite.Text = dtgSecondYearFirst.CurrentRow.Cells(5).Value
            frmAddingGrades.txtPreRequisite.Text = dtgSecondYearFirst.CurrentRow.Cells(5).Value
            frmAddingGrades.lblidno.Text = lblIdNo.Text
            frmAddingGrades.txtaddgrades.Focus()
            frmAddingGrades.txtaddgrades.SelectAll()
        End If
    End Sub

    Private Sub dtgSecondYearSecond_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgSecondYearSecond.CellClick
        If e.ColumnIndex = 6 Then
            frmAddingGrades.Show()
            frmAddingGrades.Focus()
            frmAddingGrades.lblGrades.Text = "dtgSecondYearSecond"
            frmAddingGrades.txtaddgrades.Text = dtgSecondYearSecond.CurrentRow.Cells(6).Value
            frmAddingGrades.lblPreRequisite.Text = dtgSecondYearSecond.CurrentRow.Cells(5).Value
            frmAddingGrades.txtPreRequisite.Text = dtgSecondYearSecond.CurrentRow.Cells(5).Value
            frmAddingGrades.lblidno.Text = lblIdNo.Text
            frmAddingGrades.txtaddgrades.Focus()
            frmAddingGrades.txtaddgrades.SelectAll()
        End If
    End Sub

    Private Sub dtgThirdYearFirst_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgThirdYearFirst.CellClick
        If e.ColumnIndex = 6 Then
            frmAddingGrades.Show()
            frmAddingGrades.Focus()
            frmAddingGrades.lblGrades.Text = "dtgThirdYearFirst"
            frmAddingGrades.txtaddgrades.Text = dtgThirdYearFirst.CurrentRow.Cells(6).Value
            frmAddingGrades.lblPreRequisite.Text = dtgThirdYearFirst.CurrentRow.Cells(5).Value
            frmAddingGrades.txtPreRequisite.Text = dtgThirdYearFirst.CurrentRow.Cells(5).Value
            frmAddingGrades.lblidno.Text = lblIdNo.Text
            frmAddingGrades.txtaddgrades.Focus()
            frmAddingGrades.txtaddgrades.SelectAll()
        End If
    End Sub

    Private Sub dtgThirdYearSecond_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgThirdYearSecond.CellClick
        If e.ColumnIndex = 6 Then
            frmAddingGrades.Show()
            frmAddingGrades.Focus()
            frmAddingGrades.lblGrades.Text = "dtgThirdYearSecond"
            frmAddingGrades.txtaddgrades.Text = dtgThirdYearSecond.CurrentRow.Cells(6).Value
            frmAddingGrades.lblPreRequisite.Text = dtgThirdYearSecond.CurrentRow.Cells(5).Value
            frmAddingGrades.txtPreRequisite.Text = dtgThirdYearSecond.CurrentRow.Cells(5).Value
            frmAddingGrades.lblidno.Text = lblIdNo.Text
            frmAddingGrades.txtaddgrades.Focus()
            frmAddingGrades.txtaddgrades.SelectAll()
        End If
    End Sub

    Private Sub dtgFourthYearFirst_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgFourthYearFirst.CellClick
        If e.ColumnIndex = 6 Then
            frmAddingGrades.Show()
            frmAddingGrades.Focus()
            frmAddingGrades.lblGrades.Text = "dtgFourthYearFirst"
            frmAddingGrades.txtaddgrades.Text = dtgFourthYearFirst.CurrentRow.Cells(6).Value
            frmAddingGrades.lblPreRequisite.Text = dtgFourthYearFirst.CurrentRow.Cells(5).Value
            frmAddingGrades.txtPreRequisite.Text = dtgFourthYearFirst.CurrentRow.Cells(5).Value
            frmAddingGrades.lblidno.Text = lblIdNo.Text
            frmAddingGrades.txtaddgrades.Focus()
            frmAddingGrades.txtaddgrades.SelectAll()
        End If
    End Sub

    Private Sub dtgFourthYearSecond_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgFourthYearSecond.CellClick
        If e.ColumnIndex = 6 Then
            frmAddingGrades.Show()
            frmAddingGrades.Focus()
            frmAddingGrades.lblGrades.Text = "dtgFourthYearSecond"
            frmAddingGrades.txtaddgrades.Text = dtgFourthYearSecond.CurrentRow.Cells(6).Value
            frmAddingGrades.lblPreRequisite.Text = dtgFourthYearSecond.CurrentRow.Cells(5).Value
            frmAddingGrades.txtPreRequisite.Text = dtgFourthYearSecond.CurrentRow.Cells(5).Value
            frmAddingGrades.lblidno.Text = lblIdNo.Text
            frmAddingGrades.txtaddgrades.Focus()
            frmAddingGrades.txtaddgrades.SelectAll()
        End If
    End Sub
  Private Sub btnPrintFirstYearFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintFirstYearFirst.Click
        Try
            Dim yearlevel As String = "First"
            Dim semester As String = "First"



            sql = "SELECT *  FROM tblcourse c, `tblsubject` s, `tblgrades` g, tblstudent st  WHERE c.CourseId=s.CourseId AND s.`SubjectId`=g.`SubjectId` AND st.`IdNo`=g.`IdNo` " & _
            " AND  Semester='" & semester & "' AND g.YearLevel='" & yearlevel & "' AND st.`IdNo`=" & lblIdNo.Text & " ORDER BY GradesId ASC  "
            reports(sql, "OfferedSubject", frmPrintGrades.CrystalReportViewer1)
            frmPrintGrades.Show()
            frmPrintGrades.Focus()

        Catch ex As Exception

        End Try

    End Sub
 

    Private Sub btnPrintFirstYearSecond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintFirstYearSecond.Click
        Try
            Dim yearlevel As String = "First"
            Dim semester As String = "Second"

            Dim strsubj As String = ""
            Dim subj As String()
            Dim dtg As DataGridView = dtgFirstYearSecond

            ' Dim prerequisite As String = lblPreRequisite.Text.ToUpper
            ' For Each prerequisite As String In subj

            'For i As Integer = 0 To dtgFirstYearSecond.Rows.Count - 1
            '    strsubj = dtg.Rows(i).Cells(5).Value
            '    subj = strsubj.Split(",")

            '    For Each prerequisite As String In subj
            '        MsgBox(prerequisite)

            '    Next
            'Next
            
            For i As Integer = 0 To dtg.Rows.Count - 1
                strsubj = dtg.Rows(i).Cells(5).Value
                subj = strsubj.Split(",")

                For Each prerequisite As String In subj
                    sql = "SELECT *  FROM tblcourse c, `tblsubject` s, `tblgrades` g, tblstudent st  " & _
                    " WHERE c.CourseId=s.CourseId AND s.`SubjectId`=g.`SubjectId` AND st.`IdNo`=g.`IdNo` " & _
                    " AND  Semester='" & semester & "' AND g.YearLevel='" & yearlevel & _
                    "' AND st.`IdNo`=" & lblIdNo.Text & _
                    " AND Subject NOT IN ('" & prerequisite & "') AND ( Grades < 1 OR Grades > 3 )"

                Next
                reports(sql, "OfferedSubject", frmPrintGrades.CrystalReportViewer1)

            Next i



            'sql = "SELECT *  FROM tblcourse c, `tblsubject` s, `tblgrades` g, tblstudent st  WHERE c.CourseId=s.CourseId AND s.`SubjectId`=g.`SubjectId` AND st.`IdNo`=g.`IdNo` " & _
            '" AND  Semester='" & semester & "' AND g.YearLevel='" & yearlevel & "' AND st.`IdNo`=" & lblIdNo.Text & " ORDER BY GradesId ASC  "
            'reports(sql, "OfferedSubject", frmPrintGrades.CrystalReportViewer1)
            frmPrintGrades.Show()
            frmPrintGrades.Focus()

            ' Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrintSecondYearFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintSecondYearFirst.Click
        Try
            Dim yearlevel As String = "Second"
            Dim semester As String = "First"

            Dim strsubj As String = ""
            Dim subj As String() = strsubj.Split(",")
            Dim dtg As DataGridView = dtgSecondYearFirst

            ' Dim prerequisite As String = lblPreRequisite.Text.ToUpper
            ' For Each prerequisite As String In subj

            For i As Integer = 0 To dtg.Rows.Count - 1
                strsubj = dtg.Rows(i).Cells(5).Value
                subj = strsubj.Split(",")

                For Each prerequisite As String In subj

                    sql = "SELECT *  FROM tblcourse c, `tblsubject` s, `tblgrades` g, tblstudent st  WHERE c.CourseId=s.CourseId AND s.`SubjectId`=g.`SubjectId` AND st.`IdNo`=g.`IdNo` " & _
                    " AND  Semester='" & semester & "' AND g.YearLevel='" & yearlevel & _
                    "' AND st.`IdNo`=" & lblIdNo.Text & _
                    " AND Subject NOT IN ('" & prerequisite & "') AND  NOT Grades Between 0 and 3"
                    reports(sql, "OfferedSubject", frmPrintGrades.CrystalReportViewer1)

                Next
            Next

            'sql = "SELECT *  FROM tblcourse c, `tblsubject` s, `tblgrades` g, tblstudent st  WHERE c.CourseId=s.CourseId AND s.`SubjectId`=g.`SubjectId` AND st.`IdNo`=g.`IdNo` " & _
            '" AND  Semester='" & semester & "' AND g.YearLevel='" & yearlevel & "' AND st.`IdNo`=" & lblIdNo.Text & " ORDER BY GradesId ASC  "
            'reports(sql, "OfferedSubject", frmPrintGrades.CrystalReportViewer1)
            frmPrintGrades.Show()
            frmPrintGrades.Focus()

            
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrintSecondYearSecond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintSecondYearSecond.Click
        Try
            Dim yearlevel As String = "Second"
            Dim semester As String = "Second"

            Dim strsubj As String = ""
            Dim subj As String() = strsubj.Split(",")
            Dim dtg As DataGridView = dtgSecondYearSecond

            ' Dim prerequisite As String = lblPreRequisite.Text.ToUpper
            ' For Each prerequisite As String In subj

            For i As Integer = 0 To dtg.Rows.Count - 1
                strsubj = dtg.Rows(i).Cells(5).Value
                subj = strsubj.Split(",")

                For Each prerequisite As String In subj

                    sql = "SELECT *  FROM tblcourse c, `tblsubject` s, `tblgrades` g, tblstudent st  WHERE c.CourseId=s.CourseId AND s.`SubjectId`=g.`SubjectId` AND st.`IdNo`=g.`IdNo` " & _
                    " AND  Semester='" & semester & "' AND g.YearLevel='" & yearlevel & _
                    "' AND st.`IdNo`=" & lblIdNo.Text & _
                    " AND Subject NOT IN ('" & prerequisite & "') AND  NOT Grades Between 0 and 3"
                    reports(sql, "OfferedSubject", frmPrintGrades.CrystalReportViewer1)

                Next
            Next

            frmPrintGrades.Show()
            frmPrintGrades.Focus()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrintThirdYearFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintThirdYearFirst.Click
        Try
            Dim yearlevel As String = "Third"
            Dim semester As String = "First"

            Dim strsubj As String = ""
            Dim subj As String() = strsubj.Split(",")
            Dim dtg As DataGridView = dtgThirdYearFirst

            ' Dim prerequisite As String = lblPreRequisite.Text.ToUpper
            ' For Each prerequisite As String In subj

            For i As Integer = 0 To dtg.Rows.Count - 1
                strsubj = dtg.Rows(i).Cells(5).Value
                subj = strsubj.Split(",")

                For Each prerequisite As String In subj

                    sql = "SELECT *  FROM tblcourse c, `tblsubject` s, `tblgrades` g, tblstudent st  WHERE c.CourseId=s.CourseId AND s.`SubjectId`=g.`SubjectId` AND st.`IdNo`=g.`IdNo` " & _
                    " AND  Semester='" & semester & "' AND g.YearLevel='" & yearlevel & _
                    "' AND st.`IdNo`=" & lblIdNo.Text & _
                    " AND Subject NOT IN ('" & prerequisite & "') AND  NOT Grades Between 0 and 3"
                    reports(sql, "OfferedSubject", frmPrintGrades.CrystalReportViewer1)

                Next
            Next

            'sql = "SELECT *  FROM tblcourse c, `tblsubject` s, `tblgrades` g, tblstudent st  WHERE c.CourseId=s.CourseId AND s.`SubjectId`=g.`SubjectId` AND st.`IdNo`=g.`IdNo` " & _
            '" AND  Semester='" & semester & "' AND g.YearLevel='" & yearlevel & "' AND st.`IdNo`=" & lblIdNo.Text & " ORDER BY GradesId ASC  "
            'reports(sql, "OfferedSubject", frmPrintGrades.CrystalReportViewer1)
            frmPrintGrades.Show()
            frmPrintGrades.Focus()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrintThirdYearSecond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintThirdYearSecond.Click
        Try
            Dim yearlevel As String = "Third"
            Dim semester As String = "Second"


            Dim strsubj As String = ""
            Dim subj As String() = strsubj.Split(",")
            Dim dtg As DataGridView = dtgThirdYearSecond

            ' Dim prerequisite As String = lblPreRequisite.Text.ToUpper
            ' For Each prerequisite As String In subj

            For i As Integer = 0 To dtg.Rows.Count - 1
                strsubj = dtg.Rows(i).Cells(5).Value
                subj = strsubj.Split(",")

                For Each prerequisite As String In subj

                    sql = "SELECT *  FROM tblcourse c, `tblsubject` s, `tblgrades` g, tblstudent st  WHERE c.CourseId=s.CourseId AND s.`SubjectId`=g.`SubjectId` AND st.`IdNo`=g.`IdNo` " & _
                    " AND  Semester='" & semester & "' AND g.YearLevel='" & yearlevel & _
                    "' AND st.`IdNo`=" & lblIdNo.Text & _
                    " AND Subject NOT IN ('" & prerequisite & "') AND  NOT Grades Between 0 and 3"
                    reports(sql, "OfferedSubject", frmPrintGrades.CrystalReportViewer1)

                Next
            Next
            'sql = "SELECT *  FROM tblcourse c, `tblsubject` s, `tblgrades` g, tblstudent st  WHERE c.CourseId=s.CourseId AND s.`SubjectId`=g.`SubjectId` AND st.`IdNo`=g.`IdNo` " & _
            '" AND  Semester='" & semester & "' AND g.YearLevel='" & yearlevel & "' AND st.`IdNo`=" & lblIdNo.Text & " ORDER BY GradesId ASC  "
            'reports(sql, "OfferedSubject", frmPrintGrades.CrystalReportViewer1)
            frmPrintGrades.Show()
            frmPrintGrades.Focus()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrintFourthYearFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintFourthYearFirst.Click
        Try
            Dim yearlevel As String = "Fourth"
            Dim semester As String = "First"

            Dim strsubj As String = ""
            Dim subj As String() = strsubj.Split(",")
            Dim dtg As DataGridView = dtgFourthYearFirst

            ' Dim prerequisite As String = lblPreRequisite.Text.ToUpper
            ' For Each prerequisite As String In subj

            For i As Integer = 0 To dtg.Rows.Count - 1
                strsubj = dtg.Rows(i).Cells(5).Value
                subj = strsubj.Split(",")

                For Each prerequisite As String In subj

                    sql = "SELECT *  FROM tblcourse c, `tblsubject` s, `tblgrades` g, tblstudent st  WHERE c.CourseId=s.CourseId AND s.`SubjectId`=g.`SubjectId` AND st.`IdNo`=g.`IdNo` " & _
                    " AND  Semester='" & semester & "' AND g.YearLevel='" & yearlevel & _
                    "' AND st.`IdNo`=" & lblIdNo.Text & _
                    " AND Subject NOT IN ('" & prerequisite & "') AND  NOT Grades Between 0 and 3"
                    reports(sql, "OfferedSubject", frmPrintGrades.CrystalReportViewer1)

                Next
            Next

            'sql = "SELECT *  FROM tblcourse c, `tblsubject` s, `tblgrades` g, tblstudent st  WHERE c.CourseId=s.CourseId AND s.`SubjectId`=g.`SubjectId` AND st.`IdNo`=g.`IdNo` " & _
            '" AND  Semester='" & semester & "' AND g.YearLevel='" & yearlevel & "' AND st.`IdNo`=" & lblIdNo.Text & " ORDER BY GradesId ASC  "
            'reports(sql, "OfferedSubject", frmPrintGrades.CrystalReportViewer1)
            frmPrintGrades.Show()
            frmPrintGrades.Focus()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrintFourthYearSecond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintFourthYearSecond.Click
        Try
            Dim yearlevel As String = "Fourth"
            Dim semester As String = "Second"

            Dim strsubj As String = ""
            Dim subj As String() = strsubj.Split(",")
            Dim dtg As DataGridView = dtgFourthYearSecond

            ' Dim prerequisite As String = lblPreRequisite.Text.ToUpper
            ' For Each prerequisite As String In subj

            For i As Integer = 0 To dtg.Rows.Count - 1
                strsubj = dtg.Rows(i).Cells(5).Value
                subj = strsubj.Split(",")

                For Each prerequisite As String In subj

                    sql = "SELECT *  FROM tblcourse c, `tblsubject` s, `tblgrades` g, tblstudent st  WHERE c.CourseId=s.CourseId AND s.`SubjectId`=g.`SubjectId` AND st.`IdNo`=g.`IdNo` " & _
                    " AND  Semester='" & semester & "' AND g.YearLevel='" & yearlevel & _
                    "' AND st.`IdNo`=" & lblIdNo.Text & _
                    " AND Subject NOT IN ('" & prerequisite & "') AND  NOT Grades Between 0 and 3"
                    reports(sql, "OfferedSubject", frmPrintGrades.CrystalReportViewer1)

                Next
            Next


            'sql = "SELECT *  FROM tblcourse c, `tblsubject` s, `tblgrades` g, tblstudent st  WHERE c.CourseId=s.CourseId AND s.`SubjectId`=g.`SubjectId` AND st.`IdNo`=g.`IdNo` " & _
            '" AND  Semester='" & semester & "' AND g.YearLevel='" & yearlevel & "' AND st.`IdNo`=" & lblIdNo.Text & " ORDER BY GradesId ASC  "
            'reports(sql, "OfferedSubject", frmPrintGrades.CrystalReportViewer1)
            frmPrintGrades.Show()
            frmPrintGrades.Focus()

        Catch ex As Exception

        End Try
    End Sub
End Class