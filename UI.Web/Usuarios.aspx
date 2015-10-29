<%@ Page Title="Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="60px">
        <asp:GridView ID="dgvUsuarios" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" style="margin-top: 0px">
            <Columns>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="NombreUsuario" HeaderText="NombreUsuario" />
                <asp:BoundField DataField="Habilitado" HeaderText="Habilitado" />
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
            <SelectedRowStyle BackColor="Black" ForeColor="White" />
        </asp:GridView>
    </asp:Panel>
</asp:Content>
