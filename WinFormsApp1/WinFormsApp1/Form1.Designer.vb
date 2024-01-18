<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        BTN_PRO = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CB1 = New ComboBox()
        CB3 = New ComboBox()
        CB2 = New ComboBox()
        OR1 = New TextBox()
        DS1 = New TextBox()
        GF1 = New TextBox()
        DIS1 = New TextBox()
        NF1 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Font = New Font("Viner Hand ITC", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.RosyBrown
        Label1.Location = New Point(577, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 60)
        Label1.TabIndex = 0
        Label1.Text = "LRT"
        ' 
        ' BTN_PRO
        ' 
        BTN_PRO.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        BTN_PRO.Location = New Point(512, 426)
        BTN_PRO.Name = "BTN_PRO"
        BTN_PRO.Size = New Size(210, 67)
        BTN_PRO.TabIndex = 2
        BTN_PRO.Text = "PROCESS"
        BTN_PRO.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(159, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 31)
        Label2.TabIndex = 3
        Label2.Text = "From"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(142, 272)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 31)
        Label3.TabIndex = 3
        Label3.Text = "Discount"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(172, 183)
        Label4.Name = "Label4"
        Label4.Size = New Size(37, 31)
        Label4.TabIndex = 3
        Label4.Text = "To"
        ' 
        ' CB1
        ' 
        CB1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        CB1.FormattingEnabled = True
        CB1.Items.AddRange(New Object() {"Dagupan City", "Urdaneta", "Rosales", "Paniqui", "Moncada", "Province of Tarlac", "Concepcion", "Capas", "Bamban", "Mabalacat, Pampanga", "Angeles, Pampanga"})
        CB1.Location = New Point(77, 217)
        CB1.Name = "CB1"
        CB1.Size = New Size(255, 45)
        CB1.TabIndex = 4
        ' 
        ' CB3
        ' 
        CB3.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        CB3.FormattingEnabled = True
        CB3.Items.AddRange(New Object() {"No Discount", "Goverment", "Student", "Senior Citizen", "Children"})
        CB3.Location = New Point(77, 318)
        CB3.Name = "CB3"
        CB3.Size = New Size(255, 45)
        CB3.TabIndex = 4
        ' 
        ' CB2
        ' 
        CB2.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        CB2.FormattingEnabled = True
        CB2.Items.AddRange(New Object() {"Dagupan", "Urdaneta", "Rosales", "Paniqui", "Moncada", "Province of Tarlac", "Concepcion", "Capas", "Bamban", "Mabalacat, Pampanga", "Angeles, Pampanga"})
        CB2.Location = New Point(77, 116)
        CB2.Name = "CB2"
        CB2.Size = New Size(255, 45)
        CB2.TabIndex = 4
        ' 
        ' OR1
        ' 
        OR1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        OR1.Location = New Point(490, 116)
        OR1.Name = "OR1"
        OR1.Size = New Size(261, 43)
        OR1.TabIndex = 5
        ' 
        ' DS1
        ' 
        DS1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        DS1.Location = New Point(490, 217)
        DS1.Name = "DS1"
        DS1.Size = New Size(261, 43)
        DS1.TabIndex = 5
        ' 
        ' GF1
        ' 
        GF1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        GF1.Location = New Point(490, 318)
        GF1.Name = "GF1"
        GF1.Size = New Size(261, 43)
        GF1.TabIndex = 5
        ' 
        ' DIS1
        ' 
        DIS1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        DIS1.Location = New Point(911, 116)
        DIS1.Name = "DIS1"
        DIS1.Size = New Size(261, 43)
        DIS1.TabIndex = 5
        ' 
        ' NF1
        ' 
        NF1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        NF1.Location = New Point(911, 217)
        NF1.Name = "NF1"
        NF1.Size = New Size(261, 43)
        NF1.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(577, 73)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 31)
        Label5.TabIndex = 3
        Label5.Text = "Origin"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(550, 183)
        Label6.Name = "Label6"
        Label6.Size = New Size(131, 31)
        Label6.TabIndex = 3
        Label6.Text = "Destination"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(975, 183)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 31)
        Label7.TabIndex = 3
        Label7.Text = "Net Fare"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(970, 73)
        Label8.Name = "Label8"
        Label8.Size = New Size(104, 31)
        Label8.TabIndex = 3
        Label8.Text = "Discount"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(550, 284)
        Label9.Name = "Label9"
        Label9.Size = New Size(119, 31)
        Label9.TabIndex = 3
        Label9.Text = "Gross Fare"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1329, 555)
        Controls.Add(GF1)
        Controls.Add(NF1)
        Controls.Add(DS1)
        Controls.Add(DIS1)
        Controls.Add(OR1)
        Controls.Add(CB3)
        Controls.Add(CB1)
        Controls.Add(CB2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(BTN_PRO)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_PRO As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CB1 As ComboBox
    Friend WithEvents CB3 As ComboBox
    Friend WithEvents CB2 As ComboBox
    Friend WithEvents OR1 As TextBox
    Friend WithEvents DS1 As TextBox
    Friend WithEvents GF1 As TextBox
    Friend WithEvents DIS1 As TextBox
    Friend WithEvents NF1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
