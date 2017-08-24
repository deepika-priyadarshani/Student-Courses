﻿Public Class MenuForm
    Private Sub cmdExitApplication_Click(sender As Object, e As EventArgs) Handles cmdExitApplication.Click
        Application.Exit()
    End Sub

    Private Sub cmdOpenFacultyForm_Click(sender As Object, e As EventArgs) Handles cmdOpenFacultyForm.Click
        FacultyForm.Show()
        Me.Hide()
    End Sub

    Private Sub cmdOpenCourseForm_Click(sender As Object, e As EventArgs) Handles cmdOpenCourseForm.Click
        CourseForm.Show()
        Me.Hide()
    End Sub
End Class