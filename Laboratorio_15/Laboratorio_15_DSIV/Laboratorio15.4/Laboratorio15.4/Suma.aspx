<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Suma.aspx.cs" Inherits="Laboratorio15._4.Suma" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Suma de Dos Números</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Aplicación de Suma de Dos Números</h2>

            <asp:Label ID="lblNumero1" runat="server" Text="Número 1:" />
            <asp:TextBox ID="txtNumero1" runat="server" />
            <br />
            <br />

            <asp:Label ID="lblNumero2" runat="server" Text="Número 2:" />
            <asp:TextBox ID="txtNumero2" runat="server" />
            <br />
            <br />

            <asp:Button ID="btnSumar" runat="server" Text="Sumar" OnClick="btnSumar_Click" />
            <br />
            <br />

            <asp:Label ID="lblResultado" runat="server" Text="Resultado:" />
        </div>
    </form>
</body>
</html>
