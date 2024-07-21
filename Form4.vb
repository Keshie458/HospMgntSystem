Public Class Patientsform
    Private Sub PatientsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PatientsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PatientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HospitalMgntDataSet)

    End Sub

    Private Sub Patientsform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HospitalMgntDataSet.Patients' table. You can move, or remove it, as needed.
        Me.PatientsTableAdapter.Fill(Me.HospitalMgntDataSet.Patients)

    End Sub

    Private Sub btnaddnew_Click(sender As Object, e As EventArgs) Handles btnaddnew.Click
        Me.PatientsBindingSource.AddNew()

    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        Me.PatientsBindingSource.MoveNext()

    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        Me.PatientsBindingSource.MovePrevious()

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Me.PatientsBindingSource.RemoveCurrent()

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Dim iexit As DialogResult
        iexit = MessageBox.Show("Are you sure you want to exit now?", "Hospital_management_system", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iexit = DialogResult.Yes Then
            Me.Close()

        End If


    End Sub
End Class