<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudent
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
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btn_last = New System.Windows.Forms.Button
        Me.btn_next = New System.Windows.Forms.Button
        Me.btn_New = New System.Windows.Forms.Button
        Me.btn_first = New System.Windows.Forms.Button
        Me.btn_delete = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.btn_prev = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtg_ABorrowLists = New System.Windows.Forms.DataGridView
        Me.txt_sid = New System.Windows.Forms.TextBox
        Me.txt_fname = New System.Windows.Forms.TextBox
        Me.rdio_female = New System.Windows.Forms.RadioButton
        Me.txt_mname = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_lname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.rch_address = New System.Windows.Forms.RichTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.rdio_male = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.btn_edit = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtPhoto = New System.Windows.Forms.TextBox
        Me.btnDisable = New System.Windows.Forms.Button
        Me.cboCourse = New System.Windows.Forms.ComboBox
        Me.cboYearLevel = New System.Windows.Forms.ComboBox
        CType(Me.dtg_ABorrowLists, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(290, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 39)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Student"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(601, 240)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(68, 36)
        Me.btnClose.TabIndex = 61
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btn_last
        '
        Me.btn_last.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_last.Location = New System.Drawing.Point(624, 281)
        Me.btn_last.Name = "btn_last"
        Me.btn_last.Size = New System.Drawing.Size(51, 24)
        Me.btn_last.TabIndex = 59
        Me.btn_last.Text = ">>|"
        Me.btn_last.UseVisualStyleBackColor = True
        '
        'btn_next
        '
        Me.btn_next.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.Location = New System.Drawing.Point(567, 281)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(51, 24)
        Me.btn_next.TabIndex = 58
        Me.btn_next.Text = ">>"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'btn_New
        '
        Me.btn_New.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_New.Location = New System.Drawing.Point(533, 240)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(68, 36)
        Me.btn_New.TabIndex = 56
        Me.btn_New.Text = "Clear"
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'btn_first
        '
        Me.btn_first.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_first.Location = New System.Drawing.Point(453, 281)
        Me.btn_first.Name = "btn_first"
        Me.btn_first.Size = New System.Drawing.Size(51, 24)
        Me.btn_first.TabIndex = 60
        Me.btn_first.Text = "|<<"
        Me.btn_first.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(533, 240)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(68, 36)
        Me.btn_delete.TabIndex = 55
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(467, 239)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(66, 36)
        Me.btn_save.TabIndex = 53
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_prev
        '
        Me.btn_prev.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_prev.Location = New System.Drawing.Point(510, 281)
        Me.btn_prev.Name = "btn_prev"
        Me.btn_prev.Size = New System.Drawing.Size(51, 24)
        Me.btn_prev.TabIndex = 57
        Me.btn_prev.Text = "<<"
        Me.btn_prev.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(53, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 17)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Course/Year :"
        '
        'dtg_ABorrowLists
        '
        Me.dtg_ABorrowLists.AllowUserToAddRows = False
        Me.dtg_ABorrowLists.AllowUserToDeleteRows = False
        Me.dtg_ABorrowLists.AllowUserToResizeColumns = False
        Me.dtg_ABorrowLists.AllowUserToResizeRows = False
        Me.dtg_ABorrowLists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtg_ABorrowLists.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtg_ABorrowLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_ABorrowLists.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtg_ABorrowLists.Location = New System.Drawing.Point(12, 311)
        Me.dtg_ABorrowLists.Name = "dtg_ABorrowLists"
        Me.dtg_ABorrowLists.RowHeadersVisible = False
        Me.dtg_ABorrowLists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_ABorrowLists.Size = New System.Drawing.Size(703, 193)
        Me.dtg_ABorrowLists.TabIndex = 48
        '
        'txt_sid
        '
        Me.txt_sid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sid.Location = New System.Drawing.Point(146, 64)
        Me.txt_sid.Name = "txt_sid"
        Me.txt_sid.Size = New System.Drawing.Size(278, 25)
        Me.txt_sid.TabIndex = 34
        '
        'txt_fname
        '
        Me.txt_fname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname.Location = New System.Drawing.Point(146, 97)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(278, 25)
        Me.txt_fname.TabIndex = 35
        '
        'rdio_female
        '
        Me.rdio_female.AutoSize = True
        Me.rdio_female.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdio_female.Location = New System.Drawing.Point(215, 247)
        Me.rdio_female.Name = "rdio_female"
        Me.rdio_female.Size = New System.Drawing.Size(67, 21)
        Me.rdio_female.TabIndex = 46
        Me.rdio_female.TabStop = True
        Me.rdio_female.Text = "Female"
        Me.rdio_female.UseVisualStyleBackColor = True
        '
        'txt_mname
        '
        Me.txt_mname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mname.Location = New System.Drawing.Point(146, 155)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.Size = New System.Drawing.Size(278, 25)
        Me.txt_mname.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Student Id :"
        '
        'txt_lname
        '
        Me.txt_lname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lname.Location = New System.Drawing.Point(146, 127)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(278, 25)
        Me.txt_lname.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "First Name :"
        '
        'rch_address
        '
        Me.rch_address.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rch_address.Location = New System.Drawing.Point(146, 183)
        Me.rch_address.Name = "rch_address"
        Me.rch_address.Size = New System.Drawing.Size(222, 58)
        Me.rch_address.TabIndex = 39
        Me.rch_address.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Last Name :"
        '
        'rdio_male
        '
        Me.rdio_male.AutoSize = True
        Me.rdio_male.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdio_male.Location = New System.Drawing.Point(153, 247)
        Me.rdio_male.Name = "rdio_male"
        Me.rdio_male.Size = New System.Drawing.Size(55, 21)
        Me.rdio_male.TabIndex = 45
        Me.rdio_male.TabStop = True
        Me.rdio_male.Text = "Male"
        Me.rdio_male.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(102, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 17)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "MI :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(73, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Address :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(110, 249)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 17)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Sex :"
        '
        'btn_edit
        '
        Me.btn_edit.Enabled = False
        Me.btn_edit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(466, 239)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(64, 36)
        Me.btn_edit.TabIndex = 54
        Me.btn_edit.Text = "Update"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(453, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'txtPhoto
        '
        Me.txtPhoto.Location = New System.Drawing.Point(467, 102)
        Me.txtPhoto.Name = "txtPhoto"
        Me.txtPhoto.Size = New System.Drawing.Size(209, 20)
        Me.txtPhoto.TabIndex = 62
        '
        'btnDisable
        '
        Me.btnDisable.Location = New System.Drawing.Point(533, 240)
        Me.btnDisable.Name = "btnDisable"
        Me.btnDisable.Size = New System.Drawing.Size(68, 36)
        Me.btnDisable.TabIndex = 64
        Me.btnDisable.Text = "Disable"
        Me.btnDisable.UseVisualStyleBackColor = True
        '
        'cboCourse
        '
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Location = New System.Drawing.Point(146, 274)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(160, 21)
        Me.cboCourse.TabIndex = 65
        Me.cboCourse.Text = "Select"
        '
        'cboYearLevel
        '
        Me.cboYearLevel.FormattingEnabled = True
        Me.cboYearLevel.Items.AddRange(New Object() {"First", "Second", "Third", "Fourth"})
        Me.cboYearLevel.Location = New System.Drawing.Point(312, 274)
        Me.cboYearLevel.Name = "cboYearLevel"
        Me.cboYearLevel.Size = New System.Drawing.Size(100, 21)
        Me.cboYearLevel.TabIndex = 66
        Me.cboYearLevel.Text = "Select"
        '
        'frmStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 517)
        Me.Controls.Add(Me.cboYearLevel)
        Me.Controls.Add(Me.cboCourse)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btn_last)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.btn_New)
        Me.Controls.Add(Me.btn_first)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_prev)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtg_ABorrowLists)
        Me.Controls.Add(Me.txt_sid)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.rdio_female)
        Me.Controls.Add(Me.txt_mname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_lname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rch_address)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rdio_male)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtPhoto)
        Me.Controls.Add(Me.btnDisable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Curriculum Evaluation System"
        CType(Me.dtg_ABorrowLists, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btn_last As System.Windows.Forms.Button
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents btn_New As System.Windows.Forms.Button
    Friend WithEvents btn_first As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_prev As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtg_ABorrowLists As System.Windows.Forms.DataGridView
    Friend WithEvents txt_sid As System.Windows.Forms.TextBox
    Friend WithEvents txt_fname As System.Windows.Forms.TextBox
    Friend WithEvents rdio_female As System.Windows.Forms.RadioButton
    Friend WithEvents txt_mname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_lname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rch_address As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rdio_male As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtPhoto As System.Windows.Forms.TextBox
    Friend WithEvents btnDisable As System.Windows.Forms.Button
    Friend WithEvents cboCourse As System.Windows.Forms.ComboBox
    Friend WithEvents cboYearLevel As System.Windows.Forms.ComboBox
End Class
