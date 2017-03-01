Option Strict On


Public Class frmSalesTaxCalculator

    Const _cdecSalesTax As Decimal = 1.0875D
    'This Declares a Class level Constant as a decimal for the sales tax 




    Private Sub btnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        Dim strItemName As String = txtItemName.Text
        Dim decItemCost As Decimal = Convert.ToDecimal(mktxtItemCost.Text)
        Dim decTotalCost As Decimal = decItemCost * _cdecSalesTax
        Dim decSalesTax As Decimal = decTotalCost - decItemCost
        lblTotalCost.Text = "Your " & strItemName & " Cost: " &
            decTotalCost.ToString("C")
        lblSalesTax.Text = "Sales Tax: " & decSalesTax.ToString("C")

    End Sub



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblTotalCost.Text = " "
        txtItemName.Text = " "
        mktxtItemCost.Text = " "
        lblSalesTax.Text = " "
    End Sub

    Private Sub frmSalesTaxCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotalCost.Text = " "
        lblSalesTax.Text = " "
        txtItemName.Focus()


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub


End Class
