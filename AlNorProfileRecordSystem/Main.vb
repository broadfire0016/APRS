Public Class Main
    Private Sub DeptBtn_Click(sender As Object, e As EventArgs) Handles DeptBtn.Click
        Department.Show()
    End Sub

    Private Sub EmpBtn_Click(sender As Object, e As EventArgs) Handles EmpBtn.Click
        Employees.Show()
    End Sub

    Private Sub ContractsBtn_Click(sender As Object, e As EventArgs) Handles ContractsBtn.Click
        Contracts.Show()
    End Sub
End Class