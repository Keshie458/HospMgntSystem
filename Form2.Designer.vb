<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Doctorform
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
        Dim DoctorIDLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim DateOfBirthLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim SpecialtyLabel As System.Windows.Forms.Label
        Dim LicenseNumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Doctorform))
        Me.HospitalMgntDataSet = New HOSPITALMNGT.HospitalMgntDataSet()
        Me.DoctorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DoctorsTableAdapter = New HOSPITALMNGT.HospitalMgntDataSetTableAdapters.DoctorsTableAdapter()
        Me.TableAdapterManager2 = New HOSPITALMNGT.HospitalMgntDataSetTableAdapters.TableAdapterManager()
        Me.DoctorsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.DoctorsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DoctorIDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.DateOfBirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.SpecialtyTextBox = New System.Windows.Forms.TextBox()
        Me.LicenseNumberTextBox = New System.Windows.Forms.TextBox()
        Me.DoctorsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnprevious = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnaddnew = New System.Windows.Forms.Button()
        DoctorIDLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        DateOfBirthLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        SpecialtyLabel = New System.Windows.Forms.Label()
        LicenseNumberLabel = New System.Windows.Forms.Label()
        CType(Me.HospitalMgntDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DoctorsBindingNavigator.SuspendLayout()
        CType(Me.DoctorsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DoctorIDLabel
        '
        DoctorIDLabel.AutoSize = True
        DoctorIDLabel.Location = New System.Drawing.Point(121, 90)
        DoctorIDLabel.Name = "DoctorIDLabel"
        DoctorIDLabel.Size = New System.Drawing.Size(66, 16)
        DoctorIDLabel.TabIndex = 1
        DoctorIDLabel.Text = "Doctor ID:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(121, 118)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(75, 16)
        FirstNameLabel.TabIndex = 3
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(121, 146)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(75, 16)
        LastNameLabel.TabIndex = 5
        LastNameLabel.Text = "Last Name:"
        '
        'DateOfBirthLabel
        '
        DateOfBirthLabel.AutoSize = True
        DateOfBirthLabel.Location = New System.Drawing.Point(121, 175)
        DateOfBirthLabel.Name = "DateOfBirthLabel"
        DateOfBirthLabel.Size = New System.Drawing.Size(84, 16)
        DateOfBirthLabel.TabIndex = 7
        DateOfBirthLabel.Text = "Date Of Birth:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(121, 202)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(55, 16)
        GenderLabel.TabIndex = 9
        GenderLabel.Text = "Gender:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(121, 230)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(100, 16)
        PhoneNumberLabel.TabIndex = 11
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(121, 258)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(44, 16)
        EmailLabel.TabIndex = 13
        EmailLabel.Text = "Email:"
        '
        'SpecialtyLabel
        '
        SpecialtyLabel.AutoSize = True
        SpecialtyLabel.Location = New System.Drawing.Point(121, 286)
        SpecialtyLabel.Name = "SpecialtyLabel"
        SpecialtyLabel.Size = New System.Drawing.Size(66, 16)
        SpecialtyLabel.TabIndex = 15
        SpecialtyLabel.Text = "Specialty:"
        '
        'LicenseNumberLabel
        '
        LicenseNumberLabel.AutoSize = True
        LicenseNumberLabel.Location = New System.Drawing.Point(121, 314)
        LicenseNumberLabel.Name = "LicenseNumberLabel"
        LicenseNumberLabel.Size = New System.Drawing.Size(108, 16)
        LicenseNumberLabel.TabIndex = 17
        LicenseNumberLabel.Text = "License Number:"
        '
        'HospitalMgntDataSet
        '
        Me.HospitalMgntDataSet.DataSetName = "HospitalMgntDataSet"
        Me.HospitalMgntDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DoctorsBindingSource
        '
        Me.DoctorsBindingSource.DataMember = "Doctors"
        Me.DoctorsBindingSource.DataSource = Me.HospitalMgntDataSet
        '
        'DoctorsTableAdapter
        '
        Me.DoctorsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.AppointmentsTableAdapter = Nothing
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.DoctorsTableAdapter = Me.DoctorsTableAdapter
        Me.TableAdapterManager2.LoginTableAdapter = Nothing
        Me.TableAdapterManager2.PatientsTableAdapter = Nothing
        Me.TableAdapterManager2.PaymentsTableAdapter = Nothing
        Me.TableAdapterManager2.PharmacyTableAdapter = Nothing
        Me.TableAdapterManager2.UpdateOrder = HOSPITALMNGT.HospitalMgntDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager2.WardsTableAdapter = Nothing
        '
        'DoctorsBindingNavigator
        '
        Me.DoctorsBindingNavigator.AddNewItem = Me.ToolStripButton12
        Me.DoctorsBindingNavigator.BindingSource = Me.DoctorsBindingSource
        Me.DoctorsBindingNavigator.CountItem = Me.ToolStripLabel2
        Me.DoctorsBindingNavigator.DeleteItem = Me.ToolStripButton13
        Me.DoctorsBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DoctorsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton8, Me.ToolStripButton9, Me.ToolStripSeparator4, Me.ToolStripTextBox2, Me.ToolStripLabel2, Me.ToolStripSeparator5, Me.ToolStripButton10, Me.ToolStripButton11, Me.ToolStripSeparator6, Me.ToolStripButton12, Me.ToolStripButton13, Me.DoctorsBindingNavigatorSaveItem})
        Me.DoctorsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DoctorsBindingNavigator.MoveFirstItem = Me.ToolStripButton8
        Me.DoctorsBindingNavigator.MoveLastItem = Me.ToolStripButton11
        Me.DoctorsBindingNavigator.MoveNextItem = Me.ToolStripButton10
        Me.DoctorsBindingNavigator.MovePreviousItem = Me.ToolStripButton9
        Me.DoctorsBindingNavigator.Name = "DoctorsBindingNavigator"
        Me.DoctorsBindingNavigator.PositionItem = Me.ToolStripTextBox2
        Me.DoctorsBindingNavigator.Size = New System.Drawing.Size(1119, 31)
        Me.DoctorsBindingNavigator.TabIndex = 0
        Me.DoctorsBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), System.Drawing.Image)
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton12.Size = New System.Drawing.Size(29, 28)
        Me.ToolStripButton12.Text = "Add new"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(45, 28)
        Me.ToolStripLabel2.Text = "of {0}"
        Me.ToolStripLabel2.ToolTipText = "Total number of items"
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton13.Image = CType(resources.GetObject("ToolStripButton13.Image"), System.Drawing.Image)
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton13.Size = New System.Drawing.Size(29, 28)
        Me.ToolStripButton13.Text = "Delete"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton8.Size = New System.Drawing.Size(29, 28)
        Me.ToolStripButton8.Text = "Move first"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton9.Size = New System.Drawing.Size(29, 28)
        Me.ToolStripButton9.Text = "Move previous"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.AccessibleName = "Position"
        Me.ToolStripTextBox2.AutoSize = False
        Me.ToolStripTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(50, 27)
        Me.ToolStripTextBox2.Text = "0"
        Me.ToolStripTextBox2.ToolTipText = "Current position"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton10.Size = New System.Drawing.Size(29, 28)
        Me.ToolStripButton10.Text = "Move next"
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton11.Size = New System.Drawing.Size(29, 28)
        Me.ToolStripButton11.Text = "Move last"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 31)
        '
        'DoctorsBindingNavigatorSaveItem
        '
        Me.DoctorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DoctorsBindingNavigatorSaveItem.Image = CType(resources.GetObject("DoctorsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DoctorsBindingNavigatorSaveItem.Name = "DoctorsBindingNavigatorSaveItem"
        Me.DoctorsBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.DoctorsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DoctorIDTextBox
        '
        Me.DoctorIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorsBindingSource, "DoctorID", True))
        Me.DoctorIDTextBox.Location = New System.Drawing.Point(235, 87)
        Me.DoctorIDTextBox.Name = "DoctorIDTextBox"
        Me.DoctorIDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.DoctorIDTextBox.TabIndex = 2
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorsBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(235, 115)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.FirstNameTextBox.TabIndex = 4
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorsBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(235, 143)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.LastNameTextBox.TabIndex = 6
        '
        'DateOfBirthDateTimePicker
        '
        Me.DateOfBirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DoctorsBindingSource, "DateOfBirth", True))
        Me.DateOfBirthDateTimePicker.Location = New System.Drawing.Point(235, 171)
        Me.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker"
        Me.DateOfBirthDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.DateOfBirthDateTimePicker.TabIndex = 8
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorsBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(235, 199)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(200, 22)
        Me.GenderTextBox.TabIndex = 10
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorsBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(235, 227)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PhoneNumberTextBox.TabIndex = 12
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorsBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(235, 255)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 22)
        Me.EmailTextBox.TabIndex = 14
        '
        'SpecialtyTextBox
        '
        Me.SpecialtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorsBindingSource, "Specialty", True))
        Me.SpecialtyTextBox.Location = New System.Drawing.Point(235, 283)
        Me.SpecialtyTextBox.Name = "SpecialtyTextBox"
        Me.SpecialtyTextBox.Size = New System.Drawing.Size(200, 22)
        Me.SpecialtyTextBox.TabIndex = 16
        '
        'LicenseNumberTextBox
        '
        Me.LicenseNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorsBindingSource, "LicenseNumber", True))
        Me.LicenseNumberTextBox.Location = New System.Drawing.Point(235, 311)
        Me.LicenseNumberTextBox.Name = "LicenseNumberTextBox"
        Me.LicenseNumberTextBox.Size = New System.Drawing.Size(200, 22)
        Me.LicenseNumberTextBox.TabIndex = 18
        '
        'DoctorsDataGridView
        '
        Me.DoctorsDataGridView.AutoGenerateColumns = False
        Me.DoctorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DoctorsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.DoctorsDataGridView.DataSource = Me.DoctorsBindingSource
        Me.DoctorsDataGridView.Location = New System.Drawing.Point(-12, 352)
        Me.DoctorsDataGridView.Name = "DoctorsDataGridView"
        Me.DoctorsDataGridView.RowHeadersWidth = 51
        Me.DoctorsDataGridView.RowTemplate.Height = 24
        Me.DoctorsDataGridView.Size = New System.Drawing.Size(1119, 213)
        Me.DoctorsDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DoctorID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "DoctorID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DateOfBirth"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DateOfBirth"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PhoneNumber"
        Me.DataGridViewTextBoxColumn6.HeaderText = "PhoneNumber"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Specialty"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Specialty"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "LicenseNumber"
        Me.DataGridViewTextBoxColumn9.HeaderText = "LicenseNumber"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.btnprevious)
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnnext)
        Me.Panel1.Controls.Add(Me.btnaddnew)
        Me.Panel1.Location = New System.Drawing.Point(609, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(448, 258)
        Me.Panel1.TabIndex = 20
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(318, 126)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(107, 45)
        Me.btndelete.TabIndex = 4
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnprevious
        '
        Me.btnprevious.Location = New System.Drawing.Point(318, 32)
        Me.btnprevious.Name = "btnprevious"
        Me.btnprevious.Size = New System.Drawing.Size(107, 58)
        Me.btnprevious.TabIndex = 3
        Me.btnprevious.Text = "Previous"
        Me.btnprevious.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(194, 193)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(100, 54)
        Me.btnclose.TabIndex = 2
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(71, 126)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(123, 37)
        Me.btnnext.TabIndex = 1
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btnaddnew
        '
        Me.btnaddnew.Location = New System.Drawing.Point(61, 32)
        Me.btnaddnew.Name = "btnaddnew"
        Me.btnaddnew.Size = New System.Drawing.Size(133, 47)
        Me.btnaddnew.TabIndex = 0
        Me.btnaddnew.Text = "Add NEW"
        Me.btnaddnew.UseVisualStyleBackColor = True
        '
        'Doctorform
        '
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1119, 798)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DoctorsDataGridView)
        Me.Controls.Add(DoctorIDLabel)
        Me.Controls.Add(Me.DoctorIDTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(DateOfBirthLabel)
        Me.Controls.Add(Me.DateOfBirthDateTimePicker)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(PhoneNumberLabel)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(SpecialtyLabel)
        Me.Controls.Add(Me.SpecialtyTextBox)
        Me.Controls.Add(LicenseNumberLabel)
        Me.Controls.Add(Me.LicenseNumberTextBox)
        Me.Controls.Add(Me.DoctorsBindingNavigator)
        Me.Name = "Doctorform"
        Me.Text = "Doctor"
        CType(Me.HospitalMgntDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DoctorsBindingNavigator.ResumeLayout(False)
        Me.DoctorsBindingNavigator.PerformLayout()
        CType(Me.DoctorsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LOGINSYST1DataSet As LOGINSYST1DataSet
    Friend WithEvents DoctorBindingSource As BindingSource
    Friend WithEvents DoctorTableAdapter As LOGINSYST1DataSetTableAdapters.DoctorTableAdapter
    Friend WithEvents TableAdapterManager As LOGINSYST1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents DoctorBindingNavigator As BindingNavigator
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
    Friend WithEvents DoctorBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents LOGINSYST1DataSet1 As LOGINSYST1DataSet
    Friend WithEvents DoctorBindingSource1 As BindingSource
    Friend WithEvents DoctorTableAdapter1 As LOGINSYST1DataSetTableAdapters.DoctorTableAdapter
    Friend WithEvents TableAdapterManager1 As LOGINSYST1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents DoctorBindingSource1BindingNavigator As BindingNavigator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents DoctorBindingSource1BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents HospitalMgntDataSet As HospitalMgntDataSet
    Friend WithEvents DoctorsBindingSource As BindingSource
    Friend WithEvents DoctorsTableAdapter As HospitalMgntDataSetTableAdapters.DoctorsTableAdapter
    Friend WithEvents TableAdapterManager2 As HospitalMgntDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DoctorsBindingNavigator As BindingNavigator
    Friend WithEvents ToolStripButton12 As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripButton13 As ToolStripButton
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton10 As ToolStripButton
    Friend WithEvents ToolStripButton11 As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents DoctorsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DoctorIDTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents DateOfBirthDateTimePicker As DateTimePicker
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents SpecialtyTextBox As TextBox
    Friend WithEvents LicenseNumberTextBox As TextBox
    Friend WithEvents DoctorsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btndelete As Button
    Friend WithEvents btnprevious As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents btnaddnew As Button
End Class
