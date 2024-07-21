Public Class Appointmentform
    Private PatientBindingSource As Object
    Public Property PatientsTableAdapter As Object

    Private Sub PatientsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PatientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HospitalMgntDataSet)

    End Sub

    Private Sub Appointmentform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HospitalMgntDataSet.Appointments' table. You can move, or remove it, as needed.
        Me.AppointmentsTableAdapter.Fill(Me.HospitalMgntDataSet.Appointments)
        'TODO: This line of code loads data into the 'HospitalMgntDataSet.Patients' table. You can move, or remove it, as needed.
        Me.PatientsTableAdapter.Fill(Me.HospitalMgntDataSet.Patients)

    End Sub

    Private Sub AppointmentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AppointmentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AppointmentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HospitalMgntDataSet)

    End Sub

    Private Sub btnaddnew_Click(sender As Object, e As EventArgs) Handles btnaddnew.Click
        Me.AppointmentsBindingSource.AddNew()

    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        AppointmentsBindingSource.MoveNext()

    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        AppointmentsBindingSource.MovePrevious()

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        AppointmentsBindingSource.RemoveCurrent()

    End Sub
End Class