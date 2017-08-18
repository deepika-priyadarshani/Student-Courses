<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Course
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
        Me.NameBox = New System.Windows.Forms.GroupBox()
        Me.CourseBox = New System.Windows.Forms.GroupBox()
        Me.CourseInfoBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboName = New System.Windows.Forms.ComboBox()
        Me.ComboMethod = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtSchedule = New System.Windows.Forms.TextBox()
        Me.txtCredits = New System.Windows.Forms.TextBox()
        Me.txtClassroom = New System.Windows.Forms.TextBox()
        Me.txtEnrolments = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.NameBox.SuspendLayout()
        Me.CourseInfoBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameBox
        '
        Me.NameBox.Controls.Add(Me.ComboMethod)
        Me.NameBox.Controls.Add(Me.ComboName)
        Me.NameBox.Controls.Add(Me.Label2)
        Me.NameBox.Controls.Add(Me.Label1)
        Me.NameBox.Location = New System.Drawing.Point(12, 34)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(688, 95)
        Me.NameBox.TabIndex = 0
        Me.NameBox.TabStop = False
        Me.NameBox.Text = "Faculty Name and Query Method"
        '
        'CourseBox
        '
        Me.CourseBox.Location = New System.Drawing.Point(12, 151)
        Me.CourseBox.Name = "CourseBox"
        Me.CourseBox.Size = New System.Drawing.Size(227, 197)
        Me.CourseBox.TabIndex = 1
        Me.CourseBox.TabStop = False
        Me.CourseBox.Text = "Course List"
        '
        'CourseInfoBox
        '
        Me.CourseInfoBox.Controls.Add(Me.txtEnrolments)
        Me.CourseInfoBox.Controls.Add(Me.txtClassroom)
        Me.CourseInfoBox.Controls.Add(Me.txtCredits)
        Me.CourseInfoBox.Controls.Add(Me.txtSchedule)
        Me.CourseInfoBox.Controls.Add(Me.txtCourse)
        Me.CourseInfoBox.Controls.Add(Me.txtID)
        Me.CourseInfoBox.Controls.Add(Me.Label8)
        Me.CourseInfoBox.Controls.Add(Me.Label7)
        Me.CourseInfoBox.Controls.Add(Me.Label6)
        Me.CourseInfoBox.Controls.Add(Me.Label5)
        Me.CourseInfoBox.Controls.Add(Me.Label4)
        Me.CourseInfoBox.Controls.Add(Me.Label3)
        Me.CourseInfoBox.Location = New System.Drawing.Point(275, 151)
        Me.CourseInfoBox.Name = "CourseInfoBox"
        Me.CourseInfoBox.Size = New System.Drawing.Size(425, 221)
        Me.CourseInfoBox.TabIndex = 2
        Me.CourseInfoBox.TabStop = False
        Me.CourseInfoBox.Text = "Course Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Faculty Name : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Query Method : "
        '
        'ComboName
        '
        Me.ComboName.FormattingEnabled = True
        Me.ComboName.Location = New System.Drawing.Point(150, 20)
        Me.ComboName.Name = "ComboName"
        Me.ComboName.Size = New System.Drawing.Size(347, 21)
        Me.ComboName.TabIndex = 2
        '
        'ComboMethod
        '
        Me.ComboMethod.FormattingEnabled = True
        Me.ComboMethod.Location = New System.Drawing.Point(150, 57)
        Me.ComboMethod.Name = "ComboMethod"
        Me.ComboMethod.Size = New System.Drawing.Size(347, 21)
        Me.ComboMethod.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Course ID : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Course :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Schedule :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Credits :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Classroom :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Enrolments :"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(131, 19)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(274, 20)
        Me.txtID.TabIndex = 7
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(136, 58)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(239, 20)
        Me.txtCourse.TabIndex = 8
        '
        'txtSchedule
        '
        Me.txtSchedule.Location = New System.Drawing.Point(136, 89)
        Me.txtSchedule.Name = "txtSchedule"
        Me.txtSchedule.Size = New System.Drawing.Size(239, 20)
        Me.txtSchedule.TabIndex = 9
        '
        'txtCredits
        '
        Me.txtCredits.Location = New System.Drawing.Point(136, 144)
        Me.txtCredits.Name = "txtCredits"
        Me.txtCredits.Size = New System.Drawing.Size(239, 20)
        Me.txtCredits.TabIndex = 10
        '
        'txtClassroom
        '
        Me.txtClassroom.Location = New System.Drawing.Point(131, 118)
        Me.txtClassroom.Name = "txtClassroom"
        Me.txtClassroom.Size = New System.Drawing.Size(239, 20)
        Me.txtClassroom.TabIndex = 11
        '
        'txtEnrolments
        '
        Me.txtEnrolments.Location = New System.Drawing.Point(131, 171)
        Me.txtEnrolments.Name = "txtEnrolments"
        Me.txtEnrolments.Size = New System.Drawing.Size(239, 20)
        Me.txtEnrolments.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Location = New System.Drawing.Point(275, 151)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 221)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Course Information"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(131, 168)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(274, 20)
        Me.TextBox1.TabIndex = 12
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(131, 109)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(274, 20)
        Me.TextBox2.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(131, 138)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(274, 20)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(131, 79)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(274, 20)
        Me.TextBox4.TabIndex = 9
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(131, 49)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(274, 20)
        Me.TextBox5.TabIndex = 8
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(131, 19)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(274, 20)
        Me.TextBox6.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 172)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Enrolments :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Classroom :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 142)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Credits :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Schedule :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Course :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(26, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Course ID : "
        '
        'Course
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 491)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CourseInfoBox)
        Me.Controls.Add(Me.CourseBox)
        Me.Controls.Add(Me.NameBox)
        Me.Name = "Course"
        Me.Text = "CSE DEPT Course Form"
        Me.NameBox.ResumeLayout(False)
        Me.NameBox.PerformLayout()
        Me.CourseInfoBox.ResumeLayout(False)
        Me.CourseInfoBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NameBox As GroupBox
    Friend WithEvents CourseBox As GroupBox
    Friend WithEvents CourseInfoBox As GroupBox
    Friend WithEvents ComboMethod As ComboBox
    Friend WithEvents ComboName As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEnrolments As TextBox
    Friend WithEvents txtClassroom As TextBox
    Friend WithEvents txtCredits As TextBox
    Friend WithEvents txtSchedule As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
