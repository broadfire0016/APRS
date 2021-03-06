﻿Public Class Employees
    Dim selectedValue
    Private Sub EmployeeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmployeeBindingNavigatorSaveItem.Click
        'Emp_idLabel1.Text = Emp_idLabel2.Text
        Me.Validate()
        Me.EmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AlnorEmpDataSet)
        MsgBox("Record Saved!", MsgBoxStyle.OkOnly)
        EmployeeBindingSource.RemoveFilter()
        UltraCombo1.Enabled = True
    End Sub

    Private Sub Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AlnorEmpDataSet.Department' table. You can move, or remove it, as needed.
        Me.DepartmentTableAdapter.Fill(Me.AlnorEmpDataSet.Department)
        'TODO: This line of code loads data into the 'AlnorEmpDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.AlnorEmpDataSet.Employee)
        ComboBox1.SelectedValue = Dept_idLabel1.Text
        Emp_bdayDateTimePicker.Format = DateTimePickerFormat.Custom
        Emp_bdayDateTimePicker.CustomFormat = "ddd','MMM'/'dd'/'yyyy"
        UltraPictureBox1.DataBindings.Add("Image", EmployeeBindingSource, "emp_photo")
    End Sub

    Private Sub UltraButton1_Click(sender As Object, e As EventArgs) Handles UltraButton1.Click
        Dim dialog As New OpenFileDialog()
        dialog.Title = "Browse Picture"
        dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
        If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            UltraPictureBox1.Image = Image.FromFile(dialog.FileName)
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dept_idLabel1.Text = ComboBox1.SelectedValue
    End Sub
    Private Sub Dept_idLabel1_TextChanged(sender As Object, e As EventArgs) Handles Dept_idLabel1.TextChanged
        Try
            ComboBox1.SelectedValue = Dept_idLabel1.Text
        Catch ex As Exception
            ComboBox1.SelectedValue = 0
        End Try
    End Sub

    Private Sub Employees_MouseMove(sender As Object, e As EventArgs) Handles Me.MouseMove
        Emp_bdayLabel2.Text = Emp_bdayDateTimePicker.Text
        'Emp_idLabel1.Text = UltraCombo1.Value
    End Sub

    Private Sub UltraCombo1_ValueChanged(sender As Object, e As EventArgs) Handles UltraCombo1.ValueChanged
        Emp_idLabel1.Text = UltraCombo1.Value

        If Emp_idLabel1.Text IsNot "" Then
            EmployeeBindingSource.Filter = "emp_id = " & Emp_idLabel1.Text & ""
        End If
    End Sub

    Private Sub UltraButton2_Click(sender As Object, e As EventArgs) Handles UltraButton2.Click
        EmployeeBindingSource.RemoveFilter()
        UltraCombo1.Value = ""
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        UltraCombo1.Enabled = False
    End Sub
End Class