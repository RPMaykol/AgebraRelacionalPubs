<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OperacionesUnarias.aspx.cs" Inherits="ADONetEF2.OperacionesUnarias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <p>Operaciones Unarias - Seleccion</p>
 <p>
     <asp:Button Text="Consulta 1" runat="server" ID="btnConsulta1" OnClick="btnConsulta1_Click" />
     <asp:Button Text="Consulta 2" runat="server" ID="btnConsulta2" OnClick="btnConsulta2_Click"/>
     <asp:Button Text="Consulta 3" runat="server" ID="btnConsulta3" OnClick="btnConsulta3_Click"/>
     <asp:Button Text="Consulta 4" runat="server" ID="btnConsulta4" OnClick="btnConsulta4_Click" />
     <asp:Button Text="Consulta 5" runat="server" ID="btnConsulta5" OnClick="btnConsulta5_Click"/>
     <asp:Button Text="Consulta 6" runat="server" ID="btnConsulta6" OnClick="btnConsulta6_Click"/>
     <asp:Button Text="Consulta 7" runat="server" ID="btnConsulta7" OnClick="btnConsulta7_Click"/>
 </p>
 <p>
     <asp:Button Text="Consulta 8" runat="server" ID="btnConsulta8" OnClick="btnConsulta8_Click"/>
     <asp:Button Text="Consulta 9" runat="server" ID="btnConsulta9" OnClick="btnConsulta9_Click"/>
 </p>
 <p>
     <asp:GridView runat="server" ID="gvConsulta"></asp:GridView>
 </p>
        </div>
    </form>
</body>
</html>
