Public Class MainForm
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        'clearing fields
        txtCostPerKW.Clear()
        txtNumberOfHrs.Clear()
        txtTotal.Clear()
        txtPwrNeeded.Clear()
        txtCostPerGallon.Clear()
        txtNumberofGallons.Clear()


        'focuses back on the cost per kw per hour to start over
        txtCostPerKW.Focus()

    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click

        'declaring variables as double for using money
        Dim CostPerKW As Double = 0.0
        Dim NumberOfHrs As Double = 0.0
        Dim Total As Double = 0.0
        Dim Total1 As Double = 0.0
        Dim Total2 As Double = 0.0
        Dim PwrNeeded As Double = 0.0
        Dim NumberOfGallons As Double = 0.0
        Dim CostPerGallons As Double = 0.0
        Dim WasherTotal As Double = 0.0


     

        If Double.TryParse(txtCostPerKW.Text, CostPerKW) Then

            If Double.TryParse(txtNumberOfHrs.Text, NumberOfHrs) Then

                If Double.TryParse(txtPwrNeeded.Text, PwrNeeded) Then

                    If Double.TryParse(txtCostPerGallon.Text, CostPerGallons) Then

                        If Double.TryParse(txtNumberofGallons.Text, NumberOfGallons) Then

                            'calculate gallons 
                            Total2 = CostPerGallons * NumberOfGallons

                            'calculation function
                            Total1 = PwrNeeded * CostPerKW * NumberOfHrs

                            Total = Total1 + Total2


                            'allowing currency $ sign to show up in the following textfieilds
                            txtTotal.Text = Total.ToString("c")
                            txtCostPerKW.Text = CostPerKW.ToString("c")
                            txtCostPerGallon.Text = CostPerGallons.ToString("c")

                        Else
                            MessageBox.Show("Error: Please enter the number of gallons")

                        End If

                    Else
                        MessageBox.Show("Error: Please enter a numeric value for cost  " &
                                            "- example (0.10)")

                    End If

                Else
                    MessageBox.Show("Error: Please enter a numeric value for kW")

                End If

            Else
                MessageBox.Show("Error: Please enter a numeric value for hours")

            End If

        Else
            MessageBox.Show("Error: Please enter a numeric value for cost  " &
                                            "example (0.10)")
        End If





    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close() 'closing action after button click
    End Sub


    Private Sub ConvertWattstokW_Click(sender As Object, e As EventArgs) Handles ConvertWattstokW.Click
        Dim frmConversion As New conversionForm

        frmConversion.ShowDialog()
    End Sub

    Private Sub HintToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HintToolStripMenuItem1.Click
        Dim frmHint As New Hint

        frmHint.ShowDialog()

    End Sub




    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim i As ListViewItem
        ListView1.BeginUpdate()

        i = ListView1.Items.Add(txtCostPerKW.Text)
        i.SubItems.Add(ComboBox1.Text)
        i.SubItems.Add(txtCostPerGallon.Text)
        i.SubItems.Add(txtNumberofGallons.Text)
        i.SubItems.Add(txtPwrNeeded.Text)
        i.SubItems.Add(txtNumberOfHrs.Text)
        i.SubItems.Add(txtTotal.Text)
        ListView1.Update()
        ListView1.EndUpdate()

    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim index As Integer = ComboBox1.SelectedIndex

        'setting number of gallons to visible when washer is selected
        If (index = 4) Then
            txtNumberofGallons.Visible = True
        Else
            txtNumberofGallons.Visible = False
        End If

        'setting the label to visible when washer is selected 
        If (index = 4) Then
            lblNumberofGallons.Visible = True
        Else
            lblNumberofGallons.Visible = False

        End If

        'setting text field cost per gallon to visible when washer is selected
        If (index = 4) Then
            txtCostPerGallon.Visible = True
        Else
            txtCostPerGallon.Visible = False

        End If

        'setting label cost per gallon to visible when washer is selected
        If (index = 4) Then
            lblCostPerGallon.Visible = True
        Else
            lblCostPerGallon.Visible = False

        End If



    End Sub






End Class
