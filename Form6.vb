Public Class Wardform
    Private Sub WardsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles WardsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.WardsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HospitalMgntDataSet)

    End Sub

    Private Sub Wardform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HospitalMgntDataSet.Wards' table. You can move, or remove it, as needed.
        Me.WardsTableAdapter.Fill(Me.HospitalMgntDataSet.Wards)

    End Sub

    Private Sub btnaddnew_Click(sender As Object, e As EventArgs) Handles btnaddnew.Click
        Me.WardsBindingSource.AddNew()

    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        Me.WardsBindingSource.MoveNext()
    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        Me.WardsBindingSource.MovePrevious()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Me.WardsBindingSource.RemoveCurrent()
    End Sub
End Class