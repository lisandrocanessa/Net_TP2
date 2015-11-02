<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alumnos.aspx.cs" Inherits="UI.Web.Alumnos" %>
<asp:Content ID="alumnos" ContentPlaceHolderID="cplCenter" runat="server">
    <ul class="nav nav-tabs" id="tablist">
        <li class="alert-link"><a href="Alumnos.aspx">Home</a></li>
        <li class="alert-link"><a href="Alumno/InscribirMateria.aspx">Inscribir a Materias</a></li>
        <li class="alert-link"><a href="Alumno/EstadoAcademico.aspx">Estado Académico</a></li>
        <li class="alert-link"><a href="Alumno/PlanEstudio.aspx">Plan de Estudio</a></li>
        <li class="alert-link"><a href="Login.aspx">Cerrar Sesión</a></li>
    </ul>

</asp:Content>



