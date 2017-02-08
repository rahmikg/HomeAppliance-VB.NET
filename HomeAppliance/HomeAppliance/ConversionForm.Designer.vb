<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class conversionForm
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
        Me.txtWatts = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtKW = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.Refresh2 = New System.Windows.Forms.Button()
        Me.Exit2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtWatts
        '
        Me.txtWatts.Location = New System.Drawing.Point(60, 3)
        Me.txtWatts.Name = "txtWatts"
        Me.txtWatts.Size = New System.Drawing.Size(100, 20)
        Me.txtWatts.TabIndex = 1
        Me.txtWatts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Watts"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtKW)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtWatts)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(6, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(178, 64)
        Me.Panel1.TabIndex = 3
        '
        'txtKW
        '
        Me.txtKW.Location = New System.Drawing.Point(60, 29)
        Me.txtKW.Name = "txtKW"
        Me.txtKW.ReadOnly = True
        Me.txtKW.Size = New System.Drawing.Size(100, 20)
        Me.txtKW.TabIndex = 3
        Me.txtKW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "kW"
        '
        'Calculate
        '
        Me.Calculate.Location = New System.Drawing.Point(6, 89)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(75, 23)
        Me.Calculate.TabIndex = 5
        Me.Calculate.Text = "Calculate"
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'Refresh2
        '
        Me.Refresh2.Location = New System.Drawing.Point(109, 89)
        Me.Refresh2.Name = "Refresh2"
        Me.Refresh2.Size = New System.Drawing.Size(75, 23)
        Me.Refresh2.TabIndex = 6
        Me.Refresh2.Text = "Clear"
        Me.Refresh2.UseVisualStyleBackColor = True
        '
        'Exit2
        '
        Me.Exit2.Location = New System.Drawing.Point(56, 118)
        Me.Exit2.Name = "Exit2"
        Me.Exit2.Size = New System.Drawing.Size(75, 23)
        Me.Exit2.TabIndex = 7
        Me.Exit2.Text = "Exit"
        Me.Exit2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Exit2)
        Me.GroupBox1.Controls.Add(Me.Calculate)
        Me.GroupBox1.Controls.Add(Me.Refresh2)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(193, 154)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calculating Watts to kW"
        '
        'conversionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 254)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "conversionForm"
        Me.Text = "Watts to kW conversion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtWatts As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Calculate As System.Windows.Forms.Button
    Friend WithEvents Refresh2 As System.Windows.Forms.Button
    Friend WithEvents txtKW As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Exit2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
