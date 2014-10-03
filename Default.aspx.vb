
Partial Class _Default
    Inherits System.Web.UI.Page

    'Create variables for user-provided information
    Dim hourlyWage As Decimal
    Dim hoursWorked As Decimal
    Dim preTaxDeductions As Decimal
    Dim afterTaxDeductions As Decimal


    Protected Sub btn_CalculateNetPay_Click(sender As Object, e As EventArgs) Handles btn_CalculateNetPay.Click

        'Store user-provided information in variables created above
        hourlyWage = tb_HourlyWage.Text
        hoursWorked = tb_HoursWorked.Text
        preTaxDeductions = tb_PreTaxDeductions.Text
        afterTaxDeductions = tb_AfterTaxDeductions.Text

        'Compute gross pay
        Dim grossPay As Decimal = hourlyWage * hoursWorked

        'Calculate NetPay

        Dim netPay As Decimal

        If grossPay = "0" Then
            lbl_NetPay.Text = netPay.ToString("$ 0")

        ElseIf grossPay > "0" And grossPay < "500" Then
            netPay = ((grossPay - preTaxDeductions) * 0.82) - afterTaxDeductions
            'Display results
            lbl_NetPay.Text = netPay.ToString("$#,###.##")

        Else
            netPay = ((grossPay - preTaxDeductions) * 0.78) - afterTaxDeductions
            'Display results
            lbl_NetPay.Text = netPay.ToString("$#,###.##")

        End If

    End Sub

    Protected Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click

        'Clear user-provided variables
        tb_HourlyWage.Text = "0"
        tb_HoursWorked.Text = "0"
        tb_PreTaxDeductions.Text = "0"
        tb_AfterTaxDeductions.Text = "0"
        lbl_NetPay.Text = "$ 0"

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not IsPostBack Then
            'Clear user-provided variables
            tb_HourlyWage.Text = "0"
            tb_HoursWorked.Text = "0"
            tb_PreTaxDeductions.Text = "0"
            tb_AfterTaxDeductions.Text = "0"

        End If
    End Sub
End Class
