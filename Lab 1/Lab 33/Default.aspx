<%@  Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab_33._Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple Interest Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Simple Interest Calculator</h2>
            <p>
                Principal (P): <asp:TextBox ID="txtPrincipal" runat="server"></asp:TextBox>
            </p>
            <p>
                Rate of Interest (R): <asp:TextBox ID="txtRate" runat="server"></asp:TextBox>
            </p>
            <p>
                Time (T): <asp:TextBox ID="txtTime" runat="server"></asp:TextBox>
            </p>
            <asp:Button ID="btnCalculate" Text="Calculate Interest" OnClick="btnCalculate_Click" runat="server" />
        </div>
    </form>
</body>
</html>
