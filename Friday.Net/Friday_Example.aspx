<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Friday_Example.aspx.cs" Inherits="Friday.Net.Friday_Example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Cuma Çalışması</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlCountry" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged"></asp:DropDownList>
            <hr />
          
            <hr />
            <asp:ListBox ID="lstIsciler" runat="server" eight="500" Width="500" OnSelectedIndexChanged="lstIsciler_SelectedIndexChanged"></asp:ListBox>

        </div>
    </form>
</body>
</html>
