<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_011.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Is
        <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
&nbsp; equal to&nbsp;
        <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
&nbsp; ?<br />
        <br />
        <asp:CheckBox ID="catcheckBox" runat="server" OnCheckedChanged="catcheckBox_CheckedChanged" Text="Do you like cats?" />
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" BackColor="#3399FF" BorderStyle="Groove" OnClick="okButton_Click" Text="OK" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <asp:Label ID="catLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
