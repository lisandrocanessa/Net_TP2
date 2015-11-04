<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="UI.Web.Admin" %>
<asp:Content ID="admin" ContentPlaceHolderID="cplCenter" runat="server">
    <ul class="nav nav-pills">
        <li class="active"><a href="Admin.aspx">Home</a></li>
        <!--no funca el dropdown-->
        <li class="dropdown"  id="dropdownAdmin">
            <a class="dropdown-toggle" data-toggle="dropdown">Administrador <span class="caret"></span></a>
            <ul class="dropdown-menu">
                <li><a href="#">Usuarios</a></li>
                <li><a href="#">Especialidades</a></li>
                <li><a href="#">Planes y Materias</a></li>
                <li><a href="#">Cursos y comisiones</a></li>
            </ul>
        </li>
    </ul>
</asp:Content>
