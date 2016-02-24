Public Class Infractions
    Private Sub InfractionsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles InfractionsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InfractionsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AlnorEmpDataSet)
        MsgBox("Record Saved!", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub Infractions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AlnorEmpDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.AlnorEmpDataSet.Employee)
        'TODO: This line of code loads data into the 'AlnorEmpDataSet.Infractions' table. You can move, or remove it, as needed.
        Me.InfractionsTableAdapter.Fill(Me.AlnorEmpDataSet.Infractions)
        UltraCombo1.Value = 1
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MM'/'dd'/'yyyy"
    End Sub

    Private Sub Infractions_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Emp_idLabel1.Text = UltraCombo1.Value
        Inf_dateLabel1.Text = DateTimePicker1.Text
        Inf_descriptionLabel1.Text = TextBox1.Text
        Inf_remarksLabel1.Text = TextBox2.Text
    End Sub

    Private Sub UltraCombo1_ValueChanged(sender As Object, e As EventArgs) Handles UltraCombo1.ValueChanged
        Emp_idLabel1.Text = UltraCombo1.Value

        If Emp_idLabel1.Text IsNot "" Then
            InfractionsBindingSource.Filter = "emp_id = " & Emp_idLabel1.Text & ""
        End If
    End Sub
End Class