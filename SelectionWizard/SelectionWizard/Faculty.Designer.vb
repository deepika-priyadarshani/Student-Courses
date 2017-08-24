<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacultyForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtImage = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FacultyBox = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboMethod = New System.Windows.Forms.GroupBox()
        Me.txtOffice = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCollege = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdSelect = New System.Windows.Forms.Button()
        Me.cmdInsert = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FacultyBox.SuspendLayout()
        Me.ComboMethod.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Faculty Image"
        '
        'txtImage
        '
        Me.txtImage.Location = New System.Drawing.Point(25, 47)
        Me.txtImage.Name = "txtImage"
        Me.txtImage.Size = New System.Drawing.Size(192, 20)
        Me.txtImage.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(25, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 336)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'FacultyBox
        '
        Me.FacultyBox.Controls.Add(Me.Label10)
        Me.FacultyBox.Controls.Add(Me.Label9)
        Me.FacultyBox.Controls.Add(Me.ComboBox2)
        Me.FacultyBox.Controls.Add(Me.ComboBox1)
        Me.FacultyBox.Location = New System.Drawing.Point(266, 30)
        Me.FacultyBox.Name = "FacultyBox"
        Me.FacultyBox.Size = New System.Drawing.Size(333, 100)
        Me.FacultyBox.TabIndex = 3
        Me.FacultyBox.TabStop = False
        Me.FacultyBox.Text = "Faculty Name and Query Method"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Query Method"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Faculty Name"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(143, 56)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(175, 21)
        Me.ComboBox2.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(144, 29)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(175, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'ComboMethod
        '
        Me.ComboMethod.Controls.Add(Me.txtOffice)
        Me.ComboMethod.Controls.Add(Me.txtEmail)
        Me.ComboMethod.Controls.Add(Me.txtCollege)
        Me.ComboMethod.Controls.Add(Me.txtPhone)
        Me.ComboMethod.Controls.Add(Me.txtTitle)
        Me.ComboMethod.Controls.Add(Me.txtName)
        Me.ComboMethod.Controls.Add(Me.txtID)
        Me.ComboMethod.Controls.Add(Me.Label8)
        Me.ComboMethod.Controls.Add(Me.Label7)
        Me.ComboMethod.Controls.Add(Me.Label6)
        Me.ComboMethod.Controls.Add(Me.Label5)
        Me.ComboMethod.Controls.Add(Me.Label4)
        Me.ComboMethod.Controls.Add(Me.Label3)
        Me.ComboMethod.Controls.Add(Me.Label2)
        Me.ComboMethod.Location = New System.Drawing.Point(266, 155)
        Me.ComboMethod.Name = "ComboMethod"
        Me.ComboMethod.Size = New System.Drawing.Size(333, 265)
        Me.ComboMethod.TabIndex = 4
        Me.ComboMethod.TabStop = False
        Me.ComboMethod.Text = "Faculty Information"
        '
        'txtOffice
        '
        Me.txtOffice.Location = New System.Drawing.Point(142, 115)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Size = New System.Drawing.Size(177, 20)
        Me.txtOffice.TabIndex = 14
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(142, 211)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(177, 20)
        Me.txtEmail.TabIndex = 12
        '
        'txtCollege
        '
        Me.txtCollege.Location = New System.Drawing.Point(142, 179)
        Me.txtCollege.Name = "txtCollege"
        Me.txtCollege.Size = New System.Drawing.Size(177, 20)
        Me.txtCollege.TabIndex = 11
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(142, 147)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(177, 20)
        Me.txtPhone.TabIndex = 10
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(142, 83)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(177, 20)
        Me.txtTitle.TabIndex = 9
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(142, 51)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(177, 20)
        Me.txtName.TabIndex = 8
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(142, 18)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(177, 20)
        Me.txtID.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Email :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "College :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Phone :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Office :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Title :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Faculty ID :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmdSelect
        '
        Me.cmdSelect.Location = New System.Drawing.Point(25, 443)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(75, 23)
        Me.cmdSelect.TabIndex = 5
        Me.cmdSelect.Text = "Select"
        Me.cmdSelect.UseVisualStyleBackColor = True
        '
        'cmdInsert
        '
        Me.cmdInsert.Location = New System.Drawing.Point(135, 443)
        Me.cmdInsert.Name = "cmdInsert"
        Me.cmdInsert.Size = New System.Drawing.Size(75, 23)
        Me.cmdInsert.TabIndex = 7
        Me.cmdInsert.Text = "Insert"
        Me.cmdInsert.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(245, 443)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(75, 23)
        Me.cmdUpdate.TabIndex = 8
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(355, 443)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 9
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(465, 443)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(132, 23)
        Me.cmdBack.TabIndex = 10
        Me.cmdBack.Text = "Back to Main Menu"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'FacultyForm
        '
        Me.AcceptButton = Me.cmdSelect
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 498)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdInsert)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.ComboMethod)
        Me.Controls.Add(Me.FacultyBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtImage)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FacultyForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Faculty"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FacultyBox.ResumeLayout(False)
        Me.FacultyBox.PerformLayout()
        Me.ComboMethod.ResumeLayout(False)
        Me.ComboMethod.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtImage As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FacultyBox As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboMethod As GroupBox
    Friend WithEvents txtOffice As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtCollege As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdSelect As Button
    Friend WithEvents cmdInsert As Button
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdBack As Button
End Class
