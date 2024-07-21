<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnpatients = New System.Windows.Forms.Button()
        Me.btnappointment = New System.Windows.Forms.Button()
        Me.btndoc = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnwards = New System.Windows.Forms.Button()
        Me.btnpharmacy = New System.Windows.Forms.Button()
        Me.btnpayments = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnpatients)
        Me.Panel1.Controls.Add(Me.btnappointment)
        Me.Panel1.Controls.Add(Me.btndoc)
        Me.Panel1.Location = New System.Drawing.Point(115, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(246, 198)
        Me.Panel1.TabIndex = 0
        '
        'btnpatients
        '
        Me.btnpatients.Location = New System.Drawing.Point(55, 157)
        Me.btnpatients.Name = "btnpatients"
        Me.btnpatients.Size = New System.Drawing.Size(124, 23)
        Me.btnpatients.TabIndex = 5
        Me.btnpatients.Text = "Patients"
        Me.btnpatients.UseVisualStyleBackColor = True
        '
        'btnappointment
        '
        Me.btnappointment.Location = New System.Drawing.Point(28, 81)
        Me.btnappointment.Name = "btnappointment"
        Me.btnappointment.Size = New System.Drawing.Size(188, 23)
        Me.btnappointment.TabIndex = 4
        Me.btnappointment.Text = "Appointment"
        Me.btnappointment.UseVisualStyleBackColor = True
        '
        'btndoc
        '
        Me.btndoc.Location = New System.Drawing.Point(55, 32)
        Me.btndoc.Name = "btndoc"
        Me.btndoc.Size = New System.Drawing.Size(124, 23)
        Me.btndoc.TabIndex = 3
        Me.btndoc.Text = "Doctor"
        Me.btndoc.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.btnlogin)
        Me.Panel2.Controls.Add(Me.lblpass)
        Me.Panel2.Controls.Add(Me.lblusername)
        Me.Panel2.Controls.Add(Me.txtpassword)
        Me.Panel2.Controls.Add(Me.txtusername)
        Me.Panel2.Location = New System.Drawing.Point(393, 338)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(293, 236)
        Me.Panel2.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(195, 204)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(114, 204)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnlogin
        '
        Me.btnlogin.Location = New System.Drawing.Point(20, 204)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(75, 23)
        Me.btnlogin.TabIndex = 4
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Location = New System.Drawing.Point(49, 149)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(67, 16)
        Me.lblpass.TabIndex = 3
        Me.lblpass.Text = "Password"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Location = New System.Drawing.Point(49, 67)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(70, 16)
        Me.lblusername.TabIndex = 2
        Me.lblusername.Text = "Username"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(170, 140)
        Me.txtpassword.Multiline = True
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(100, 25)
        Me.txtpassword.TabIndex = 1
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(170, 61)
        Me.txtusername.Multiline = True
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(100, 22)
        Me.txtusername.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnwards)
        Me.Panel3.Controls.Add(Me.btnpharmacy)
        Me.Panel3.Controls.Add(Me.btnpayments)
        Me.Panel3.Location = New System.Drawing.Point(702, 102)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(315, 222)
        Me.Panel3.TabIndex = 3
        '
        'btnwards
        '
        Me.btnwards.Location = New System.Drawing.Point(86, 157)
        Me.btnwards.Name = "btnwards"
        Me.btnwards.Size = New System.Drawing.Size(144, 23)
        Me.btnwards.TabIndex = 5
        Me.btnwards.Text = "Wards"
        Me.btnwards.UseVisualStyleBackColor = True
        '
        'btnpharmacy
        '
        Me.btnpharmacy.Location = New System.Drawing.Point(86, 95)
        Me.btnpharmacy.Name = "btnpharmacy"
        Me.btnpharmacy.Size = New System.Drawing.Size(144, 23)
        Me.btnpharmacy.TabIndex = 4
        Me.btnpharmacy.Text = "Pharmacy"
        Me.btnpharmacy.UseVisualStyleBackColor = True
        '
        'btnpayments
        '
        Me.btnpayments.Location = New System.Drawing.Point(86, 44)
        Me.btnpayments.Name = "btnpayments"
        Me.btnpayments.Size = New System.Drawing.Size(144, 23)
        Me.btnpayments.TabIndex = 3
        Me.btnpayments.Text = "Payments"
        Me.btnpayments.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(34, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(552, 29)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "HOSPITAL MANAGEMENT SYSTEM(VB.NET)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1071, 653)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btndoc As Button
    Friend WithEvents btnpatients As Button
    Friend WithEvents btnappointment As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnwards As Button
    Friend WithEvents btnpharmacy As Button
    Friend WithEvents btnpayments As Button
    Friend WithEvents lblpass As Label
    Friend WithEvents lblusername As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnlogin As Button
End Class
