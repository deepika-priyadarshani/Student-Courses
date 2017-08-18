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
        Me.SuspendLayout()
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(12, 34)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(688, 95)
        Me.NameBox.TabIndex = 0
        Me.NameBox.TabStop = False
        Me.NameBox.Text = "Faculty Name and Query Method"
        '
        'CourseBox
        '
        Me.CourseBox.Location = New System.Drawing.Point(39, 248)
        Me.CourseBox.Name = "CourseBox"
        Me.CourseBox.Size = New System.Drawing.Size(200, 100)
        Me.CourseBox.TabIndex = 1
        Me.CourseBox.TabStop = False
        Me.CourseBox.Text = "Course List"
        '
        'CourseInfoBox
        '
        Me.CourseInfoBox.Location = New System.Drawing.Point(408, 272)
        Me.CourseInfoBox.Name = "CourseInfoBox"
        Me.CourseInfoBox.Size = New System.Drawing.Size(200, 100)
        Me.CourseInfoBox.TabIndex = 2
        Me.CourseInfoBox.TabStop = False
        Me.CourseInfoBox.Text = "Course Information"
        '
        'Course
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 491)
        Me.Controls.Add(Me.CourseInfoBox)
        Me.Controls.Add(Me.CourseBox)
        Me.Controls.Add(Me.NameBox)
        Me.Name = "Course"
        Me.Text = "CSE DEPT Course Form"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NameBox As GroupBox
    Friend WithEvents CourseBox As GroupBox
    Friend WithEvents CourseInfoBox As GroupBox
End Class
