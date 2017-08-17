<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectionForm
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
        Me.ComboName = New System.Windows.Forms.ComboBox()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Make your selection"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'ComboName
        '
        Me.ComboName.FormattingEnabled = True
        Me.ComboName.Items.AddRange(New Object() {"Faculty Information", "Course Information", "Student Information"})
        Me.ComboName.Location = New System.Drawing.Point(32, 85)
        Me.ComboName.Name = "ComboName"
        Me.ComboName.Size = New System.Drawing.Size(213, 21)
        Me.ComboName.TabIndex = 1
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(32, 131)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 2
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(170, 131)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 3
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'SelectionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 202)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.ComboName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SelectionForm"
        Me.Text = "Selection Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboName As ComboBox
    Friend WithEvents cmdOK As Button
    Friend WithEvents cmdExit As Button
End Class
