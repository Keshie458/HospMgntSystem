Imports System.IO
Imports System.Runtime.InteropServices

Public Class cExit
    Public Shared Function ExitSystem()


        Dim iexit As DialogResult
        iexit = MessageBox.Show("Are you sure you want to exit now?", "Hospital_management_system", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iexit = DialogResult.Yes Then


            Application.Exit()
        End If


    End Function
End Class
