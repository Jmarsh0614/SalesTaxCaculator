<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesTaxCalculator
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblStoreName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.btnDisplayCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblItenName = New System.Windows.Forms.Label()
        Me.lblItemCost = New System.Windows.Forms.Label()
        Me.mktxtItemCost = New System.Windows.Forms.MaskedTextBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblCurrenySymbol = New System.Windows.Forms.Label()
        Me.lblSalesTax = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(48, 170)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(402, 24)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Item Total Cost Calculator (with Sales Tax)"
        '
        'lblStoreName
        '
        Me.lblStoreName.AutoSize = True
        Me.lblStoreName.BackColor = System.Drawing.Color.Salmon
        Me.lblStoreName.Font = New System.Drawing.Font("Lucida Calligraphy", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStoreName.Location = New System.Drawing.Point(181, 12)
        Me.lblStoreName.Name = "lblStoreName"
        Me.lblStoreName.Size = New System.Drawing.Size(137, 36)
        Me.lblStoreName.TabIndex = 1
        Me.lblStoreName.Text = "YouBuy"
        Me.lblStoreName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SalesTaxCaculator.My.Resources.Resources.YouBuy
        Me.PictureBox1.Location = New System.Drawing.Point(62, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(374, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'txtItemName
        '
        Me.txtItemName.BackColor = System.Drawing.SystemColors.Window
        Me.txtItemName.Location = New System.Drawing.Point(52, 217)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(100, 20)
        Me.txtItemName.TabIndex = 3
        '
        'btnDisplayCost
        '
        Me.btnDisplayCost.Location = New System.Drawing.Point(118, 319)
        Me.btnDisplayCost.Name = "btnDisplayCost"
        Me.btnDisplayCost.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplayCost.TabIndex = 4
        Me.btnDisplayCost.Text = "Display Cost"
        Me.btnDisplayCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(212, 319)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(306, 319)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblItenName
        '
        Me.lblItenName.AutoSize = True
        Me.lblItenName.Location = New System.Drawing.Point(52, 198)
        Me.lblItenName.Name = "lblItenName"
        Me.lblItenName.Size = New System.Drawing.Size(58, 13)
        Me.lblItenName.TabIndex = 5
        Me.lblItenName.Text = "Item Name"
        '
        'lblItemCost
        '
        Me.lblItemCost.AutoSize = True
        Me.lblItemCost.Location = New System.Drawing.Point(52, 244)
        Me.lblItemCost.Name = "lblItemCost"
        Me.lblItemCost.Size = New System.Drawing.Size(51, 13)
        Me.lblItemCost.TabIndex = 6
        Me.lblItemCost.Text = "Item Cost"
        '
        'mktxtItemCost
        '
        Me.mktxtItemCost.Location = New System.Drawing.Point(52, 261)
        Me.mktxtItemCost.Name = "mktxtItemCost"
        Me.mktxtItemCost.Size = New System.Drawing.Size(100, 20)
        Me.mktxtItemCost.TabIndex = 7
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(183, 237)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(225, 20)
        Me.lblTotalCost.TabIndex = 8
        Me.lblTotalCost.Text = "Your Item Cost : $XXX.XX "
        '
        'lblCurrenySymbol
        '
        Me.lblCurrenySymbol.AutoSize = True
        Me.lblCurrenySymbol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrenySymbol.Location = New System.Drawing.Point(31, 261)
        Me.lblCurrenySymbol.Name = "lblCurrenySymbol"
        Me.lblCurrenySymbol.Size = New System.Drawing.Size(15, 16)
        Me.lblCurrenySymbol.TabIndex = 9
        Me.lblCurrenySymbol.Text = "$"
        '
        'lblSalesTax
        '
        Me.lblSalesTax.AutoSize = True
        Me.lblSalesTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesTax.Location = New System.Drawing.Point(187, 274)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(177, 20)
        Me.lblSalesTax.TabIndex = 10
        Me.lblSalesTax.Text = "Sales Tax : $XXX.XX"
        '
        'frmSalesTaxCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(499, 395)
        Me.Controls.Add(Me.lblSalesTax)
        Me.Controls.Add(Me.lblCurrenySymbol)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.mktxtItemCost)
        Me.Controls.Add(Me.lblItemCost)
        Me.Controls.Add(Me.lblItenName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayCost)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.lblStoreName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmSalesTaxCalculator"
        Me.Text = "                                                     YouBuy Cost Calculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblStoreName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents btnDisplayCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblItenName As Label
    Friend WithEvents lblItemCost As Label
    Friend WithEvents mktxtItemCost As MaskedTextBox
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblCurrenySymbol As Label
    Friend WithEvents lblSalesTax As Label
End Class
