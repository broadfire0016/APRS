<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Infractions
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
        Me.components = New System.ComponentModel.Container()
        Dim Inf_IDLabel As System.Windows.Forms.Label
        Dim Emp_idLabel As System.Windows.Forms.Label
        Dim Inf_descriptionLabel As System.Windows.Forms.Label
        Dim Inf_dateLabel As System.Windows.Forms.Label
        Dim Inf_remarksLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Infractions))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Employee", -1)
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_id")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_num")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_lname")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_fname")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_mname")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_position")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("dept_id")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_address")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_gender")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_bday")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_religion")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_educ")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_mobile")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_sss")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_phealth")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_tin")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_photo")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_resign")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EmployeeContracts")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EmployeeInfractions")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("EmployeeContracts", 0)
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("con_ID")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_id")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("con_starts")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("con_ends")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("EmployeeInfractions", 0)
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("inf_ID")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_id")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("inf_description")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("inf_date")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("inf_remarks")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.InfractionsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.InfractionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlnorEmpDataSet = New AlNorProfileRecordSystem.AlnorEmpDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.InfractionsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.InfractionsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inf_IDLabel1 = New System.Windows.Forms.Label()
        Me.Emp_idLabel1 = New System.Windows.Forms.Label()
        Me.Inf_descriptionLabel1 = New System.Windows.Forms.Label()
        Me.Inf_dateLabel1 = New System.Windows.Forms.Label()
        Me.Inf_remarksLabel1 = New System.Windows.Forms.Label()
        Me.UltraCombo1 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.InfractionsTableAdapter = New AlNorProfileRecordSystem.AlnorEmpDataSetTableAdapters.InfractionsTableAdapter()
        Me.TableAdapterManager = New AlNorProfileRecordSystem.AlnorEmpDataSetTableAdapters.TableAdapterManager()
        Me.EmployeeTableAdapter = New AlNorProfileRecordSystem.AlnorEmpDataSetTableAdapters.EmployeeTableAdapter()
        Inf_IDLabel = New System.Windows.Forms.Label()
        Emp_idLabel = New System.Windows.Forms.Label()
        Inf_descriptionLabel = New System.Windows.Forms.Label()
        Inf_dateLabel = New System.Windows.Forms.Label()
        Inf_remarksLabel = New System.Windows.Forms.Label()
        CType(Me.InfractionsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InfractionsBindingNavigator.SuspendLayout()
        CType(Me.InfractionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlnorEmpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InfractionsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCombo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Inf_IDLabel
        '
        Inf_IDLabel.AutoSize = True
        Inf_IDLabel.Location = New System.Drawing.Point(399, 321)
        Inf_IDLabel.Name = "Inf_IDLabel"
        Inf_IDLabel.Size = New System.Drawing.Size(35, 13)
        Inf_IDLabel.TabIndex = 2
        Inf_IDLabel.Text = "inf ID:"
        '
        'Emp_idLabel
        '
        Emp_idLabel.AutoSize = True
        Emp_idLabel.Location = New System.Drawing.Point(48, 95)
        Emp_idLabel.Name = "Emp_idLabel"
        Emp_idLabel.Size = New System.Drawing.Size(56, 13)
        Emp_idLabel.TabIndex = 4
        Emp_idLabel.Text = "Employee:"
        '
        'Inf_descriptionLabel
        '
        Inf_descriptionLabel.AutoSize = True
        Inf_descriptionLabel.Location = New System.Drawing.Point(48, 143)
        Inf_descriptionLabel.Name = "Inf_descriptionLabel"
        Inf_descriptionLabel.Size = New System.Drawing.Size(63, 13)
        Inf_descriptionLabel.TabIndex = 6
        Inf_descriptionLabel.Text = "Description:"
        '
        'Inf_dateLabel
        '
        Inf_dateLabel.AutoSize = True
        Inf_dateLabel.Location = New System.Drawing.Point(317, 95)
        Inf_dateLabel.Name = "Inf_dateLabel"
        Inf_dateLabel.Size = New System.Drawing.Size(83, 13)
        Inf_dateLabel.TabIndex = 8
        Inf_dateLabel.Text = "Date Recorded:"
        '
        'Inf_remarksLabel
        '
        Inf_remarksLabel.AutoSize = True
        Inf_remarksLabel.Location = New System.Drawing.Point(317, 143)
        Inf_remarksLabel.Name = "Inf_remarksLabel"
        Inf_remarksLabel.Size = New System.Drawing.Size(52, 13)
        Inf_remarksLabel.TabIndex = 10
        Inf_remarksLabel.Text = "Remarks:"
        '
        'InfractionsBindingNavigator
        '
        Me.InfractionsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.InfractionsBindingNavigator.BindingSource = Me.InfractionsBindingSource
        Me.InfractionsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InfractionsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.InfractionsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.InfractionsBindingNavigatorSaveItem})
        Me.InfractionsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.InfractionsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InfractionsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InfractionsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InfractionsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InfractionsBindingNavigator.Name = "InfractionsBindingNavigator"
        Me.InfractionsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InfractionsBindingNavigator.Size = New System.Drawing.Size(620, 25)
        Me.InfractionsBindingNavigator.TabIndex = 0
        Me.InfractionsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'InfractionsBindingSource
        '
        Me.InfractionsBindingSource.DataMember = "Infractions"
        Me.InfractionsBindingSource.DataSource = Me.AlnorEmpDataSet
        '
        'AlnorEmpDataSet
        '
        Me.AlnorEmpDataSet.DataSetName = "AlnorEmpDataSet"
        Me.AlnorEmpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'InfractionsBindingNavigatorSaveItem
        '
        Me.InfractionsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InfractionsBindingNavigatorSaveItem.Image = CType(resources.GetObject("InfractionsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.InfractionsBindingNavigatorSaveItem.Name = "InfractionsBindingNavigatorSaveItem"
        Me.InfractionsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.InfractionsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'InfractionsDataGridView
        '
        Me.InfractionsDataGridView.AllowUserToAddRows = False
        Me.InfractionsDataGridView.AllowUserToDeleteRows = False
        Me.InfractionsDataGridView.AutoGenerateColumns = False
        Me.InfractionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InfractionsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.InfractionsDataGridView.DataSource = Me.InfractionsBindingSource
        Me.InfractionsDataGridView.Location = New System.Drawing.Point(26, 268)
        Me.InfractionsDataGridView.Name = "InfractionsDataGridView"
        Me.InfractionsDataGridView.ReadOnly = True
        Me.InfractionsDataGridView.Size = New System.Drawing.Size(543, 220)
        Me.InfractionsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "inf_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "inf_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "emp_id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "emp_id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "inf_description"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "inf_date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Date Recorded"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "inf_remarks"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Inf_IDLabel1
        '
        Me.Inf_IDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InfractionsBindingSource, "inf_ID", True))
        Me.Inf_IDLabel1.Location = New System.Drawing.Point(440, 321)
        Me.Inf_IDLabel1.Name = "Inf_IDLabel1"
        Me.Inf_IDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Inf_IDLabel1.TabIndex = 3
        Me.Inf_IDLabel1.Text = "Label1"
        '
        'Emp_idLabel1
        '
        Me.Emp_idLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InfractionsBindingSource, "emp_id", True))
        Me.Emp_idLabel1.Location = New System.Drawing.Point(440, 344)
        Me.Emp_idLabel1.Name = "Emp_idLabel1"
        Me.Emp_idLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Emp_idLabel1.TabIndex = 5
        Me.Emp_idLabel1.Text = "Label1"
        '
        'Inf_descriptionLabel1
        '
        Me.Inf_descriptionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InfractionsBindingSource, "inf_description", True))
        Me.Inf_descriptionLabel1.Location = New System.Drawing.Point(440, 367)
        Me.Inf_descriptionLabel1.Name = "Inf_descriptionLabel1"
        Me.Inf_descriptionLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Inf_descriptionLabel1.TabIndex = 7
        Me.Inf_descriptionLabel1.Text = "Label1"
        '
        'Inf_dateLabel1
        '
        Me.Inf_dateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InfractionsBindingSource, "inf_date", True))
        Me.Inf_dateLabel1.Location = New System.Drawing.Point(440, 390)
        Me.Inf_dateLabel1.Name = "Inf_dateLabel1"
        Me.Inf_dateLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Inf_dateLabel1.TabIndex = 9
        Me.Inf_dateLabel1.Text = "Label1"
        '
        'Inf_remarksLabel1
        '
        Me.Inf_remarksLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InfractionsBindingSource, "inf_remarks", True))
        Me.Inf_remarksLabel1.Location = New System.Drawing.Point(440, 413)
        Me.Inf_remarksLabel1.Name = "Inf_remarksLabel1"
        Me.Inf_remarksLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Inf_remarksLabel1.TabIndex = 11
        Me.Inf_remarksLabel1.Text = "Label1"
        '
        'UltraCombo1
        '
        Me.UltraCombo1.DataSource = Me.EmployeeBindingSource
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraCombo1.DisplayLayout.Appearance = Appearance1
        UltraGridColumn59.Header.VisiblePosition = 0
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.Header.VisiblePosition = 1
        UltraGridColumn61.Header.VisiblePosition = 2
        UltraGridColumn62.Header.VisiblePosition = 3
        UltraGridColumn63.Header.VisiblePosition = 4
        UltraGridColumn64.Header.VisiblePosition = 5
        UltraGridColumn65.Header.VisiblePosition = 6
        UltraGridColumn65.Hidden = True
        UltraGridColumn66.Header.VisiblePosition = 7
        UltraGridColumn66.Hidden = True
        UltraGridColumn67.Header.VisiblePosition = 8
        UltraGridColumn68.Header.VisiblePosition = 9
        UltraGridColumn68.Hidden = True
        UltraGridColumn69.Header.VisiblePosition = 10
        UltraGridColumn69.Hidden = True
        UltraGridColumn70.Header.VisiblePosition = 11
        UltraGridColumn70.Hidden = True
        UltraGridColumn71.Header.VisiblePosition = 12
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.Header.VisiblePosition = 13
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.VisiblePosition = 14
        UltraGridColumn73.Hidden = True
        UltraGridColumn74.Header.VisiblePosition = 15
        UltraGridColumn74.Hidden = True
        UltraGridColumn75.Header.VisiblePosition = 16
        UltraGridColumn75.Hidden = True
        UltraGridColumn76.Header.VisiblePosition = 17
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.Header.VisiblePosition = 18
        UltraGridColumn78.Header.VisiblePosition = 19
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78})
        UltraGridColumn79.Header.VisiblePosition = 0
        UltraGridColumn80.Header.VisiblePosition = 1
        UltraGridColumn81.Header.VisiblePosition = 2
        UltraGridColumn82.Header.VisiblePosition = 3
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82})
        UltraGridColumn83.Header.VisiblePosition = 0
        UltraGridColumn84.Header.VisiblePosition = 1
        UltraGridColumn85.Header.VisiblePosition = 2
        UltraGridColumn86.Header.VisiblePosition = 3
        UltraGridColumn87.Header.VisiblePosition = 4
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87})
        Me.UltraCombo1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraCombo1.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UltraCombo1.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.UltraCombo1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraCombo1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraCombo1.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraCombo1.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.UltraCombo1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraCombo1.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.UltraCombo1.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraCombo1.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraCombo1.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraCombo1.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.UltraCombo1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraCombo1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.UltraCombo1.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraCombo1.DisplayLayout.Override.CellAppearance = Appearance8
        Me.UltraCombo1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraCombo1.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraCombo1.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.UltraCombo1.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.UltraCombo1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraCombo1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.UltraCombo1.DisplayLayout.Override.RowAppearance = Appearance11
        Me.UltraCombo1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraCombo1.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.UltraCombo1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraCombo1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraCombo1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraCombo1.DisplayMember = "emp_num"
        Me.UltraCombo1.Location = New System.Drawing.Point(51, 111)
        Me.UltraCombo1.Name = "UltraCombo1"
        Me.UltraCombo1.Size = New System.Drawing.Size(159, 22)
        Me.UltraCombo1.TabIndex = 12
        Me.UltraCombo1.ValueMember = "emp_id"
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.AlnorEmpDataSet
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(51, 159)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 20)
        Me.TextBox1.TabIndex = 13
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(320, 113)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(320, 159)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 20)
        Me.TextBox2.TabIndex = 15
        '
        'InfractionsTableAdapter
        '
        Me.InfractionsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ContractsTableAdapter = Nothing
        Me.TableAdapterManager.DepartmentTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.InfractionsTableAdapter = Me.InfractionsTableAdapter
        Me.TableAdapterManager.UpdateOrder = AlNorProfileRecordSystem.AlnorEmpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'Infractions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(620, 537)
        Me.Controls.Add(Me.InfractionsDataGridView)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.UltraCombo1)
        Me.Controls.Add(Inf_IDLabel)
        Me.Controls.Add(Me.Inf_IDLabel1)
        Me.Controls.Add(Emp_idLabel)
        Me.Controls.Add(Me.Emp_idLabel1)
        Me.Controls.Add(Inf_descriptionLabel)
        Me.Controls.Add(Me.Inf_descriptionLabel1)
        Me.Controls.Add(Inf_dateLabel)
        Me.Controls.Add(Me.Inf_dateLabel1)
        Me.Controls.Add(Inf_remarksLabel)
        Me.Controls.Add(Me.Inf_remarksLabel1)
        Me.Controls.Add(Me.InfractionsBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(636, 576)
        Me.MinimumSize = New System.Drawing.Size(636, 576)
        Me.Name = "Infractions"
        Me.Text = "Infractions"
        CType(Me.InfractionsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InfractionsBindingNavigator.ResumeLayout(False)
        Me.InfractionsBindingNavigator.PerformLayout()
        CType(Me.InfractionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlnorEmpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InfractionsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCombo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AlnorEmpDataSet As AlnorEmpDataSet
    Friend WithEvents InfractionsBindingSource As BindingSource
    Friend WithEvents InfractionsTableAdapter As AlnorEmpDataSetTableAdapters.InfractionsTableAdapter
    Friend WithEvents TableAdapterManager As AlnorEmpDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InfractionsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents InfractionsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents InfractionsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Inf_IDLabel1 As Label
    Friend WithEvents Emp_idLabel1 As Label
    Friend WithEvents Inf_descriptionLabel1 As Label
    Friend WithEvents Inf_dateLabel1 As Label
    Friend WithEvents Inf_remarksLabel1 As Label
    Friend WithEvents EmployeeTableAdapter As AlnorEmpDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents UltraCombo1 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox2 As TextBox
End Class
