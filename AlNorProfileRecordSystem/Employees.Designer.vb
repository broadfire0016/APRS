<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Employees
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Emp_numLabel As System.Windows.Forms.Label
        Dim Emp_lnameLabel As System.Windows.Forms.Label
        Dim Emp_fnameLabel As System.Windows.Forms.Label
        Dim Emp_mnameLabel As System.Windows.Forms.Label
        Dim Emp_positionLabel As System.Windows.Forms.Label
        Dim Dept_idLabel As System.Windows.Forms.Label
        Dim Emp_addressLabel As System.Windows.Forms.Label
        Dim Emp_genderLabel As System.Windows.Forms.Label
        Dim Emp_bdayLabel As System.Windows.Forms.Label
        Dim Emp_religionLabel As System.Windows.Forms.Label
        Dim Emp_educLabel As System.Windows.Forms.Label
        Dim Emp_mobileLabel As System.Windows.Forms.Label
        Dim Emp_sssLabel As System.Windows.Forms.Label
        Dim Emp_phealthLabel As System.Windows.Forms.Label
        Dim Emp_tinLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employees))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Employee", -1)
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_id")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_num")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_lname")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_fname")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_mname")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_position")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("dept_id")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_address")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_gender")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_bday")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_religion")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_educ")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_mobile")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_sss")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_phealth")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_pagibig")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_tin")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_photo")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_resign")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EmployeeContracts")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EmployeeInfractions")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("EmployeeContracts", 0)
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("con_ID")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_id")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("con_starts")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("con_ends")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("EmployeeInfractions", 0)
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("inf_ID")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("emp_id")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("inf_description")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("inf_date")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("inf_remarks")
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
        Dim Emp_pagibigLabel As System.Windows.Forms.Label
        Me.AlnorEmpDataSet = New AlNorProfileRecordSystem.AlnorEmpDataSet()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New AlNorProfileRecordSystem.AlnorEmpDataSetTableAdapters.EmployeeTableAdapter()
        Me.TableAdapterManager = New AlNorProfileRecordSystem.AlnorEmpDataSetTableAdapters.TableAdapterManager()
        Me.EmployeeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.EmployeeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Emp_numTextBox = New System.Windows.Forms.TextBox()
        Me.Emp_lnameTextBox = New System.Windows.Forms.TextBox()
        Me.Emp_fnameTextBox = New System.Windows.Forms.TextBox()
        Me.Emp_mnameTextBox = New System.Windows.Forms.TextBox()
        Me.Emp_positionTextBox = New System.Windows.Forms.TextBox()
        Me.Emp_addressTextBox = New System.Windows.Forms.TextBox()
        Me.Emp_religionTextBox = New System.Windows.Forms.TextBox()
        Me.Emp_educTextBox = New System.Windows.Forms.TextBox()
        Me.Emp_mobileTextBox = New System.Windows.Forms.TextBox()
        Me.Emp_sssTextBox = New System.Windows.Forms.TextBox()
        Me.Emp_phealthTextBox = New System.Windows.Forms.TextBox()
        Me.Emp_tinTextBox = New System.Windows.Forms.TextBox()
        Me.Emp_resignCheckBox = New System.Windows.Forms.CheckBox()
        Me.Emp_genderComboBox = New System.Windows.Forms.ComboBox()
        Me.Emp_bdayDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Emp_photoPictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dept_idLabel1 = New System.Windows.Forms.Label()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.DepartmentTableAdapter = New AlNorProfileRecordSystem.AlnorEmpDataSetTableAdapters.DepartmentTableAdapter()
        Me.Emp_bdayLabel2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton()
        Me.UltraCombo1 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Emp_idLabel1 = New System.Windows.Forms.Label()
        Me.Emp_pagibigTextBox = New System.Windows.Forms.TextBox()
        Emp_numLabel = New System.Windows.Forms.Label()
        Emp_lnameLabel = New System.Windows.Forms.Label()
        Emp_fnameLabel = New System.Windows.Forms.Label()
        Emp_mnameLabel = New System.Windows.Forms.Label()
        Emp_positionLabel = New System.Windows.Forms.Label()
        Dept_idLabel = New System.Windows.Forms.Label()
        Emp_addressLabel = New System.Windows.Forms.Label()
        Emp_genderLabel = New System.Windows.Forms.Label()
        Emp_bdayLabel = New System.Windows.Forms.Label()
        Emp_religionLabel = New System.Windows.Forms.Label()
        Emp_educLabel = New System.Windows.Forms.Label()
        Emp_mobileLabel = New System.Windows.Forms.Label()
        Emp_sssLabel = New System.Windows.Forms.Label()
        Emp_phealthLabel = New System.Windows.Forms.Label()
        Emp_tinLabel = New System.Windows.Forms.Label()
        Emp_pagibigLabel = New System.Windows.Forms.Label()
        CType(Me.AlnorEmpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmployeeBindingNavigator.SuspendLayout()
        CType(Me.Emp_photoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.UltraCombo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Emp_numLabel
        '
        Emp_numLabel.AutoSize = True
        Emp_numLabel.Location = New System.Drawing.Point(9, 25)
        Emp_numLabel.Name = "Emp_numLabel"
        Emp_numLabel.Size = New System.Drawing.Size(96, 13)
        Emp_numLabel.TabIndex = 3
        Emp_numLabel.Text = "Employee Number:"
        '
        'Emp_lnameLabel
        '
        Emp_lnameLabel.AutoSize = True
        Emp_lnameLabel.Location = New System.Drawing.Point(9, 65)
        Emp_lnameLabel.Name = "Emp_lnameLabel"
        Emp_lnameLabel.Size = New System.Drawing.Size(56, 13)
        Emp_lnameLabel.TabIndex = 5
        Emp_lnameLabel.Text = "Lastname:"
        '
        'Emp_fnameLabel
        '
        Emp_fnameLabel.AutoSize = True
        Emp_fnameLabel.Location = New System.Drawing.Point(133, 65)
        Emp_fnameLabel.Name = "Emp_fnameLabel"
        Emp_fnameLabel.Size = New System.Drawing.Size(55, 13)
        Emp_fnameLabel.TabIndex = 7
        Emp_fnameLabel.Text = "Firstname:"
        '
        'Emp_mnameLabel
        '
        Emp_mnameLabel.AutoSize = True
        Emp_mnameLabel.Location = New System.Drawing.Point(298, 65)
        Emp_mnameLabel.Name = "Emp_mnameLabel"
        Emp_mnameLabel.Size = New System.Drawing.Size(67, 13)
        Emp_mnameLabel.TabIndex = 9
        Emp_mnameLabel.Text = "Middlename:"
        '
        'Emp_positionLabel
        '
        Emp_positionLabel.AutoSize = True
        Emp_positionLabel.Location = New System.Drawing.Point(9, 105)
        Emp_positionLabel.Name = "Emp_positionLabel"
        Emp_positionLabel.Size = New System.Drawing.Size(47, 13)
        Emp_positionLabel.TabIndex = 11
        Emp_positionLabel.Text = "Position:"
        '
        'Dept_idLabel
        '
        Dept_idLabel.AutoSize = True
        Dept_idLabel.Location = New System.Drawing.Point(133, 105)
        Dept_idLabel.Name = "Dept_idLabel"
        Dept_idLabel.Size = New System.Drawing.Size(65, 13)
        Dept_idLabel.TabIndex = 13
        Dept_idLabel.Text = "Department:"
        '
        'Emp_addressLabel
        '
        Emp_addressLabel.AutoSize = True
        Emp_addressLabel.Location = New System.Drawing.Point(9, 149)
        Emp_addressLabel.Name = "Emp_addressLabel"
        Emp_addressLabel.Size = New System.Drawing.Size(48, 13)
        Emp_addressLabel.TabIndex = 15
        Emp_addressLabel.Text = "Address:"
        '
        'Emp_genderLabel
        '
        Emp_genderLabel.AutoSize = True
        Emp_genderLabel.Location = New System.Drawing.Point(298, 105)
        Emp_genderLabel.Name = "Emp_genderLabel"
        Emp_genderLabel.Size = New System.Drawing.Size(45, 13)
        Emp_genderLabel.TabIndex = 17
        Emp_genderLabel.Text = "Gender:"
        '
        'Emp_bdayLabel
        '
        Emp_bdayLabel.AutoSize = True
        Emp_bdayLabel.Location = New System.Drawing.Point(6, 192)
        Emp_bdayLabel.Name = "Emp_bdayLabel"
        Emp_bdayLabel.Size = New System.Drawing.Size(48, 13)
        Emp_bdayLabel.TabIndex = 19
        Emp_bdayLabel.Text = "Birthday:"
        '
        'Emp_religionLabel
        '
        Emp_religionLabel.AutoSize = True
        Emp_religionLabel.Location = New System.Drawing.Point(259, 192)
        Emp_religionLabel.Name = "Emp_religionLabel"
        Emp_religionLabel.Size = New System.Drawing.Size(48, 13)
        Emp_religionLabel.TabIndex = 21
        Emp_religionLabel.Text = "Religion:"
        '
        'Emp_educLabel
        '
        Emp_educLabel.AutoSize = True
        Emp_educLabel.Location = New System.Drawing.Point(6, 237)
        Emp_educLabel.Name = "Emp_educLabel"
        Emp_educLabel.Size = New System.Drawing.Size(127, 13)
        Emp_educLabel.TabIndex = 23
        Emp_educLabel.Text = "Educational Background:"
        '
        'Emp_mobileLabel
        '
        Emp_mobileLabel.AutoSize = True
        Emp_mobileLabel.Location = New System.Drawing.Point(259, 237)
        Emp_mobileLabel.Name = "Emp_mobileLabel"
        Emp_mobileLabel.Size = New System.Drawing.Size(87, 13)
        Emp_mobileLabel.TabIndex = 25
        Emp_mobileLabel.Text = "Contact Number:"
        '
        'Emp_sssLabel
        '
        Emp_sssLabel.AutoSize = True
        Emp_sssLabel.Location = New System.Drawing.Point(9, 281)
        Emp_sssLabel.Name = "Emp_sssLabel"
        Emp_sssLabel.Size = New System.Drawing.Size(31, 13)
        Emp_sssLabel.TabIndex = 27
        Emp_sssLabel.Text = "SSS:"
        '
        'Emp_phealthLabel
        '
        Emp_phealthLabel.AutoSize = True
        Emp_phealthLabel.Location = New System.Drawing.Point(131, 281)
        Emp_phealthLabel.Name = "Emp_phealthLabel"
        Emp_phealthLabel.Size = New System.Drawing.Size(56, 13)
        Emp_phealthLabel.TabIndex = 29
        Emp_phealthLabel.Text = "Philhealth:"
        '
        'Emp_tinLabel
        '
        Emp_tinLabel.AutoSize = True
        Emp_tinLabel.Location = New System.Drawing.Point(262, 281)
        Emp_tinLabel.Name = "Emp_tinLabel"
        Emp_tinLabel.Size = New System.Drawing.Size(28, 13)
        Emp_tinLabel.TabIndex = 31
        Emp_tinLabel.Text = "TIN:"
        '
        'AlnorEmpDataSet
        '
        Me.AlnorEmpDataSet.DataSetName = "AlnorEmpDataSet"
        Me.AlnorEmpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.AlnorEmpDataSet
        Me.EmployeeBindingSource.Sort = "emp_id"
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ContractsTableAdapter = Nothing
        Me.TableAdapterManager.DepartmentTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.InfractionsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AlNorProfileRecordSystem.AlnorEmpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmployeeBindingNavigator
        '
        Me.EmployeeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmployeeBindingNavigator.BindingSource = Me.EmployeeBindingSource
        Me.EmployeeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmployeeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmployeeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmployeeBindingNavigatorSaveItem})
        Me.EmployeeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmployeeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmployeeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmployeeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmployeeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmployeeBindingNavigator.Name = "EmployeeBindingNavigator"
        Me.EmployeeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmployeeBindingNavigator.Size = New System.Drawing.Size(604, 25)
        Me.EmployeeBindingNavigator.TabIndex = 0
        Me.EmployeeBindingNavigator.Text = "BindingNavigator1"
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
        'EmployeeBindingNavigatorSaveItem
        '
        Me.EmployeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmployeeBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmployeeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmployeeBindingNavigatorSaveItem.Name = "EmployeeBindingNavigatorSaveItem"
        Me.EmployeeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmployeeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Emp_numTextBox
        '
        Me.Emp_numTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "emp_num", True))
        Me.Emp_numTextBox.Location = New System.Drawing.Point(9, 41)
        Me.Emp_numTextBox.Name = "Emp_numTextBox"
        Me.Emp_numTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Emp_numTextBox.TabIndex = 4
        '
        'Emp_lnameTextBox
        '
        Me.Emp_lnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "emp_lname", True))
        Me.Emp_lnameTextBox.Location = New System.Drawing.Point(9, 81)
        Me.Emp_lnameTextBox.Name = "Emp_lnameTextBox"
        Me.Emp_lnameTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Emp_lnameTextBox.TabIndex = 6
        '
        'Emp_fnameTextBox
        '
        Me.Emp_fnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "emp_fname", True))
        Me.Emp_fnameTextBox.Location = New System.Drawing.Point(134, 81)
        Me.Emp_fnameTextBox.Name = "Emp_fnameTextBox"
        Me.Emp_fnameTextBox.Size = New System.Drawing.Size(141, 20)
        Me.Emp_fnameTextBox.TabIndex = 8
        '
        'Emp_mnameTextBox
        '
        Me.Emp_mnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "emp_mname", True))
        Me.Emp_mnameTextBox.Location = New System.Drawing.Point(301, 81)
        Me.Emp_mnameTextBox.Name = "Emp_mnameTextBox"
        Me.Emp_mnameTextBox.Size = New System.Drawing.Size(138, 20)
        Me.Emp_mnameTextBox.TabIndex = 10
        '
        'Emp_positionTextBox
        '
        Me.Emp_positionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "emp_position", True))
        Me.Emp_positionTextBox.Location = New System.Drawing.Point(9, 125)
        Me.Emp_positionTextBox.Name = "Emp_positionTextBox"
        Me.Emp_positionTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Emp_positionTextBox.TabIndex = 12
        '
        'Emp_addressTextBox
        '
        Me.Emp_addressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "emp_address", True))
        Me.Emp_addressTextBox.Location = New System.Drawing.Point(9, 165)
        Me.Emp_addressTextBox.Name = "Emp_addressTextBox"
        Me.Emp_addressTextBox.Size = New System.Drawing.Size(430, 20)
        Me.Emp_addressTextBox.TabIndex = 16
        '
        'Emp_religionTextBox
        '
        Me.Emp_religionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "emp_religion", True))
        Me.Emp_religionTextBox.Location = New System.Drawing.Point(262, 210)
        Me.Emp_religionTextBox.Name = "Emp_religionTextBox"
        Me.Emp_religionTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Emp_religionTextBox.TabIndex = 22
        '
        'Emp_educTextBox
        '
        Me.Emp_educTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "emp_educ", True))
        Me.Emp_educTextBox.Location = New System.Drawing.Point(9, 253)
        Me.Emp_educTextBox.Name = "Emp_educTextBox"
        Me.Emp_educTextBox.Size = New System.Drawing.Size(204, 20)
        Me.Emp_educTextBox.TabIndex = 24
        '
        'Emp_mobileTextBox
        '
        Me.Emp_mobileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "emp_mobile", True))
        Me.Emp_mobileTextBox.Location = New System.Drawing.Point(262, 253)
        Me.Emp_mobileTextBox.Name = "Emp_mobileTextBox"
        Me.Emp_mobileTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Emp_mobileTextBox.TabIndex = 26
        '
        'Emp_sssTextBox
        '
        Me.Emp_sssTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "emp_sss", True))
        Me.Emp_sssTextBox.Location = New System.Drawing.Point(9, 297)
        Me.Emp_sssTextBox.Name = "Emp_sssTextBox"
        Me.Emp_sssTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Emp_sssTextBox.TabIndex = 28
        '
        'Emp_phealthTextBox
        '
        Me.Emp_phealthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "emp_phealth", True))
        Me.Emp_phealthTextBox.Location = New System.Drawing.Point(134, 297)
        Me.Emp_phealthTextBox.Name = "Emp_phealthTextBox"
        Me.Emp_phealthTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Emp_phealthTextBox.TabIndex = 30
        '
        'Emp_tinTextBox
        '
        Me.Emp_tinTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "emp_tin", True))
        Me.Emp_tinTextBox.Location = New System.Drawing.Point(262, 297)
        Me.Emp_tinTextBox.Name = "Emp_tinTextBox"
        Me.Emp_tinTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Emp_tinTextBox.TabIndex = 32
        '
        'Emp_resignCheckBox
        '
        Me.Emp_resignCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EmployeeBindingSource, "emp_resign", True))
        Me.Emp_resignCheckBox.Location = New System.Drawing.Point(9, 327)
        Me.Emp_resignCheckBox.Name = "Emp_resignCheckBox"
        Me.Emp_resignCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Emp_resignCheckBox.TabIndex = 36
        Me.Emp_resignCheckBox.Text = "Resigned?"
        Me.Emp_resignCheckBox.UseVisualStyleBackColor = True
        '
        'Emp_genderComboBox
        '
        Me.Emp_genderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "emp_gender", True))
        Me.Emp_genderComboBox.FormattingEnabled = True
        Me.Emp_genderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.Emp_genderComboBox.Location = New System.Drawing.Point(301, 125)
        Me.Emp_genderComboBox.Name = "Emp_genderComboBox"
        Me.Emp_genderComboBox.Size = New System.Drawing.Size(138, 21)
        Me.Emp_genderComboBox.TabIndex = 37
        '
        'Emp_bdayDateTimePicker
        '
        Me.Emp_bdayDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeBindingSource, "emp_bday", True))
        Me.Emp_bdayDateTimePicker.Location = New System.Drawing.Point(9, 210)
        Me.Emp_bdayDateTimePicker.Name = "Emp_bdayDateTimePicker"
        Me.Emp_bdayDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Emp_bdayDateTimePicker.TabIndex = 38
        '
        'Emp_photoPictureBox
        '
        Me.Emp_photoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Emp_photoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.EmployeeBindingSource, "emp_photo", True))
        Me.Emp_photoPictureBox.Location = New System.Drawing.Point(392, 75)
        Me.Emp_photoPictureBox.Name = "Emp_photoPictureBox"
        Me.Emp_photoPictureBox.Size = New System.Drawing.Size(140, 136)
        Me.Emp_photoPictureBox.TabIndex = 39
        Me.Emp_photoPictureBox.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Emp_pagibigLabel)
        Me.GroupBox1.Controls.Add(Me.Emp_pagibigTextBox)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Emp_tinTextBox)
        Me.GroupBox1.Controls.Add(Me.Emp_resignCheckBox)
        Me.GroupBox1.Controls.Add(Me.Emp_bdayDateTimePicker)
        Me.GroupBox1.Controls.Add(Emp_tinLabel)
        Me.GroupBox1.Controls.Add(Me.Emp_genderComboBox)
        Me.GroupBox1.Controls.Add(Me.Emp_phealthTextBox)
        Me.GroupBox1.Controls.Add(Emp_numLabel)
        Me.GroupBox1.Controls.Add(Emp_phealthLabel)
        Me.GroupBox1.Controls.Add(Me.Emp_numTextBox)
        Me.GroupBox1.Controls.Add(Me.Emp_sssTextBox)
        Me.GroupBox1.Controls.Add(Emp_lnameLabel)
        Me.GroupBox1.Controls.Add(Emp_sssLabel)
        Me.GroupBox1.Controls.Add(Me.Emp_lnameTextBox)
        Me.GroupBox1.Controls.Add(Me.Emp_mobileTextBox)
        Me.GroupBox1.Controls.Add(Emp_fnameLabel)
        Me.GroupBox1.Controls.Add(Emp_mobileLabel)
        Me.GroupBox1.Controls.Add(Me.Emp_fnameTextBox)
        Me.GroupBox1.Controls.Add(Me.Emp_educTextBox)
        Me.GroupBox1.Controls.Add(Emp_mnameLabel)
        Me.GroupBox1.Controls.Add(Emp_educLabel)
        Me.GroupBox1.Controls.Add(Me.Emp_mnameTextBox)
        Me.GroupBox1.Controls.Add(Me.Emp_religionTextBox)
        Me.GroupBox1.Controls.Add(Emp_positionLabel)
        Me.GroupBox1.Controls.Add(Emp_religionLabel)
        Me.GroupBox1.Controls.Add(Me.Emp_positionTextBox)
        Me.GroupBox1.Controls.Add(Emp_bdayLabel)
        Me.GroupBox1.Controls.Add(Dept_idLabel)
        Me.GroupBox1.Controls.Add(Emp_genderLabel)
        Me.GroupBox1.Controls.Add(Me.Emp_addressTextBox)
        Me.GroupBox1.Controls.Add(Emp_addressLabel)
        Me.GroupBox1.Controls.Add(Me.Dept_idLabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 217)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(559, 371)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DepartmentBindingSource
        Me.ComboBox1.DisplayMember = "dept_name"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(134, 125)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(141, 21)
        Me.ComboBox1.TabIndex = 39
        Me.ComboBox1.ValueMember = "dept_id"
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.AlnorEmpDataSet
        '
        'Dept_idLabel1
        '
        Me.Dept_idLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "dept_id", True))
        Me.Dept_idLabel1.Location = New System.Drawing.Point(133, 123)
        Me.Dept_idLabel1.Name = "Dept_idLabel1"
        Me.Dept_idLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Dept_idLabel1.TabIndex = 40
        Me.Dept_idLabel1.Text = "Label1"
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(291, 111)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(75, 63)
        Me.UltraButton1.TabIndex = 41
        Me.UltraButton1.Text = "Browse"
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'Emp_bdayLabel2
        '
        Me.Emp_bdayLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "emp_bday", True))
        Me.Emp_bdayLabel2.Location = New System.Drawing.Point(183, 231)
        Me.Emp_bdayLabel2.Name = "Emp_bdayLabel2"
        Me.Emp_bdayLabel2.Size = New System.Drawing.Size(100, 23)
        Me.Emp_bdayLabel2.TabIndex = 42
        Me.Emp_bdayLabel2.Text = "Label1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.UltraButton2)
        Me.GroupBox2.Controls.Add(Me.UltraCombo1)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 117)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search"
        '
        'UltraButton2
        '
        Me.UltraButton2.Location = New System.Drawing.Point(13, 75)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(75, 23)
        Me.UltraButton2.TabIndex = 44
        Me.UltraButton2.Text = "Reset"
        '
        'UltraCombo1
        '
        Me.UltraCombo1.DataSource = Me.BindingSource1
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraCombo1.DisplayLayout.Appearance = Appearance1
        UltraGridColumn30.Header.VisiblePosition = 0
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.Caption = "Employee Number"
        UltraGridColumn31.Header.VisiblePosition = 1
        UltraGridColumn32.Header.Caption = "Surname"
        UltraGridColumn32.Header.VisiblePosition = 2
        UltraGridColumn33.Header.Caption = "Firstname"
        UltraGridColumn33.Header.VisiblePosition = 3
        UltraGridColumn34.Header.Caption = "Middlename"
        UltraGridColumn34.Header.VisiblePosition = 4
        UltraGridColumn35.Header.Caption = "Position"
        UltraGridColumn35.Header.VisiblePosition = 5
        UltraGridColumn36.Header.VisiblePosition = 6
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.VisiblePosition = 7
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.VisiblePosition = 8
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.VisiblePosition = 9
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.Header.VisiblePosition = 10
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.Header.VisiblePosition = 11
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.Header.VisiblePosition = 12
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.Header.VisiblePosition = 13
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.Header.VisiblePosition = 14
        UltraGridColumn44.Hidden = True
        UltraGridColumn1.Header.VisiblePosition = 15
        UltraGridColumn45.Header.VisiblePosition = 16
        UltraGridColumn45.Hidden = True
        UltraGridColumn46.Header.VisiblePosition = 17
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.Header.VisiblePosition = 18
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.Header.VisiblePosition = 19
        UltraGridColumn49.Header.VisiblePosition = 20
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn1, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49})
        UltraGridColumn50.Header.VisiblePosition = 0
        UltraGridColumn51.Header.VisiblePosition = 1
        UltraGridColumn52.Header.VisiblePosition = 2
        UltraGridColumn53.Header.VisiblePosition = 3
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53})
        UltraGridColumn54.Header.VisiblePosition = 0
        UltraGridColumn55.Header.VisiblePosition = 1
        UltraGridColumn56.Header.VisiblePosition = 2
        UltraGridColumn57.Header.VisiblePosition = 3
        UltraGridColumn58.Header.VisiblePosition = 4
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58})
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
        Me.UltraCombo1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2013
        Me.UltraCombo1.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.UltraCombo1.Location = New System.Drawing.Point(13, 47)
        Me.UltraCombo1.Name = "UltraCombo1"
        Me.UltraCombo1.Size = New System.Drawing.Size(174, 22)
        Me.UltraCombo1.TabIndex = 0
        Me.UltraCombo1.ValueMember = "emp_id"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Employee"
        Me.BindingSource1.DataSource = Me.AlnorEmpDataSet
        Me.BindingSource1.Sort = "emp_id"
        '
        'Emp_idLabel1
        '
        Me.Emp_idLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "emp_id", True))
        Me.Emp_idLabel1.Location = New System.Drawing.Point(159, 227)
        Me.Emp_idLabel1.Name = "Emp_idLabel1"
        Me.Emp_idLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Emp_idLabel1.TabIndex = 44
        Me.Emp_idLabel1.Text = "Label1"
        '
        'Emp_pagibigLabel
        '
        Emp_pagibigLabel.AutoSize = True
        Emp_pagibigLabel.Location = New System.Drawing.Point(394, 281)
        Emp_pagibigLabel.Name = "Emp_pagibigLabel"
        Emp_pagibigLabel.Size = New System.Drawing.Size(56, 13)
        Emp_pagibigLabel.TabIndex = 40
        Emp_pagibigLabel.Text = "PAG-IBIG:"
        '
        'Emp_pagibigTextBox
        '
        Me.Emp_pagibigTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "emp_pagibig", True))
        Me.Emp_pagibigTextBox.Location = New System.Drawing.Point(397, 297)
        Me.Emp_pagibigTextBox.Name = "Emp_pagibigTextBox"
        Me.Emp_pagibigTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Emp_pagibigTextBox.TabIndex = 41
        '
        'Employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(604, 608)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.Emp_photoPictureBox)
        Me.Controls.Add(Me.EmployeeBindingNavigator)
        Me.Controls.Add(Me.Emp_bdayLabel2)
        Me.Controls.Add(Me.Emp_idLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(620, 647)
        Me.MinimumSize = New System.Drawing.Size(620, 647)
        Me.Name = "Employees"
        Me.Text = "Employees"
        CType(Me.AlnorEmpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmployeeBindingNavigator.ResumeLayout(False)
        Me.EmployeeBindingNavigator.PerformLayout()
        CType(Me.Emp_photoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.UltraCombo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AlnorEmpDataSet As AlnorEmpDataSet
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As AlnorEmpDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents TableAdapterManager As AlnorEmpDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmployeeBindingNavigator As BindingNavigator
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
    Friend WithEvents EmployeeBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Emp_numTextBox As TextBox
    Friend WithEvents Emp_lnameTextBox As TextBox
    Friend WithEvents Emp_fnameTextBox As TextBox
    Friend WithEvents Emp_mnameTextBox As TextBox
    Friend WithEvents Emp_positionTextBox As TextBox
    Friend WithEvents Emp_addressTextBox As TextBox
    Friend WithEvents Emp_religionTextBox As TextBox
    Friend WithEvents Emp_educTextBox As TextBox
    Friend WithEvents Emp_mobileTextBox As TextBox
    Friend WithEvents Emp_sssTextBox As TextBox
    Friend WithEvents Emp_phealthTextBox As TextBox
    Friend WithEvents Emp_tinTextBox As TextBox
    Friend WithEvents Emp_resignCheckBox As CheckBox
    Friend WithEvents Emp_genderComboBox As ComboBox
    Friend WithEvents Emp_bdayDateTimePicker As DateTimePicker
    Friend WithEvents Emp_photoPictureBox As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DepartmentBindingSource As BindingSource
    Friend WithEvents DepartmentTableAdapter As AlnorEmpDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents Dept_idLabel1 As Label
    Friend WithEvents Emp_bdayLabel2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraCombo1 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Emp_idLabel1 As Label
    Friend WithEvents Emp_pagibigTextBox As TextBox
End Class
