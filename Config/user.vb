﻿Imports MySql.Data.MySqlClient
Module user
    Public con As MySqlConnection = mysqldb()
 
    Public Sub login(ByVal username As Object, ByVal pass As Object)
        Try

            con.Open()
            reloadtxt("SELECT * FROM `tbluseraccount` WHERE User_name= '" & username & "' and Pass = sha1('" & pass & "')")


            If dt.Rows.Count > 0 Then
                If dt.Rows(0).Item("UserType") = "Administrator" Then
                    MsgBox("Welcome " & dt.Rows(0).Item("UserType"))
                    'Form1.Text = "User :" & dt.Rows(0).Item("Fullname")
                    With Form1
                        .StudentToolStripMenuItem.Visible = True
                        .CourseToolStripMenuItem.Visible = True
                        .ManageUsersToolStripMenuItem.Visible = True
                        '.CurriculumToolStripMenuItem.Visible = True
                        .SubjectsToolStripMenuItem.Visible = True
                        .GradesToolStripMenuItem.Visible = True
                        .ReportToolStripMenuItem.Visible = True
                        '.LoginToolStripMenuItem.Text = "Logout"
                    End With



                    LoginForm1.Hide()


                ElseIf dt.Rows(0).Item("UserType") = "Faculty" Then

                    MsgBox("Welcome " & dt.Rows(0).Item("UserType"))
                    'Form1.Text = "User :" & dt.Rows(0).Item("Fullname")
                    With Form1
                        .StudentToolStripMenuItem.Visible = True
                        '.CourseToolStripMenuItem.Visible = True
                        '.ManageUsersToolStripMenuItem.Visible = True
                        '.CurriculumToolStripMenuItem.Visible = True
                        .SubjectsToolStripMenuItem.Visible = True
                        .GradesToolStripMenuItem.Visible = True
                        .ReportToolStripMenuItem.Visible = True
                        '.LoginToolStripMenuItem.Text = "Logout"
                    End With



                    LoginForm1.Hide()



                ElseIf dt.Rows(0).Item("UserType") = "Assistant" Then
                    MsgBox("Welcome " & dt.Rows(0).Item("UserType"))
                    'With Form1
                    With Form1
                        '.BooksToolStripMenuItem.Visible = True
                        '.BorrowerToolStripMenuItem.Visible = True
                        ''.ManageUsersToolStripMenuItem.Visible = True
                        '.TransactionToolStripMenuItem.Visible = True
                        '.SearchToolStripMenuItem.Visible = True
                        '.ReportsToolStripMenuItem.Visible = True
                        '.LoginToolStripMenuItem.Text = "Logout"
                    End With


                    LoginForm1.Hide()
                End If
               
                'Form1.UserIdToolStripStatus.Text = dt.Rows(0).Item("UserId")
                'Form1.UserToolStripStatus.Text = dt.Rows(0).Item("Fullname")
                'Form1.StatusStrip1.Visible = True
                'inserting logs
                'sql = "INSERT INTO `tbllogs` (`UserId`, `LogDate`,LogMode) " & _
                '   " VALUES ('" & dt.Rows(0).Item("UserId") & "',Now(),'Logged in')"
                'create(sql)
                Form1.Show()
                Form1.Focus()
            Else
                MsgBox("Acount doest not exist!", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        da.Dispose()
    End Sub
    Public Sub append(ByVal sql As String, ByVal field As String, ByVal txt As Object)
        reloadtxt(sql)
        Try
            Dim r As DataRow
            txt.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txt.AutoCompleteCustomSource.Add(r.Item(field).ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       

    End Sub
End Module
