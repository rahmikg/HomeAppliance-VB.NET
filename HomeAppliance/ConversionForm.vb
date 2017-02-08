Public Class conversionForm


    Private Sub Refresh2_Click(sender As Object, e As EventArgs) Handles Refresh2.Click

        'clearing the text fields
        txtKW.Clear()
        txtWatts.Clear()

        'putting the focus back to the watts field
        txtWatts.Focus()


    End Sub

    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click

        'constant calculation of converting watts to kilowatts
        Const dblKW_OF_ENERGY As Double = 0.001

        'declaring the variables of watts and kW
        Dim Watts As Double = 0.0
        Dim KW As Double = 0.0

        'Displaying the watts in the text field of watts
        Watts = CDec(txtWatts.Text)

        'calculation for watts to kW
        KW = Watts * dblKW_OF_ENERGY


        'Displaying what was calculated into the txtKW field
        txtKW.Text = KW.ToString




    End Sub

    Private Sub Exit2_Click(sender As Object, e As EventArgs) Handles Exit2.Click
        Me.Close()

    End Sub

    Private Sub txtWatts_TextChanged(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtWatts.KeyPress

        If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
        If e.KeyChar = Chr(8) Then e.Handled = False



    End Sub


End Class