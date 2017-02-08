Imports System.IO



Public Class MainForm
    Private SavedListView As String = Application.StartupPath & "\SavedListView.txt" ' this file will be save in the VB bin file location
    Dim blnIsChanged As Boolean = False
    Dim applianceprices(7) As Double ' array of 7 items on the list

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sr As New StreamReader("C:\Users\rahmik\Desktop\VB\HomeAppliance\Utility_Inventory.txt")
        Dim line As String
        Dim i As Integer = 0

        Do While sr.Peek() <> -1
            line = sr.ReadLine()
            ComboBox1.Items.Add(line)
            AppliancePrices(i) = CDbl(sr.ReadLine())

            i = i + 1               'showing every other text(price) in the array
        Loop

    End Sub




    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close() 'closing action after button click
    End Sub

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


        'Statement when the cost per gallon and number of gallons is empty
        'setting the textboxes to default value of 0
        If txtCostPerGallon.Text = String.Empty Then
            txtCostPerGallon.Text = "0"
        End If
        If txtNumberofGallons.Text = String.Empty Then
            txtNumberofGallons.Text = "0"
        End If
        If txtNumberOfHrs.Text = String.Empty Then
            txtNumberOfHrs.Text = "0"
        End If
        If txtCostPerKW.Text = String.Empty Then
            txtCostPerKW.Text = "0"
        End If
        If txtPwrNeeded.Text = String.Empty Then
            txtPwrNeeded.Text = "0"
        End If




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






        'allowing currency $ sign to show up in the following textfieilds
        txtTotal.Text = Total.ToString("c")
        txtCostPerKW.Text = CostPerKW.ToString("c")
        txtCostPerGallon.Text = CostPerGallons.ToString("c")



    End Sub




    Private Sub ConvertWattstokW_Click(sender As Object, e As EventArgs) Handles ConvertWattstokW.Click
        Dim frmConversion As New conversionForm

        frmConversion.ShowDialog()
    End Sub

    Private Sub HintToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HintToolStripMenuItem1.Click
        Dim frmHint As New Hint

        frmHint.ShowDialog()

    End Sub




    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim index As Integer = ComboBox1.SelectedIndex


        txtPwrNeeded.Text = CStr(AppliancePrices(ComboBox1.SelectedIndex))

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




    Sub SaveDocument()
        Dim outputFile As StreamWriter ' Object variable
        For Each myItem As ListViewItem In ListView1.Items



            Try
                ' Create the file.
                outputFile = File.CreateText(SavedListView)

                ' Write the TextBox to the file.
                outputFile.Write(myItem.Text & " :: " & myItem.SubItems(1).Text & " :: " & myItem.SubItems(2).Text & " :: " & myItem.SubItems(3).Text _
                                          & " :: " & myItem.SubItems(4).Text & " :: " & myItem.SubItems(5).Text & " :: " & myItem.SubItems(6).Text)

                ' Close the file.
                outputFile.Close()
                ' Update the isChanged variable.
                blnIsChanged = False
            Catch
                ' Error message for file creation error.
                MessageBox.Show("Error creating the file.")


            End Try

        Next
    End Sub
    Private Sub SaveToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem1.Click
        Dim myWriter As New IO.StreamWriter(SavedListView) 'the location of the file C:\Users\rahmik\Desktop\HomeAppliance\HomeAppliance\bin\Debug

        For Each myItem As ListViewItem In ListView1.Items

            myWriter.WriteLine(myItem.Text & " :: " & myItem.SubItems(1).Text & " :: " & myItem.SubItems(2).Text & " :: " & myItem.SubItems(3).Text _
                                      & " :: " & myItem.SubItems(4).Text & " :: " & myItem.SubItems(5).Text & " :: " & myItem.SubItems(6).Text)


        Next
        MessageBox.Show("Success")
        myWriter.Close()
    End Sub




    Sub OpenDocument()
        Dim inputFile As StreamReader ' Object variable
        ofdOpenFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If ofdOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            ' Retrieve the selected filename.
            SavedListView = ofdOpenFile.FileName

            Try
                ' Open the file.
                inputFile = File.OpenText("C:\Users\rahmik\Desktop\HomeAppliance\HomeAppliance\bin")

                ' Read the file's contents into the TextBox.
                ListView1.Text = inputFile.ReadToEnd

                ' Close the file.
                inputFile.Close()

                ' Update the isChanged variable.
                blnIsChanged = False
            Catch
                ' Error message for file open error.
                MessageBox.Show("Error opening the file.")
            End Try
        End If
    End Sub
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        ' Has the current document changed?
        If blnIsChanged = True Then
            ' Confirm before clearing and replacing.
            If MessageBox.Show("The current document is not saved. " & "Are you sure?", _
                               "Confirm", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                OpenDocument()
            End If
        Else
            ' Document has not changed, so replace it.

            OpenDocument()
        End If
    End Sub


End Class
