<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pharmacyform
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
        Dim MedicineIDLabel As System.Windows.Forms.Label
        Dim MedicineNameLabel As System.Windows.Forms.Label
        Dim ManufacturerLabel As System.Windows.Forms.Label
        Dim ExpiryDateLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pharmacyform))
        Me.HospitalMgntDataSet = New HOSPITALMNGT.HospitalMgntDataSet()
        Me.PharmacyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PharmacyTableAdapter = New HOSPITALMNGT.HospitalMgntDataSetTableAdapters.PharmacyTableAdapter()
        Me.TableAdapterManager = New HOSPITALMNGT.HospitalMgntDataSetTableAdapters.TableAdapterManager()
        Me.PharmacyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PharmacyBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MedicineIDTextBox = New System.Windows.Forms.TextBox()
        Me.MedicineNameTextBox = New System.Windows.Forms.TextBox()
        Me.ManufacturerTextBox = New System.Windows.Forms.TextBox()
        Me.ExpiryDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.PharmacyDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnprevious = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnaddnew = New System.Windows.Forms.Button()
        MedicineIDLabel = New System.Windows.Forms.Label()
        MedicineNameLabel = New System.Windows.Forms.Label()
        ManufacturerLabel = New System.Windows.Forms.Label()
        ExpiryDateLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        CType(Me.HospitalMgntDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmacyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmacyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PharmacyBindingNavigator.SuspendLayout()
        CType(Me.PharmacyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MedicineIDLabel
        '
        MedicineIDLabel.AutoSize = True
        MedicineIDLabel.Location = New System.Drawing.Point(143, 55)
        MedicineIDLabel.Name = "MedicineIDLabel"
        MedicineIDLabel.Size = New System.Drawing.Size(81, 16)
        MedicineIDLabel.TabIndex = 1
        MedicineIDLabel.Text = "Medicine ID:"
        '
        'MedicineNameLabel
        '
        MedicineNameLabel.AutoSize = True
        MedicineNameLabel.Location = New System.Drawing.Point(143, 83)
        MedicineNameLabel.Name = "MedicineNameLabel"
        MedicineNameLabel.Size = New System.Drawing.Size(105, 16)
        MedicineNameLabel.TabIndex = 3
        MedicineNameLabel.Text = "Medicine Name:"
        '
        'ManufacturerLabel
        '
        ManufacturerLabel.AutoSize = True
        ManufacturerLabel.Location = New System.Drawing.Point(143, 111)
        ManufacturerLabel.Name = "ManufacturerLabel"
        ManufacturerLabel.Size = New System.Drawing.Size(87, 16)
        ManufacturerLabel.TabIndex = 5
        ManufacturerLabel.Text = "Manufacturer:"
        '
        'ExpiryDateLabel
        '
        ExpiryDateLabel.AutoSize = True
        ExpiryDateLabel.Location = New System.Drawing.Point(143, 140)
        ExpiryDateLabel.Name = "ExpiryDateLabel"
        ExpiryDateLabel.Size = New System.Drawing.Size(79, 16)
        ExpiryDateLabel.TabIndex = 7
        ExpiryDateLabel.Text = "Expiry Date:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(143, 167)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(41, 16)
        PriceLabel.TabIndex = 9
        PriceLabel.Text = "Price:"
        '
        'HospitalMgntDataSet
        '
        Me.HospitalMgntDataSet.DataSetName = "HospitalMgntDataSet"
        Me.HospitalMgntDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PharmacyBindingSource
        '
        Me.PharmacyBindingSource.DataMember = "Pharmacy"
        Me.PharmacyBindingSource.DataSource = Me.HospitalMgntDataSet
        '
        'PharmacyTableAdapter
        '
        Me.PharmacyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AppointmentsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DoctorsTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.PatientsTableAdapter = Nothing
        Me.TableAdapterManager.PaymentsTableAdapter = Nothing
        Me.TableAdapterManager.PharmacyTableAdapter = Me.PharmacyTableAdapter
        Me.TableAdapterManager.UpdateOrder = HOSPITALMNGT.HospitalMgntDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        '
        'PharmacyBindingNavigator
        '
        Me.PharmacyBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PharmacyBindingNavigator.BindingSource = Me.PharmacyBindingSource
        Me.PharmacyBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PharmacyBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PharmacyBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PharmacyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PharmacyBindingNavigatorSaveItem})
        Me.PharmacyBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PharmacyBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PharmacyBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PharmacyBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PharmacyBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PharmacyBindingNavigator.Name = "PharmacyBindingNavigator"
        Me.PharmacyBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PharmacyBindingNavigator.Size = New System.Drawing.Size(1115, 31)
        Me.PharmacyBindingNavigator.TabIndex = 0
        Me.PharmacyBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'PharmacyBindingNavigatorSaveItem
        '
        Me.PharmacyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PharmacyBindingNavigatorSaveItem.Image = CType(resources.GetObject("PharmacyBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PharmacyBindingNavigatorSaveItem.Name = "PharmacyBindingNavigatorSaveItem"
        Me.PharmacyBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.PharmacyBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MedicineIDTextBox
        '
        Me.MedicineIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "MedicineID", True))
        Me.MedicineIDTextBox.Location = New System.Drawing.Point(254, 52)
        Me.MedicineIDTextBox.Name = "MedicineIDTextBox"
        Me.MedicineIDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.MedicineIDTextBox.TabIndex = 2
        '
        'MedicineNameTextBox
        '
        Me.MedicineNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "MedicineName", True))
        Me.MedicineNameTextBox.Location = New System.Drawing.Point(254, 80)
        Me.MedicineNameTextBox.Name = "MedicineNameTextBox"
        Me.MedicineNameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.MedicineNameTextBox.TabIndex = 4
        '
        'ManufacturerTextBox
        '
        Me.ManufacturerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "Manufacturer", True))
        Me.ManufacturerTextBox.Location = New System.Drawing.Point(254, 108)
        Me.ManufacturerTextBox.Name = "ManufacturerTextBox"
        Me.ManufacturerTextBox.Size = New System.Drawing.Size(200, 22)
        Me.ManufacturerTextBox.TabIndex = 6
        '
        'ExpiryDateDateTimePicker
        '
        Me.ExpiryDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PharmacyBindingSource, "ExpiryDate", True))
        Me.ExpiryDateDateTimePicker.Location = New System.Drawing.Point(254, 136)
        Me.ExpiryDateDateTimePicker.Name = "ExpiryDateDateTimePicker"
        Me.ExpiryDateDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.ExpiryDateDateTimePicker.TabIndex = 8
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "Price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(254, 164)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PriceTextBox.TabIndex = 10
        '
        'PharmacyDataGridView
        '
        Me.PharmacyDataGridView.AutoGenerateColumns = False
        Me.PharmacyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PharmacyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.PharmacyDataGridView.DataSource = Me.PharmacyBindingSource
        Me.PharmacyDataGridView.Location = New System.Drawing.Point(12, 329)
        Me.PharmacyDataGridView.Name = "PharmacyDataGridView"
        Me.PharmacyDataGridView.RowHeadersWidth = 51
        Me.PharmacyDataGridView.RowTemplate.Height = 24
        Me.PharmacyDataGridView.Size = New System.Drawing.Size(675, 220)
        Me.PharmacyDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MedicineID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "MedicineID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MedicineName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "MedicineName"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Manufacturer"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Manufacturer"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ExpiryDate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ExpiryDate"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.btnprevious)
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnnext)
        Me.Panel1.Controls.Add(Me.btnaddnew)
        Me.Panel1.Location = New System.Drawing.Point(572, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(448, 258)
        Me.Panel1.TabIndex = 21
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
        'Pharmacyform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1115, 690)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PharmacyDataGridView)
        Me.Controls.Add(MedicineIDLabel)
        Me.Controls.Add(Me.MedicineIDTextBox)
        Me.Controls.Add(MedicineNameLabel)
        Me.Controls.Add(Me.MedicineNameTextBox)
        Me.Controls.Add(ManufacturerLabel)
        Me.Controls.Add(Me.ManufacturerTextBox)
        Me.Controls.Add(ExpiryDateLabel)
        Me.Controls.Add(Me.ExpiryDateDateTimePicker)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.PharmacyBindingNavigator)
        Me.Name = "Pharmacyform"
        Me.Text = "Pharmacy"
        CType(Me.HospitalMgntDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmacyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmacyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PharmacyBindingNavigator.ResumeLayout(False)
        Me.PharmacyBindingNavigator.PerformLayout()
        CType(Me.PharmacyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HospitalMgntDataSet As HospitalMgntDataSet
    Friend WithEvents PharmacyBindingSource As BindingSource
    Friend WithEvents PharmacyTableAdapter As HospitalMgntDataSetTableAdapters.PharmacyTableAdapter
    Friend WithEvents TableAdapterManager As HospitalMgntDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PharmacyBindingNavigator As BindingNavigator
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
    Friend WithEvents PharmacyBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MedicineIDTextBox As TextBox
    Friend WithEvents MedicineNameTextBox As TextBox
    Friend WithEvents ManufacturerTextBox As TextBox
    Friend WithEvents ExpiryDateDateTimePicker As DateTimePicker
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents PharmacyDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btndelete As Button
    Friend WithEvents btnprevious As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents btnaddnew As Button
End Class
