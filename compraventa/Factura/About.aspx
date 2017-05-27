<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="compraventa.Factura.About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../JS/jquery-3.1.1.min.js" type="text/javascript"></script>
    <%-- DatePicker --%>
    <link rel="stylesheet" href="../JS/Datepicker/jquery-ui.css" />
    <link rel="stylesheet" href="../JS/Datepicker/Style.css" />
    <script src="../JS/Datepicker/jquery-1.12.4.js"></script>
    <script src="../JS/Datepicker/jquery-ui.js"></script>
    <link rel="icon" type="image/png" href="https://image.flaticon.com/icons/png/512/294/294436.png" />
    <%-- Librerias del MDL, URL o descargadas --%>
    <%-- El Meta Viewport --%>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="../mdl/material.min.css" />
    <script defer src="../mdl/material.min.js"></script>
    <link rel="stylesheet" href="../mdl/material-icons/Material-Icons.css" />
    <%--<link rel="stylesheet" href="https://code.getmdl.io/1.3.0/material.indigo-pink.min.css" />
    <script defer src="https://code.getmdl.io/1.3.0/material.min.js"></script>
    <link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons" />--%>

    <%--Librerias para el Select getmdl-select--%>
    <link rel="stylesheet" href="../mdl/select/selectfield.min.css" />
    <script defer src="../mdl/select/selectfield.min.js"></script>
    <%--<link rel="stylesheet" href="https://rawgit.com/MEYVN-digital/mdl-selectfield/master/mdl-selectfield.min.css" />
    <script defer src="https://rawgit.com/MEYVN-digital/mdl-selectfield/master/mdl-selectfield.min.js"></script>--%>
    <link rel="stylesheet" href="../CSS/Generales.css" />
    <script src="../FuncionesGlobales.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">

    <h4>&nbsp;</h4>
    <h2>Desempeños</h2>
    <p>
        Cedula
    <asp:TextBox ID="TextBox1" runat="server" Width="141px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox1" ErrorMessage="Ingrese valores numericos" ValidationExpression="^[0-9]*"></asp:RegularExpressionValidator>
        &nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buscar" Width="84px" />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p>
        &nbsp;
    </p>
    <p>
        &nbsp;
    </p>
    <p>
        ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="114px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Ingrese valores numericos" ValidationExpression="^[0-9]*"></asp:RegularExpressionValidator>
        <%-- <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="IMPRIMIR" Width="91px" />--%>
    &nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="Imprimir" />
    </p>
</asp:Content>
