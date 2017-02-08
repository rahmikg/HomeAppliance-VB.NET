Public Class Hint

    Private Sub ConvertWattsToKWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConvertWattsToKWToolStripMenuItem.Click
        'Declaring variable
        Dim frmConversionForm As New conversionForm

        'Open the conversionform window
        frmConversionForm.ShowDialog()

    End Sub

    Private Sub CloseHint_Click(sender As Object, e As EventArgs) Handles CloseHint.Click

        'closing the window
        Me.Close()

    End Sub
End Class