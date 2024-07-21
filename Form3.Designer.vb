<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Appointmentform
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
        Dim AppointmentIDLabel As System.Windows.Forms.Label
        Dim PatientIDLabel As System.Windows.Forms.Label
        Dim DoctorIDLabel As System.Windows.Forms.Label
        Dim AppointmentDateLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Appointmentform))
        Me.HospitalMgntDataSet = New HOSPITALMNGT.HospitalMgntDataSet()
        Me.AppointmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppointmentsTableAdapter = New HOSPITALMNGT.HospitalMgntDataSetTableAdapters.AppointmentsTableAdapter()
        Me.TableAdapterManager = New HOSPITALMNGT.HospitalMgntDataSetTableAdapters.TableAdapterManager()
        Me.AppointmentsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AppointmentsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AppointmentIDTextBox = New System.Windows.Forms.TextBox()
        Me.PatientIDTextBox = New System.Windows.Forms.TextBox()
        Me.DoctorIDTextBox = New System.Windows.Forms.TextBox()
        Me.AppointmentDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.AppointmentsDataGridView = New System.Windows.Forms.DataGridView()
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
        AppointmentIDLabel = New System.Windows.Forms.Label()
        PatientIDLabel = New System.Windows.Forms.Label()
        DoctorIDLabel = New System.Windows.Forms.Label()
        AppointmentDateLabel = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        CType(Me.HospitalMgntDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AppointmentsBindingNavigator.SuspendLayout()
        CType(Me.AppointmentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AppointmentIDLabel
        '
        AppointmentIDLabel.AutoSize = True
        AppointmentIDLabel.Location = New System.Drawing.Point(95, 61)
        AppointmentIDLabel.Name = "AppointmentIDLabel"
        AppointmentIDLabel.Size = New System.Drawing.Size(101, 16)
        AppointmentIDLabel.TabIndex = 1
        AppointmentIDLabel.Text = "Appointment ID:"
        '
        'PatientIDLabel
        '
        PatientIDLabel.AutoSize = True
        PatientIDLabel.Location = New System.Drawing.Point(95, 89)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New System.Drawing.Size(67, 16)
        PatientIDLabel.TabIndex = 3
        PatientIDLabel.Text = "Patient ID:"
        '
        'DoctorIDLabel
        '
        DoctorIDLabel.AutoSize = True
        DoctorIDLabel.Location = New System.Drawing.Point(95, 117)
        DoctorIDLabel.Name = "DoctorIDLabel"
        DoctorIDLabel.Size = New System.Drawing.Size(66, 16)
        DoctorIDLabel.TabIndex = 5
        DoctorIDLabel.Text = "Doctor ID:"
        '
        'AppointmentDateLabel
        '
        AppointmentDateLabel.AutoSize = True
        AppointmentDateLabel.Location = New System.Drawing.Point(95, 146)
        AppointmentDateLabel.Name = "AppointmentDateLabel"
        AppointmentDateLabel.Size = New System.Drawing.Size(117, 16)
        AppointmentDateLabel.TabIndex = 7
        AppointmentDateLabel.Text = "Appointment Date:"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Location = New System.Drawing.Point(95, 173)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(46, 16)
        NotesLabel.TabIndex = 9
        NotesLabel.Text = "Notes:"
        '
        'HospitalMgntDataSet
        '
        Me.HospitalMgntDataSet.DataSetName = "HospitalMgntDataSet"
        Me.HospitalMgntDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AppointmentsBindingSource
        '
        Me.AppointmentsBindingSource.DataMember = "Appointments"
        Me.AppointmentsBindingSource.DataSource = Me.HospitalMgntDataSet
        '
        'AppointmentsTableAdapter
        '
        Me.AppointmentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AppointmentsTableAdapter = Me.AppointmentsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DoctorsTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.PatientsTableAdapter = Nothing
        Me.TableAdapterManager.PaymentsTableAdapter = Nothing
        Me.TableAdapterManager.PharmacyTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = HOSPITALMNGT.HospitalMgntDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        '
        'AppointmentsBindingNavigator
        '
        Me.AppointmentsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AppointmentsBindingNavigator.BindingSource = Me.AppointmentsBindingSource
        Me.AppointmentsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AppointmentsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AppointmentsBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.AppointmentsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AppointmentsBindingNavigatorSaveItem})
        Me.AppointmentsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AppointmentsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AppointmentsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AppointmentsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AppointmentsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AppointmentsBindingNavigator.Name = "AppointmentsBindingNavigator"
        Me.AppointmentsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AppointmentsBindingNavigator.Size = New System.Drawing.Size(1100, 31)
        Me.AppointmentsBindingNavigator.TabIndex = 0
        Me.AppointmentsBindingNavigator.Text = "BindingNavigator1"
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
        'AppointmentsBindingNavigatorSaveItem
        '
        Me.AppointmentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AppointmentsBindingNavigatorSaveItem.Image = CType(resources.GetObject("AppointmentsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AppointmentsBindingNavigatorSaveItem.Name = "AppointmentsBindingNavigatorSaveItem"
        Me.AppointmentsBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.AppointmentsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AppointmentIDTextBox
        '
        Me.AppointmentIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentsBindingSource, "AppointmentID", True))
        Me.AppointmentIDTextBox.Location = New System.Drawing.Point(218, 58)
        Me.AppointmentIDTextBox.Name = "AppointmentIDTextBox"
        Me.AppointmentIDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.AppointmentIDTextBox.TabIndex = 2
        '
        'PatientIDTextBox
        '
        Me.PatientIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentsBindingSource, "PatientID", True))
        Me.PatientIDTextBox.Location = New System.Drawing.Point(218, 86)
        Me.PatientIDTextBox.Name = "PatientIDTextBox"
        Me.PatientIDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PatientIDTextBox.TabIndex = 4
        '
        'DoctorIDTextBox
        '
        Me.DoctorIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentsBindingSource, "DoctorID", True))
        Me.DoctorIDTextBox.Location = New System.Drawing.Point(218, 114)
        Me.DoctorIDTextBox.Name = "DoctorIDTextBox"
        Me.DoctorIDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.DoctorIDTextBox.TabIndex = 6
        '
        'AppointmentDateDateTimePicker
        '
        Me.AppointmentDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AppointmentsBindingSource, "AppointmentDate", True))
        Me.AppointmentDateDateTimePicker.Location = New System.Drawing.Point(218, 142)
        Me.AppointmentDateDateTimePicker.Name = "AppointmentDateDateTimePicker"
        Me.AppointmentDateDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.AppointmentDateDateTimePicker.TabIndex = 8
        '
        'NotesTextBox
        '
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentsBindingSource, "Notes", True))
        Me.NotesTextBox.Location = New System.Drawing.Point(218, 170)
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(200, 22)
        Me.NotesTextBox.TabIndex = 10
        '
        'AppointmentsDataGridView
        '
        Me.AppointmentsDataGridView.AutoGenerateColumns = False
        Me.AppointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AppointmentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.AppointmentsDataGridView.DataSource = Me.AppointmentsBindingSource
        Me.AppointmentsDataGridView.Location = New System.Drawing.Point(12, 351)
        Me.AppointmentsDataGridView.Name = "AppointmentsDataGridView"
        Me.AppointmentsDataGridView.RowHeadersWidth = 51
        Me.AppointmentsDataGridView.RowTemplate.Height = 24
        Me.AppointmentsDataGridView.Size = New System.Drawing.Size(671, 220)
        Me.AppointmentsDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "AppointmentID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "AppointmentID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PatientID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PatientID"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DoctorID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DoctorID"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "AppointmentDate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "AppointmentDate"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Notes"
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
        Me.Panel1.Location = New System.Drawing.Point(569, 61)
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
        'Appointmentform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 583)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AppointmentsDataGridView)
        Me.Controls.Add(AppointmentIDLabel)
        Me.Controls.Add(Me.AppointmentIDTextBox)
        Me.Controls.Add(PatientIDLabel)
        Me.Controls.Add(Me.PatientIDTextBox)
        Me.Controls.Add(DoctorIDLabel)
        Me.Controls.Add(Me.DoctorIDTextBox)
        Me.Controls.Add(AppointmentDateLabel)
        Me.Controls.Add(Me.AppointmentDateDateTimePicker)
        Me.Controls.Add(NotesLabel)
        Me.Controls.Add(Me.NotesTextBox)
        Me.Controls.Add(Me.AppointmentsBindingNavigator)
        Me.Name = "Appointmentform"
        Me.Text = "Appointments"
        CType(Me.HospitalMgntDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AppointmentsBindingNavigator.ResumeLayout(False)
        Me.AppointmentsBindingNavigator.PerformLayout()
        CType(Me.AppointmentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HospitalMgntDataSet As HospitalMgntDataSet
    Friend WithEvents AppointmentsBindingSource As BindingSource
    Friend WithEvents AppointmentsTableAdapter As HospitalMgntDataSetTableAdapters.AppointmentsTableAdapter
    Friend WithEvents TableAdapterManager As HospitalMgntDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AppointmentsBindingNavigator As BindingNavigator
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
    Friend WithEvents AppointmentsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AppointmentIDTextBox As TextBox
    Friend WithEvents PatientIDTextBox As TextBox
    Friend WithEvents DoctorIDTextBox As TextBox
    Friend WithEvents AppointmentDateDateTimePicker As DateTimePicker
    Friend WithEvents NotesTextBox As TextBox
    Friend WithEvents AppointmentsDataGridView As DataGridView
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
