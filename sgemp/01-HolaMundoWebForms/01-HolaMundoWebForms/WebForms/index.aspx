<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="_01_HolaMundoWebForms.WebForms.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"> Nombre:
            </asp:Label>  
            <asp:TextBox ID="nombre" runat="server" style="margin-bottom: 0px"></asp:TextBox>
            <asp:RadioButtonList ID="radioSaludo" runat="server">
            <asp:ListItem>Hola</asp:ListItem>
            <asp:ListItem>Buenos dias</asp:ListItem>
            <asp:ListItem>Buenas tardes</asp:ListItem>
        </asp:RadioButtonList>
            <asp:Button ID="saludar" runat="server" Text="Saludar" OnClick="Saludar_Click" />
        </div>
        <asp:Label ID="saludo" runat="server" Text=" " Visible="false"></asp:Label>
        
    </form>
</body>
</html>
