
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btn_CalculateNetPay_Click(sender As Object, e As EventArgs) Handles btn_CalculateNetPay.Click

        'Specify constant values

        'Create variables for user provided information
        Dim hourlyWage As Decimal = tb_HourlyWage.Text
        Dim hoursWorked As Decimal = tb_HoursWorked.Text
        Dim preTaxDeductions As Decimal = tb_PreTaxDeductions.Text
        Dim afterTaxDeductions As Decimal = tb_AfterTaxDeductions.Text

        'Compute gross pay
        Dim grossPay As Decimal = hourlyWage * hoursWorked

        'Calculate NetPay
        Dim netPay As Decimal
        If grossPay < "500" Then
            netPay = ((grossPay - preTaxDeductions) * 0.82) - afterTaxDeductions
        Else
            netPay = ((grossPay - preTaxDeductions) * 0.78) - afterTaxDeductions
        End If

        'Display results
        lbl_NetPay.Text = netPay.ToString("$#,###.##")


    End Sub
End Class
