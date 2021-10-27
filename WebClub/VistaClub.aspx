<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VistaClub.aspx.cs" Inherits="WebClub.VistaClub" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Apellido"></asp:Label>
            <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Fecha Nacimiento"></asp:Label>
            <asp:TextBox ID="txtFechaNacimiento" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Puesto"></asp:Label>
            <asp:DropDownList ID="ddlPuesto" runat="server"></asp:DropDownList>
            <br />
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Buscar por Puesto"></asp:Label>
            <asp:DropDownList ID="ddlBuscarPorPuesto" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlBuscarPorPuesto_SelectedIndexChanged"></asp:DropDownList>
            <br />
            <asp:GridView ID="gridJugadores" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
