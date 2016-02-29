<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.DeptBtn = New Infragistics.Win.Misc.UltraButton()
        Me.EmpBtn = New Infragistics.Win.Misc.UltraButton()
        Me.ContractsBtn = New Infragistics.Win.Misc.UltraButton()
        Me.ReportsBtn = New Infragistics.Win.Misc.UltraButton()
        Me.UltraPictureBox1 = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.InfracBtn = New Infragistics.Win.Misc.UltraButton()
        Me.UltraPictureBox2 = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.SuspendLayout()
        '
        'DeptBtn
        '
        Me.DeptBtn.Location = New System.Drawing.Point(35, 306)
        Me.DeptBtn.Name = "DeptBtn"
        Me.DeptBtn.Size = New System.Drawing.Size(104, 67)
        Me.DeptBtn.TabIndex = 0
        Me.DeptBtn.Text = "Manage Departments"
        '
        'EmpBtn
        '
        Me.EmpBtn.Location = New System.Drawing.Point(35, 379)
        Me.EmpBtn.Name = "EmpBtn"
        Me.EmpBtn.Size = New System.Drawing.Size(104, 67)
        Me.EmpBtn.TabIndex = 1
        Me.EmpBtn.Text = "Manage Employees"
        '
        'ContractsBtn
        '
        Me.ContractsBtn.Location = New System.Drawing.Point(223, 306)
        Me.ContractsBtn.Name = "ContractsBtn"
        Me.ContractsBtn.Size = New System.Drawing.Size(104, 67)
        Me.ContractsBtn.TabIndex = 2
        Me.ContractsBtn.Text = "Manage Contracts"
        '
        'ReportsBtn
        '
        Me.ReportsBtn.Location = New System.Drawing.Point(411, 306)
        Me.ReportsBtn.Name = "ReportsBtn"
        Me.ReportsBtn.Size = New System.Drawing.Size(104, 67)
        Me.ReportsBtn.TabIndex = 3
        Me.ReportsBtn.Text = "Generate Reports"
        '
        'UltraPictureBox1
        '
        Me.UltraPictureBox1.BorderShadowColor = System.Drawing.Color.Transparent
        Me.UltraPictureBox1.Image = CType(resources.GetObject("UltraPictureBox1.Image"), Object)
        Me.UltraPictureBox1.Location = New System.Drawing.Point(155, 40)
        Me.UltraPictureBox1.Name = "UltraPictureBox1"
        Me.UltraPictureBox1.Size = New System.Drawing.Size(230, 129)
        Me.UltraPictureBox1.TabIndex = 4
        '
        'InfracBtn
        '
        Me.InfracBtn.Location = New System.Drawing.Point(223, 379)
        Me.InfracBtn.Name = "InfracBtn"
        Me.InfracBtn.Size = New System.Drawing.Size(104, 67)
        Me.InfracBtn.TabIndex = 5
        Me.InfracBtn.Text = "Manage Infractions"
        '
        'UltraPictureBox2
        '
        Me.UltraPictureBox2.AutoSize = True
        Me.UltraPictureBox2.BorderShadowColor = System.Drawing.Color.Transparent
        Me.UltraPictureBox2.Image = CType(resources.GetObject("UltraPictureBox2.Image"), Object)
        Me.UltraPictureBox2.Location = New System.Drawing.Point(47, 157)
        Me.UltraPictureBox2.Name = "UltraPictureBox2"
        Me.UltraPictureBox2.Size = New System.Drawing.Size(468, 60)
        Me.UltraPictureBox2.TabIndex = 6
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(561, 498)
        Me.Controls.Add(Me.UltraPictureBox1)
        Me.Controls.Add(Me.UltraPictureBox2)
        Me.Controls.Add(Me.InfracBtn)
        Me.Controls.Add(Me.ReportsBtn)
        Me.Controls.Add(Me.ContractsBtn)
        Me.Controls.Add(Me.EmpBtn)
        Me.Controls.Add(Me.DeptBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(577, 537)
        Me.MinimumSize = New System.Drawing.Size(577, 537)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DeptBtn As Infragistics.Win.Misc.UltraButton
    Friend WithEvents EmpBtn As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ContractsBtn As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ReportsBtn As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraPictureBox1 As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents InfracBtn As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraPictureBox2 As Infragistics.Win.UltraWinEditors.UltraPictureBox
End Class
