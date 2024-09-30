<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddingGrades
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
        Me.txtaddgrades = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.lblGrades = New System.Windows.Forms.Label
        Me.lblPreRequisite = New System.Windows.Forms.Label
        Me.lblidno = New System.Windows.Forms.Label
        Me.txtPreRequisite = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtaddgrades
        '
        Me.txtaddgrades.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddgrades.Location = New System.Drawing.Point(18, 44)
        Me.txtaddgrades.Name = "txtaddgrades"
        Me.txtaddgrades.Size = New System.Drawing.Size(378, 45)
        Me.txtaddgrades.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Add Grades "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 206)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(384, 203)
        Me.DataGridView1.TabIndex = 2
        '
        'lblGrades
        '
        Me.lblGrades.AutoSize = True
        Me.lblGrades.Location = New System.Drawing.Point(279, 58)
        Me.lblGrades.Name = "lblGrades"
        Me.lblGrades.Size = New System.Drawing.Size(39, 13)
        Me.lblGrades.TabIndex = 3
        Me.lblGrades.Text = "Label2"
        '
        'lblPreRequisite
        '
        Me.lblPreRequisite.AutoSize = True
        Me.lblPreRequisite.Location = New System.Drawing.Point(215, 58)
        Me.lblPreRequisite.Name = "lblPreRequisite"
        Me.lblPreRequisite.Size = New System.Drawing.Size(39, 13)
        Me.lblPreRequisite.TabIndex = 3
        Me.lblPreRequisite.Text = "Label2"
        '
        'lblidno
        '
        Me.lblidno.AutoSize = True
        Me.lblidno.Location = New System.Drawing.Point(324, 67)
        Me.lblidno.Name = "lblidno"
        Me.lblidno.Size = New System.Drawing.Size(39, 13)
        Me.lblidno.TabIndex = 4
        Me.lblidno.Text = "Label2"
        '
        'txtPreRequisite
        '
        Me.txtPreRequisite.Location = New System.Drawing.Point(52, 51)
        Me.txtPreRequisite.Name = "txtPreRequisite"
        Me.txtPreRequisite.Size = New System.Drawing.Size(133, 20)
        Me.txtPreRequisite.TabIndex = 5
        '
        'frmAddingGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 117)
        Me.Controls.Add(Me.txtaddgrades)
        Me.Controls.Add(Me.txtPreRequisite)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPreRequisite)
        Me.Controls.Add(Me.lblGrades)
        Me.Controls.Add(Me.lblidno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddingGrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grades"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtaddgrades As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblGrades As System.Windows.Forms.Label
    Friend WithEvents lblPreRequisite As System.Windows.Forms.Label
    Friend WithEvents lblidno As System.Windows.Forms.Label
    Friend WithEvents txtPreRequisite As System.Windows.Forms.TextBox
End Class
