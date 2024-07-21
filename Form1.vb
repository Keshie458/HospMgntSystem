Public Class Form1
    Public Property LoginTableAdapter As Object

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnpayments.Click

    End Sub

    Private Sub btndoc_Click(sender As Object, e As EventArgs) Handles btndoc.Click
        Doctorform.Show()

    End Sub

    Private Sub btnappointment_Click(sender As Object, e As EventArgs) Handles btnappointment.Click
        Appointmentform.Show()


    End Sub

    Private Sub btnpatients_Click(sender As Object, e As EventArgs) Handles btnpatients.Click
        Patientsform.Show()

    End Sub

    Private Sub btnpharmacy_Click(sender As Object, e As EventArgs) Handles btnpharmacy.Click
        Pharmacyform.Show()


    End Sub

    Private Sub btnwards_Click(sender As Object, e As EventArgs) Handles btnwards.Click
        Wardform.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Dim iexit As DialogResult
        iexit = MessageBox.Show("Are you sure you want to exit now?", "Hospital_management_system", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iexit = DialogResult.Yes Then
            Me.Close()
            txtusername.Clear()
            txtpassword.Clear()
            btnappointment.Enabled = False
            btndoc.Enabled = False
            btnpatients.Enabled = False
            btnpharmacy.Enabled = False
            btnwards.Enabled = False
            btnpayments.Enabled = False

        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtusername.Clear()
        txtpassword.Clear()
        btnappointment.Enabled = False
        btndoc.Enabled = False
        btnpatients.Enabled = False
        btnpharmacy.Enabled = False
        btnwards.Enabled = False
        btnpayments.Enabled = False




    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnappointment.Enabled = False
        btndoc.Enabled = False
        btnpatients.Enabled = False
        btnpharmacy.Enabled = False
        btnwards.Enabled = False
        btnpayments.Enabled = False

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim log = Me.LoginTableAdapter.Userdetails(Me.txtusername.Text, Me.txtpassword.Text)
        If log Is Nothing Then
            txtusername.Clear()

            txtpassword.Clear()
            txtusername.Focus()


        Else
            btnappointment.Enabled = True
            btndoc.Enabled = True
            btnpatients.Enabled = True
            btnpharmacy.Enabled = True
            btnwards.Enabled = True
            btnpayments.Enabled = True



        End If

    End Sub

    'Private Sub Btnlogin_Click(sender As Object, e As EventArgs, dialogResult1 As DialogResult) Handles btnlogin.Click
    'Dim log = Me.LoginTableAdapter.Userdetails(Me.txtusername.Text, Me.txtpassword.Text)
    'If log Is Nothing Then
    ' txtusername.Clear()

    'txtpassword.Clear()
    '  txtusername.Focus()


    ''Else
    ' btnappointment.Enabled = True
    'btndoc.Enabled = True
    'btnpatients.Enabled = True
    'btnpharmacy.Enabled = True
    'btnwards.Enabled = True
    'btnpayments.Enabled = True



    ' End If

    ' End Sub
End Class
