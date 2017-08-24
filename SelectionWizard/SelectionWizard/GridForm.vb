Public Class GridForm
    Private Sub FacultyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FacultyBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FacultyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CSE_DEPTDataSet)

    End Sub

    Private Sub GridForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CSE_DEPTDataSet.Faculty' table. You can move, or remove it, as needed.
        Me.FacultyTableAdapter.Fill(Me.CSE_DEPTDataSet.Faculty)

    End Sub

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        LoginForm.Show()
        Me.Hide()
    End Sub
End Class