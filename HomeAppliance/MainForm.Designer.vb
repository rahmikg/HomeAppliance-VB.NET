<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.txtNumberOfHrs = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTotalDisplay = New System.Windows.Forms.Label()
        Me.lblPowerNeeded = New System.Windows.Forms.Label()
        Me.lblNumberOfHours = New System.Windows.Forms.Label()
        Me.txtPwrNeeded = New System.Windows.Forms.TextBox()
        Me.lblCostKW = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCostPerKW = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConvertWattstokW = New System.Windows.Forms.ToolStripMenuItem()
        Me.HintToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCostPerGallon = New System.Windows.Forms.TextBox()
        Me.lblCostPerGallon = New System.Windows.Forms.Label()
        Me.txtNumberofGallons = New System.Windows.Forms.TextBox()
        Me.lblNumberofGallons = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.CostkWHr = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AppName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CostPerGallon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NumberGallons = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AppkW = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hrsDay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Refrigerator", "TV", "Space Heater", "Fan", "Washer", "Dryer", "Oven"})
        Me.ComboBox1.Location = New System.Drawing.Point(135, 70)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 8
        Me.ComboBox1.Text = "select"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(135, 180)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(75, 20)
        Me.txtTotal.TabIndex = 25
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(55, 236)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 6
        Me.btnEnter.Text = "Calculate"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'txtNumberOfHrs
        '
        Me.txtNumberOfHrs.Location = New System.Drawing.Point(135, 143)
        Me.txtNumberOfHrs.Name = "txtNumberOfHrs"
        Me.txtNumberOfHrs.Size = New System.Drawing.Size(75, 20)
        Me.txtNumberOfHrs.TabIndex = 3
        Me.txtNumberOfHrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(136, 236)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 10
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.Location = New System.Drawing.Point(19, 75)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(107, 16)
        Me.lblSelect.TabIndex = 13
        Me.lblSelect.Text = "select appliance"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(298, 236)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblTotalDisplay
        '
        Me.lblTotalDisplay.AutoSize = True
        Me.lblTotalDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDisplay.Location = New System.Drawing.Point(39, 184)
        Me.lblTotalDisplay.Name = "lblTotalDisplay"
        Me.lblTotalDisplay.Size = New System.Drawing.Size(87, 16)
        Me.lblTotalDisplay.TabIndex = 15
        Me.lblTotalDisplay.Text = "Total Amount"
        '
        'lblPowerNeeded
        '
        Me.lblPowerNeeded.AutoSize = True
        Me.lblPowerNeeded.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPowerNeeded.Location = New System.Drawing.Point(31, 110)
        Me.lblPowerNeeded.Name = "lblPowerNeeded"
        Me.lblPowerNeeded.Size = New System.Drawing.Size(95, 16)
        Me.lblPowerNeeded.TabIndex = 12
        Me.lblPowerNeeded.Text = "Appliance kW "
        '
        'lblNumberOfHours
        '
        Me.lblNumberOfHours.AutoSize = True
        Me.lblNumberOfHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfHours.Location = New System.Drawing.Point(15, 147)
        Me.lblNumberOfHours.Name = "lblNumberOfHours"
        Me.lblNumberOfHours.Size = New System.Drawing.Size(111, 16)
        Me.lblNumberOfHours.TabIndex = 14
        Me.lblNumberOfHours.Text = "Hrs used per day"
        '
        'txtPwrNeeded
        '
        Me.txtPwrNeeded.Location = New System.Drawing.Point(135, 106)
        Me.txtPwrNeeded.Name = "txtPwrNeeded"
        Me.txtPwrNeeded.Size = New System.Drawing.Size(75, 20)
        Me.txtPwrNeeded.TabIndex = 2
        Me.txtPwrNeeded.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCostKW
        '
        Me.lblCostKW.AutoSize = True
        Me.lblCostKW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostKW.Location = New System.Drawing.Point(52, 41)
        Me.lblCostKW.Name = "lblCostKW"
        Me.lblCostKW.Size = New System.Drawing.Size(74, 16)
        Me.lblCostKW.TabIndex = 0
        Me.lblCostKW.Text = "cost kW/hr "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(215, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "cents"
        '
        'txtCostPerKW
        '
        Me.txtCostPerKW.Location = New System.Drawing.Point(135, 36)
        Me.txtCostPerKW.Name = "txtCostPerKW"
        Me.txtCostPerKW.Size = New System.Drawing.Size(75, 20)
        Me.txtCostPerKW.TabIndex = 1
        Me.txtCostPerKW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(217, 236)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConvertWattstokW, Me.HintToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(591, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConvertWattstokW
        '
        Me.ConvertWattstokW.Name = "ConvertWattstokW"
        Me.ConvertWattstokW.ShortcutKeyDisplayString = ""
        Me.ConvertWattstokW.Size = New System.Drawing.Size(128, 20)
        Me.ConvertWattstokW.Text = "Convert Watts to kW"
        '
        'HintToolStripMenuItem1
        '
        Me.HintToolStripMenuItem1.Name = "HintToolStripMenuItem1"
        Me.HintToolStripMenuItem1.Size = New System.Drawing.Size(42, 20)
        Me.HintToolStripMenuItem1.Text = "Hint"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCostPerGallon)
        Me.GroupBox1.Controls.Add(Me.lblCostPerGallon)
        Me.GroupBox1.Controls.Add(Me.txtNumberofGallons)
        Me.GroupBox1.Controls.Add(Me.btnEnter)
        Me.GroupBox1.Controls.Add(Me.lblNumberofGallons)
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.lblCostKW)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.lblNumberOfHours)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.txtPwrNeeded)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.lblTotalDisplay)
        Me.GroupBox1.Controls.Add(Me.txtNumberOfHrs)
        Me.GroupBox1.Controls.Add(Me.lblPowerNeeded)
        Me.GroupBox1.Controls.Add(Me.txtCostPerKW)
        Me.GroupBox1.Controls.Add(Me.lblSelect)
        Me.GroupBox1.Location = New System.Drawing.Point(62, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(466, 280)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cost of Operating Appliance"
        '
        'txtCostPerGallon
        '
        Me.txtCostPerGallon.Location = New System.Drawing.Point(377, 69)
        Me.txtCostPerGallon.Name = "txtCostPerGallon"
        Me.txtCostPerGallon.Size = New System.Drawing.Size(75, 20)
        Me.txtCostPerGallon.TabIndex = 30
        Me.txtCostPerGallon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCostPerGallon.Visible = False
        '
        'lblCostPerGallon
        '
        Me.lblCostPerGallon.AutoSize = True
        Me.lblCostPerGallon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostPerGallon.Location = New System.Drawing.Point(275, 73)
        Me.lblCostPerGallon.Name = "lblCostPerGallon"
        Me.lblCostPerGallon.Size = New System.Drawing.Size(98, 16)
        Me.lblCostPerGallon.TabIndex = 29
        Me.lblCostPerGallon.Text = "Cost per gallon"
        Me.lblCostPerGallon.Visible = False
        '
        'txtNumberofGallons
        '
        Me.txtNumberofGallons.Location = New System.Drawing.Point(377, 106)
        Me.txtNumberofGallons.Name = "txtNumberofGallons"
        Me.txtNumberofGallons.Size = New System.Drawing.Size(75, 20)
        Me.txtNumberofGallons.TabIndex = 28
        Me.txtNumberofGallons.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNumberofGallons.Visible = False
        '
        'lblNumberofGallons
        '
        Me.lblNumberofGallons.AutoSize = True
        Me.lblNumberofGallons.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberofGallons.Location = New System.Drawing.Point(253, 110)
        Me.lblNumberofGallons.Name = "lblNumberofGallons"
        Me.lblNumberofGallons.Size = New System.Drawing.Size(118, 16)
        Me.lblNumberofGallons.TabIndex = 27
        Me.lblNumberofGallons.Text = "How many gallons"
        Me.lblNumberofGallons.Visible = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CostkWHr, Me.AppName, Me.CostPerGallon, Me.NumberGallons, Me.AppkW, Me.hrsDay, Me.Total})
        Me.ListView1.Location = New System.Drawing.Point(6, 19)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(555, 255)
        Me.ListView1.TabIndex = 18
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'CostkWHr
        '
        Me.CostkWHr.Text = "Cost kW/Hr"
        Me.CostkWHr.Width = 69
        '
        'AppName
        '
        Me.AppName.Text = "Appliance Name"
        Me.AppName.Width = 91
        '
        'CostPerGallon
        '
        Me.CostPerGallon.Text = "Cost per gallon"
        Me.CostPerGallon.Width = 88
        '
        'NumberGallons
        '
        Me.NumberGallons.Text = "Number of Gallons"
        Me.NumberGallons.Width = 100
        '
        'AppkW
        '
        Me.AppkW.Text = "Appliance kW"
        Me.AppkW.Width = 91
        '
        'hrsDay
        '
        Me.hrsDay.Text = "Hrs/Day"
        '
        'Total
        '
        Me.Total.Text = "Total"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 334)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(567, 280)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List View"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 626)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Home Utility Application"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents txtNumberOfHrs As System.Windows.Forms.TextBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents lblSelect As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblTotalDisplay As System.Windows.Forms.Label
    Friend WithEvents lblPowerNeeded As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfHours As System.Windows.Forms.Label
    Friend WithEvents txtPwrNeeded As System.Windows.Forms.TextBox
    Friend WithEvents lblCostKW As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCostPerKW As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ConvertWattstokW As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HintToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents CostkWHr As System.Windows.Forms.ColumnHeader
    Friend WithEvents AppName As System.Windows.Forms.ColumnHeader
    Friend WithEvents CostPerGallon As System.Windows.Forms.ColumnHeader
    Friend WithEvents NumberGallons As System.Windows.Forms.ColumnHeader
    Friend WithEvents AppkW As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumberofGallons As System.Windows.Forms.Label
    Friend WithEvents txtNumberofGallons As System.Windows.Forms.TextBox
    Friend WithEvents txtCostPerGallon As System.Windows.Forms.TextBox
    Friend WithEvents lblCostPerGallon As System.Windows.Forms.Label
    Friend WithEvents hrsDay As System.Windows.Forms.ColumnHeader
    Friend WithEvents Total As System.Windows.Forms.ColumnHeader

End Class
