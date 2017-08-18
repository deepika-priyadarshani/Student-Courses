<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentForm
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
        Me.StudentNameBox = New System.Windows.Forms.GroupBox()
        Me.StudentInfoBox = New System.Windows.Forms.GroupBox()
        Me.CourseSelectedBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboName = New System.Windows.Forms.ComboBox()
        Me.ComboMethod = New System.Windows.Forms.ComboBox()
        Me.CourseList = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtGPA = New System.Windows.Forms.TextBox()
        Me.txtMajor = New System.Windows.Forms.TextBox()
        Me.txtCredits = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Photobox = New System.Windows.Forms.PictureBox()
        Me.cmdSelect = New System.Windows.Forms.Button()
        Me.cmdInsert = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.StudentNameBox.SuspendLayout()
        Me.StudentInfoBox.SuspendLayout()
        Me.CourseSelectedBox.SuspendLayout()
        CType(Me.Photobox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentNameBox
        '
        Me.StudentNameBox.Controls.Add(Me.ComboMethod)
        Me.StudentNameBox.Controls.Add(Me.ComboName)
        Me.StudentNameBox.Controls.Add(Me.Label2)
        Me.StudentNameBox.Controls.Add(Me.Label1)
        Me.StudentNameBox.Location = New System.Drawing.Point(12, 44)
        Me.StudentNameBox.Name = "StudentNameBox"
        Me.StudentNameBox.Size = New System.Drawing.Size(312, 89)
        Me.StudentNameBox.TabIndex = 0
        Me.StudentNameBox.TabStop = False
        Me.StudentNameBox.Text = "Student Name and Method"
        '
        'StudentInfoBox
        '
        Me.StudentInfoBox.Controls.Add(Me.txtEmail)
        Me.StudentInfoBox.Controls.Add(Me.txtCredits)
        Me.StudentInfoBox.Controls.Add(Me.txtMajor)
        Me.StudentInfoBox.Controls.Add(Me.txtGPA)
        Me.StudentInfoBox.Controls.Add(Me.txtYear)
        Me.StudentInfoBox.Controls.Add(Me.txtName)
        Me.StudentInfoBox.Controls.Add(Me.txtID)
        Me.StudentInfoBox.Controls.Add(Me.Label9)
        Me.StudentInfoBox.Controls.Add(Me.Label8)
        Me.StudentInfoBox.Controls.Add(Me.Label7)
        Me.StudentInfoBox.Controls.Add(Me.Label6)
        Me.StudentInfoBox.Controls.Add(Me.Label5)
        Me.StudentInfoBox.Controls.Add(Me.Label4)
        Me.StudentInfoBox.Controls.Add(Me.Label3)
        Me.StudentInfoBox.Location = New System.Drawing.Point(349, 165)
        Me.StudentInfoBox.Name = "StudentInfoBox"
        Me.StudentInfoBox.Size = New System.Drawing.Size(316, 226)
        Me.StudentInfoBox.TabIndex = 1
        Me.StudentInfoBox.TabStop = False
        Me.StudentInfoBox.Text = "Student Information"
        '
        'CourseSelectedBox
        '
        Me.CourseSelectedBox.Controls.Add(Me.CourseList)
        Me.CourseSelectedBox.Location = New System.Drawing.Point(369, 44)
        Me.CourseSelectedBox.Name = "CourseSelectedBox"
        Me.CourseSelectedBox.Size = New System.Drawing.Size(200, 100)
        Me.CourseSelectedBox.TabIndex = 1
        Me.CourseSelectedBox.TabStop = False
        Me.CourseSelectedBox.Text = "Course Selected"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Query Method"
        '
        'ComboName
        '
        Me.ComboName.FormattingEnabled = True
        Me.ComboName.Location = New System.Drawing.Point(68, 20)
        Me.ComboName.Name = "ComboName"
        Me.ComboName.Size = New System.Drawing.Size(121, 21)
        Me.ComboName.TabIndex = 2
        '
        'ComboMethod
        '
        Me.ComboMethod.FormattingEnabled = True
        Me.ComboMethod.Location = New System.Drawing.Point(68, 51)
        Me.ComboMethod.Name = "ComboMethod"
        Me.ComboMethod.Size = New System.Drawing.Size(121, 21)
        Me.ComboMethod.TabIndex = 3
        '
        'CourseList
        '
        Me.CourseList.FormattingEnabled = True
        Me.CourseList.Location = New System.Drawing.Point(6, 19)
        Me.CourseList.Name = "CourseList"
        Me.CourseList.Size = New System.Drawing.Size(120, 56)
        Me.CourseList.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Student ID :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "School Year :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Student Name :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Major :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "GPA :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Credits :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 178)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Email :"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(98, 20)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(212, 20)
        Me.txtID.TabIndex = 7
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(98, 46)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(212, 20)
        Me.txtName.TabIndex = 8
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(98, 78)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(212, 20)
        Me.txtYear.TabIndex = 9
        '
        'txtGPA
        '
        Me.txtGPA.Location = New System.Drawing.Point(104, 101)
        Me.txtGPA.Name = "txtGPA"
        Me.txtGPA.Size = New System.Drawing.Size(212, 20)
        Me.txtGPA.TabIndex = 10
        '
        'txtMajor
        '
        Me.txtMajor.Location = New System.Drawing.Point(104, 123)
        Me.txtMajor.Name = "txtMajor"
        Me.txtMajor.Size = New System.Drawing.Size(212, 20)
        Me.txtMajor.TabIndex = 11
        '
        'txtCredits
        '
        Me.txtCredits.Location = New System.Drawing.Point(98, 149)
        Me.txtCredits.Name = "txtCredits"
        Me.txtCredits.Size = New System.Drawing.Size(212, 20)
        Me.txtCredits.TabIndex = 12
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(104, 175)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(212, 20)
        Me.txtEmail.TabIndex = 13
        '
        'Photobox
        '
        Me.Photobox.Location = New System.Drawing.Point(12, 153)
        Me.Photobox.Name = "Photobox"
        Me.Photobox.Size = New System.Drawing.Size(312, 181)
        Me.Photobox.TabIndex = 2
        Me.Photobox.TabStop = False
        '
        'cmdSelect
        '
        Me.cmdSelect.Location = New System.Drawing.Point(13, 358)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(75, 23)
        Me.cmdSelect.TabIndex = 3
        Me.cmdSelect.Text = "Select"
        Me.cmdSelect.UseVisualStyleBackColor = True
        '
        'cmdInsert
        '
        Me.cmdInsert.Location = New System.Drawing.Point(126, 358)
        Me.cmdInsert.Name = "cmdInsert"
        Me.cmdInsert.Size = New System.Drawing.Size(75, 23)
        Me.cmdInsert.TabIndex = 4
        Me.cmdInsert.Text = "Insert"
        Me.cmdInsert.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(207, 358)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(117, 23)
        Me.cmdBack.TabIndex = 5
        Me.cmdBack.Text = "Back to Main Menu"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'StudentForm
        '
        Me.AcceptButton = Me.cmdSelect
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 418)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdInsert)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.Photobox)
        Me.Controls.Add(Me.StudentInfoBox)
        Me.Controls.Add(Me.CourseSelectedBox)
        Me.Controls.Add(Me.StudentNameBox)
        Me.Name = "StudentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSE DEPT Student Form"
        Me.StudentNameBox.ResumeLayout(False)
        Me.StudentNameBox.PerformLayout()
        Me.StudentInfoBox.ResumeLayout(False)
        Me.StudentInfoBox.PerformLayout()
        Me.CourseSelectedBox.ResumeLayout(False)
        CType(Me.Photobox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentNameBox As GroupBox
    Friend WithEvents ComboMethod As ComboBox
    Friend WithEvents ComboName As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents StudentInfoBox As GroupBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtCredits As TextBox
    Friend WithEvents txtMajor As TextBox
    Friend WithEvents txtGPA As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CourseSelectedBox As GroupBox
    Friend WithEvents CourseList As ListBox
    Friend WithEvents Photobox As PictureBox
    Friend WithEvents cmdSelect As Button
    Friend WithEvents cmdInsert As Button
    Friend WithEvents cmdBack As Button
End Class
