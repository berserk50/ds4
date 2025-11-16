<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio_15_4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            SUMATORIA</div>
        Inserte los numeros que desea sumar en los siguientes recuadros:<br />
        <asp:Label ID="Label1" runat="server" Text="Numero:"></asp:Label>
        <asp:TextBox ID="Numero1" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Numero:"></asp:Label>
            <asp:TextBox ID="Numero2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SUMAR" />
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Resultado"></asp:Label>
            <asp:TextBox ID="Resultado" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
