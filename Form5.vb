Public Class Pharmacyform
    Private Sub PharmacyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PharmacyBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PharmacyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HospitalMgntDataSet)

    End Sub

    Private Sub Pharmacyform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HospitalMgntDataSet.Pharmacy' table. You can move, or remove it, as needed.
        Me.PharmacyTableAdapter.Fill(Me.HospitalMgntDataSet.Pharmacy)

    End Sub

    Private Sub btnaddnew_Click(sender As Object, e As EventArgs) Handles btnaddnew.Click
        Me.PharmacyBindingSource.AddNew()

    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        Me.PharmacyBindingSource.MoveNext()

    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        Me.PharmacyBindingSource.MovePrevious()

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Me.PharmacyBindingSource.RemoveCurrent()

    End Sub
End Class