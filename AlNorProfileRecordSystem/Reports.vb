Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Reports
    Dim cryRpt As New ReportDocument
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AlnorEmpDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.AlnorEmpDataSet.Employee)
        UltraCombo1.Value = 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cryRpt.Load(My.Application.Info.DirectoryPath & "\EmployeeForm.rpt")

        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinition As ParameterFieldDefinition
        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        crParameterDiscreteValue.Value = UltraCombo1.Value
        crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition = crParameterFieldDefinitions.Item("empNumber")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.Refresh()
    End Sub
End Class