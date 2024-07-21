Public Class Doctorform
    Private Sub Doctorform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HospitalMgntDataSet.Doctors' table. You can move, or remove it, as needed.
        Me.DoctorsTableAdapter.Fill(Me.HospitalMgntDataSet.Doctors)
        'TODO: This line of code loads data into the 'LOGINSYST1DataSet.Doctor' table. You can move, or remove it, as needed.
        Me.DoctorTableAdapter.Fill(Me.LOGINSYST1DataSet.Doctor)

    End Sub

    Private Sub Doctorform_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LOGINSYST1DataSet1.Doctor' table. You can move, or remove it, as needed.
        Me.DoctorTableAdapter1.Fill(Me.LOGINSYST1DataSet1.Doctor)

    End Sub

    Private Sub DoctorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DoctorsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DoctorsBindingSource.EndEdit()
        Me.TableAdapterManager2.UpdateAll(Me.HospitalMgntDataSet)

    End Sub

    Private Sub btnaddnew_Click(sender As Object, e As EventArgs) Handles btnaddnew.Click
        Me.DoctorBindingSource.AddNew()

    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        Me.DoctorBindingSource.MoveNext()
    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        Me.DoctorBindingSource.MovePrevious()

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Me.DoctorBindingSource.RemoveCurrent()

    End Sub
End Class