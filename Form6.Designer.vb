<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Wardform
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
        Dim WardIDLabel As System.Windows.Forms.Label
        Dim WardNameLabel As System.Windows.Forms.Label
        Dim CapacityLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Wardform))
        Me.HospitalMgntDataSet = New HOSPITALMNGT.HospitalMgntDataSet()
        Me.WardsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WardsTableAdapter = New HOSPITALMNGT.HospitalMgntDataSetTableAdapters.WardsTableAdapter()
        Me.TableAdapterManager = New HOSPITALMNGT.HospitalMgntDataSetTableAdapters.TableAdapterManager()
        Me.WardsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.WardsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.WardIDTextBox = New System.Windows.Forms.TextBox()
        Me.WardNameTextBox = New System.Windows.Forms.TextBox()
        Me.CapacityTextBox = New System.Windows.Forms.TextBox()
        Me.WardsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnprevious = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnaddnew = New System.Windows.Forms.Button()
        WardIDLabel = New System.Windows.Forms.Label()
        WardNameLabel = New System.Windows.Forms.Label()
        CapacityLabel = New System.Windows.Forms.Label()
        CType(Me.HospitalMgntDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WardsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WardsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WardsBindingNavigator.SuspendLayout()
        CType(Me.WardsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WardIDLabel
        '
        WardIDLabel.AutoSize = True
        WardIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WardIDLabel.Location = New System.Drawing.Point(57, 66)
        WardIDLabel.Name = "WardIDLabel"
        WardIDLabel.Size = New System.Drawing.Size(74, 18)
        WardIDLabel.TabIndex = 1
        WardIDLabel.Text = "Ward ID:"
        '
        'WardNameLabel
        '
        WardNameLabel.AutoSize = True
        WardNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WardNameLabel.Location = New System.Drawing.Point(53, 95)
        WardNameLabel.Name = "WardNameLabel"
        WardNameLabel.Size = New System.Drawing.Size(102, 18)
        WardNameLabel.TabIndex = 3
        WardNameLabel.Text = "Ward Name:"
        '
        'CapacityLabel
        '
        CapacityLabel.AutoSize = True
        CapacityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CapacityLabel.Location = New System.Drawing.Point(53, 123)
        CapacityLabel.Name = "CapacityLabel"
        CapacityLabel.Size = New System.Drawing.Size(78, 18)
        CapacityLabel.TabIndex = 5
        CapacityLabel.Text = "Capacity:"
        '
        'HospitalMgntDataSet
        '
        Me.HospitalMgntDataSet.DataSetName = "HospitalMgntDataSet"
        Me.HospitalMgntDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WardsBindingSource
        '
        Me.WardsBindingSource.DataMember = "Wards"
        Me.WardsBindingSource.DataSource = Me.HospitalMgntDataSet
        '
        'WardsTableAdapter
        '
        Me.WardsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AppointmentsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DoctorsTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.PatientsTableAdapter = Nothing
        Me.TableAdapterManager.PaymentsTableAdapter = Nothing
        Me.TableAdapterManager.PharmacyTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = HOSPITALMNGT.HospitalMgntDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WardsTableAdapter = Me.WardsTableAdapter
        '
        'WardsBindingNavigator
        '
        Me.WardsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.WardsBindingNavigator.BindingSource = Me.WardsBindingSource
        Me.WardsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.WardsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.WardsBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.WardsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.WardsBindingNavigatorSaveItem})
        Me.WardsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.WardsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.WardsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.WardsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.WardsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.WardsBindingNavigator.Name = "WardsBindingNavigator"
        Me.WardsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.WardsBindingNavigator.Size = New System.Drawing.Size(1043, 31)
        Me.WardsBindingNavigator.TabIndex = 0
        Me.WardsBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'WardsBindingNavigatorSaveItem
        '
        Me.WardsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.WardsBindingNavigatorSaveItem.Image = CType(resources.GetObject("WardsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.WardsBindingNavigatorSaveItem.Name = "WardsBindingNavigatorSaveItem"
        Me.WardsBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.WardsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'WardIDTextBox
        '
        Me.WardIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "WardID", True))
        Me.WardIDTextBox.Location = New System.Drawing.Point(198, 66)
        Me.WardIDTextBox.Name = "WardIDTextBox"
        Me.WardIDTextBox.Size = New System.Drawing.Size(130, 22)
        Me.WardIDTextBox.TabIndex = 2
        '
        'WardNameTextBox
        '
        Me.WardNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "WardName", True))
        Me.WardNameTextBox.Location = New System.Drawing.Point(198, 94)
        Me.WardNameTextBox.Name = "WardNameTextBox"
        Me.WardNameTextBox.Size = New System.Drawing.Size(130, 22)
        Me.WardNameTextBox.TabIndex = 4
        '
        'CapacityTextBox
        '
        Me.CapacityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "Capacity", True))
        Me.CapacityTextBox.Location = New System.Drawing.Point(198, 122)
        Me.CapacityTextBox.Name = "CapacityTextBox"
        Me.CapacityTextBox.Size = New System.Drawing.Size(130, 22)
        Me.CapacityTextBox.TabIndex = 6
        '
        'WardsDataGridView
        '
        Me.WardsDataGridView.AutoGenerateColumns = False
        Me.WardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WardsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.WardsDataGridView.DataSource = Me.WardsBindingSource
        Me.WardsDataGridView.Location = New System.Drawing.Point(37, 245)
        Me.WardsDataGridView.Name = "WardsDataGridView"
        Me.WardsDataGridView.RowHeadersWidth = 51
        Me.WardsDataGridView.RowTemplate.Height = 24
        Me.WardsDataGridView.Size = New System.Drawing.Size(408, 220)
        Me.WardsDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "WardID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "WardID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "WardName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "WardName"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Capacity"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Capacity"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.btnprevious)
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnnext)
        Me.Panel1.Controls.Add(Me.btnaddnew)
        Me.Panel1.Location = New System.Drawing.Point(539, 211)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(459, 254)
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
        'Wardform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1043, 563)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.WardsDataGridView)
        Me.Controls.Add(WardIDLabel)
        Me.Controls.Add(Me.WardIDTextBox)
        Me.Controls.Add(WardNameLabel)
        Me.Controls.Add(Me.WardNameTextBox)
        Me.Controls.Add(CapacityLabel)
        Me.Controls.Add(Me.CapacityTextBox)
        Me.Controls.Add(Me.WardsBindingNavigator)
        Me.Name = "Wardform"
        Me.Text = "Wards"
        CType(Me.HospitalMgntDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WardsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WardsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WardsBindingNavigator.ResumeLayout(False)
        Me.WardsBindingNavigator.PerformLayout()
        CType(Me.WardsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HospitalMgntDataSet As HospitalMgntDataSet
    Friend WithEvents WardsBindingSource As BindingSource
    Friend WithEvents WardsTableAdapter As HospitalMgntDataSetTableAdapters.WardsTableAdapter
    Friend WithEvents TableAdapterManager As HospitalMgntDataSetTableAdapters.TableAdapterManager
    Friend WithEvents WardsBindingNavigator As BindingNavigator
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
    Friend WithEvents WardsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents WardIDTextBox As TextBox
    Friend WithEvents WardNameTextBox As TextBox
    Friend WithEvents CapacityTextBox As TextBox
    Friend WithEvents WardsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btndelete As Button
    Friend WithEvents btnprevious As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents btnaddnew As Button
End Class
