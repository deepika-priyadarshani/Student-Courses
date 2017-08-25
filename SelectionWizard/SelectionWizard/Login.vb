Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CSE_DEPTDataSet.LogIn' table. You can move, or remove it, as needed.
        Me.LogInTableAdapter.Fill(Me.CSE_DEPTDataSet.LogIn)

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        Dim LoginTableApt As New CSE_DEPTDataSetTableAdapters.LogInTableAdapter
        Dim SelForm As New SelectionForm

        'Clearing the temp table everytime the ok button is clicked
        LoginTableApt.ClearBeforeFill = True
        LoginTableApt.FillByUserNamePassword(CSE_DEPTDataSet.LogIn, txtUserName.Text, txtPassword.Text)

        txtPassword.Clear()

        If CSE_DEPTDataSet.LogIn.Count = 0 Then
            MessageBox.Show("No matched username/password found", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        MessageBox.Show("Login success...transferring to Main Menu", "Login success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        MenuForm.Show()
        Me.Hide()

    End Sub
End Class