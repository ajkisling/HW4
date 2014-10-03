<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AJ's Net Pay Calculator</title>
    <link rel="stylesheet" type="text/css" href="./css/Style.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>
            <img src="./EspressoShots.jpg" alt="Expresso Shots" title="Expresso Shots" class="img" />
            <br />

            AJ&#39;s Coffee House
            <br />
            Intranet Site
        </h1>

        <h2>
            Employee Net Pay Calculator
        </h2>    
       
        <%If Not IsPostBack Then%>

        Hourly wage:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tb_HourlyWage" runat="server" style="margin-left: 74px"></asp:TextBox>
        <br />
        <br />
        Hours worked this week:
        <asp:TextBox ID="tb_HoursWorked" runat="server" style="margin-left: 5px"></asp:TextBox>
        <br />
        <br />
        Pre-tax deductions:&nbsp;
        <asp:TextBox ID="tb_PreTaxDeductions" runat="server" style="margin-left: 41px"></asp:TextBox>
        <br />
        <br />
        After-tax deductions:
        <asp:TextBox ID="tb_AfterTaxDeductions" runat="server" style="margin-left: 25px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btn_CalculateNetPay" runat="server" Text="Calculate Net Pay" BackColor="#FF0066" Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="14pt" />

        <%Else%>

        <br />
        Your net pay this week is:&nbsp; <asp:Label ID="lbl_NetPay" runat="server"></asp:Label>

        <%End If%>
    
    </div>
    </form>
</body>
</html>
