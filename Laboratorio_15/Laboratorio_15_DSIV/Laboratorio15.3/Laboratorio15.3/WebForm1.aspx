<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio15._3.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>WebForm1.aspx</title>
    <script type="text/javascript">
        function showMessage() {
            var message = "Hola " + document.getElementById('<%= txtInput.ClientID %>').value;  
            alert(message); 
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="txtInput">Introduce un texto:</label>
            <asp:TextBox ID="txtInput" runat="server" Width="300px"></asp:TextBox><br /><br />
            <asp:Button ID="btnShowMessage" runat="server" Text="Enviar Saludo!" 
                        OnClientClick="showMessage(); return false;" />
        </div>
    </form>
</body>
</html>