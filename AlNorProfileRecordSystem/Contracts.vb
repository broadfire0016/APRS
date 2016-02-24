Public Class Contracts
    Private Sub ContractsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ContractsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ContractsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AlnorEmpDataSet)
        MsgBox("Record Saved!", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub Contracts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AlnorEmpDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.AlnorEmpDataSet.Employee)
        'TODO: This line of code loads data into the 'AlnorEmpDataSet.Contracts' table. You can move, or remove it, as needed.
        Me.ContractsTableAdapter.Fill(Me.AlnorEmpDataSet.Contracts)
        UltraCombo1.Value = 1
        Con_startsLabel1.Text = DateTimePicker1.Value
        Con_endsLabel1.Text = DateTimePicker2.Value
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MM'/'dd'/'yyyy"
        DateTimePicker2.CustomFormat = "MM'/'dd'/'yyyy"
    End Sub
    Private Sub Contracts_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

        Con_startsLabel1.Text = DateTimePicker1.Text
        Con_endsLabel1.Text = DateTimePicker2.Text
        Emp_idLabel1.Text = UltraCombo1.Value

    End Sub
    Private Sub UltraCombo1_ValueChanged(sender As Object, e As EventArgs) Handles UltraCombo1.ValueChanged

        Emp_idLabel1.Text = UltraCombo1.Value

        If Emp_idLabel1.Text IsNot "" Then
            ContractsBindingSource.Filter = "emp_id = " & Emp_idLabel1.Text & ""
        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Con_startsLabel1.Text = DateTimePicker1.Value
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Con_endsLabel1.Text = DateTimePicker2.Value
    End Sub
End Class