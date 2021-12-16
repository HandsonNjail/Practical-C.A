<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPreviousReadings = New System.Windows.Forms.TextBox()
        Me.txtPresentReadings = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMonthlyBill = New System.Windows.Forms.TextBox()
        Me.txtMonthlyTax = New System.Windows.Forms.TextBox()
        Me.txtEnergyCost = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUnitCost = New System.Windows.Forms.TextBox()
        Me.txtEnergyUsed = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBill = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPreviousReadings)
        Me.GroupBox1.Controls.Add(Me.txtPresentReadings)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(233, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 181)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inputs"
        '
        'txtPreviousReadings
        '
        Me.txtPreviousReadings.Location = New System.Drawing.Point(245, 110)
        Me.txtPreviousReadings.Multiline = True
        Me.txtPreviousReadings.Name = "txtPreviousReadings"
        Me.txtPreviousReadings.Size = New System.Drawing.Size(132, 30)
        Me.txtPreviousReadings.TabIndex = 3
        Me.txtPreviousReadings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPresentReadings
        '
        Me.txtPresentReadings.Location = New System.Drawing.Point(245, 55)
        Me.txtPresentReadings.Multiline = True
        Me.txtPresentReadings.Name = "txtPresentReadings"
        Me.txtPresentReadings.Size = New System.Drawing.Size(132, 30)
        Me.txtPresentReadings.TabIndex = 2
        Me.txtPresentReadings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Previous Readings(Kwh):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Present Readings(Kwh):"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtMonthlyBill)
        Me.GroupBox2.Controls.Add(Me.txtMonthlyTax)
        Me.GroupBox2.Controls.Add(Me.txtEnergyCost)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtUnitCost)
        Me.GroupBox2.Controls.Add(Me.txtEnergyUsed)
        Me.GroupBox2.Controls.Add(Me.label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(233, 330)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(434, 321)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Outputs"
        '
        'txtMonthlyBill
        '
        Me.txtMonthlyBill.Location = New System.Drawing.Point(169, 271)
        Me.txtMonthlyBill.Multiline = True
        Me.txtMonthlyBill.Name = "txtMonthlyBill"
        Me.txtMonthlyBill.Size = New System.Drawing.Size(132, 30)
        Me.txtMonthlyBill.TabIndex = 9
        Me.txtMonthlyBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMonthlyTax
        '
        Me.txtMonthlyTax.Location = New System.Drawing.Point(169, 222)
        Me.txtMonthlyTax.Multiline = True
        Me.txtMonthlyTax.Name = "txtMonthlyTax"
        Me.txtMonthlyTax.Size = New System.Drawing.Size(132, 30)
        Me.txtMonthlyTax.TabIndex = 8
        Me.txtMonthlyTax.Text = "500"
        Me.txtMonthlyTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEnergyCost
        '
        Me.txtEnergyCost.Location = New System.Drawing.Point(169, 166)
        Me.txtEnergyCost.Multiline = True
        Me.txtEnergyCost.Name = "txtEnergyCost"
        Me.txtEnergyCost.Size = New System.Drawing.Size(132, 30)
        Me.txtEnergyCost.TabIndex = 7
        Me.txtEnergyCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(50, 281)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Monthly Bill:"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(49, 232)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(90, 20)
        Me.label6.TabIndex = 5
        Me.label6.Text = "Monthly tax:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Energy Cost:"
        '
        'txtUnitCost
        '
        Me.txtUnitCost.Location = New System.Drawing.Point(169, 106)
        Me.txtUnitCost.Multiline = True
        Me.txtUnitCost.Name = "txtUnitCost"
        Me.txtUnitCost.Size = New System.Drawing.Size(132, 30)
        Me.txtUnitCost.TabIndex = 3
        Me.txtUnitCost.Text = "10"
        Me.txtUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEnergyUsed
        '
        Me.txtEnergyUsed.Location = New System.Drawing.Point(169, 55)
        Me.txtEnergyUsed.Multiline = True
        Me.txtEnergyUsed.Name = "txtEnergyUsed"
        Me.txtEnergyUsed.Size = New System.Drawing.Size(132, 30)
        Me.txtEnergyUsed.TabIndex = 2
        Me.txtEnergyUsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(49, 116)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(98, 20)
        Me.label3.TabIndex = 1
        Me.label3.Text = "Cost per Kwh:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Energy Used:"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(233, 256)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 48)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnBill
        '
        Me.btnBill.Location = New System.Drawing.Point(353, 256)
        Me.btnBill.Name = "btnBill"
        Me.btnBill.Size = New System.Drawing.Size(191, 48)
        Me.btnBill.TabIndex = 3
        Me.btnBill.Text = "Calculate Bill"
        Me.btnBill.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(567, 256)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 48)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Calculator_Project.My.Resources.Resources.images__1_
        Me.ClientSize = New System.Drawing.Size(859, 749)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBill)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Harlow Solid Italic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Electricity Bill Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPreviousReadings As TextBox
    Friend WithEvents txtPresentReadings As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtMonthlyBill As TextBox
    Friend WithEvents txtMonthlyTax As TextBox
    Friend WithEvents txtEnergyCost As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUnitCost As TextBox
    Friend WithEvents txtEnergyUsed As TextBox
    Friend WithEvents label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBill As Button
    Friend WithEvents btnExit As Button
End Class
