<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Me.cmdOpenFacultyForm = New System.Windows.Forms.Button()
        Me.cmdOpenCourseForm = New System.Windows.Forms.Button()
        Me.cmdOpenStudentsForm = New System.Windows.Forms.Button()
        Me.cmdExitApplication = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdOpenFacultyForm
        '
        Me.cmdOpenFacultyForm.Location = New System.Drawing.Point(79, 55)
        Me.cmdOpenFacultyForm.Name = "cmdOpenFacultyForm"
        Me.cmdOpenFacultyForm.Size = New System.Drawing.Size(75, 23)
        Me.cmdOpenFacultyForm.TabIndex = 0
        Me.cmdOpenFacultyForm.Text = "Faculty"
        Me.cmdOpenFacultyForm.UseVisualStyleBackColor = True
        '
        'cmdOpenCourseForm
        '
        Me.cmdOpenCourseForm.Location = New System.Drawing.Point(79, 106)
        Me.cmdOpenCourseForm.Name = "cmdOpenCourseForm"
        Me.cmdOpenCourseForm.Size = New System.Drawing.Size(75, 23)
        Me.cmdOpenCourseForm.TabIndex = 1
        Me.cmdOpenCourseForm.Text = "Courses"
        Me.cmdOpenCourseForm.UseVisualStyleBackColor = True
        '
        'cmdOpenStudentsForm
        '
        Me.cmdOpenStudentsForm.Location = New System.Drawing.Point(79, 135)
        Me.cmdOpenStudentsForm.Name = "cmdOpenStudentsForm"
        Me.cmdOpenStudentsForm.Size = New System.Drawing.Size(75, 23)
        Me.cmdOpenStudentsForm.TabIndex = 2
        Me.cmdOpenStudentsForm.Text = "Students"
        Me.cmdOpenStudentsForm.UseVisualStyleBackColor = True
        '
        'cmdExitApplication
        '
        Me.cmdExitApplication.Location = New System.Drawing.Point(79, 177)
        Me.cmdExitApplication.Name = "cmdExitApplication"
        Me.cmdExitApplication.Size = New System.Drawing.Size(75, 23)
        Me.cmdExitApplication.TabIndex = 3
        Me.cmdExitApplication.Text = "Exit"
        Me.cmdExitApplication.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Click a Button to Open the Form"
        '
        'MenuForm
        '
        Me.AcceptButton = Me.cmdOpenFacultyForm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdExitApplication)
        Me.Controls.Add(Me.cmdOpenStudentsForm)
        Me.Controls.Add(Me.cmdOpenCourseForm)
        Me.Controls.Add(Me.cmdOpenFacultyForm)
        Me.Name = "MenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSE DEPT Menu Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdOpenFacultyForm As Button
    Friend WithEvents cmdOpenCourseForm As Button
    Friend WithEvents cmdOpenStudentsForm As Button
    Friend WithEvents cmdExitApplication As Button
    Friend WithEvents Label1 As Label
End Class
