<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InscribirMateria.aspx.cs" Inherits="UI.Web.Alumno.InscribirMateria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cplCenter" runat="server">
    <form id="form1" runat="server">
    <ul class="nav nav-tabs" id="tablist">
        <li class="alert-link"><a href="Alumnos.aspx">Home</a></li>
        <li class="alert-link"><a href="InscribirMateria.aspx">Inscribir a Materias</a></li>
        <li class="alert-link"><a href="EstadoAcademico.aspx">Estado Académico</a></li>
        <li class="alert-link"><a href="PlanEstudio.aspx">Plan de Estudio</a></li>
        <li class="alert-link"><a href="../Login.aspx">Cerrar Sesión</a></li>
    </ul>
    <br />
    <br />
    <br />
    <div style="text-align:center">
        <b>Materias disponibles:</b>
    </div>
    <div style="text-align:center">
        <asp:DropDownList ID="ddlMaterias" runat="server" Height="17px" Width="205px">
        </asp:DropDownList>
    </div>
    <div>

        <asp:GridView ID="dgvMaterias" runat="server">
        </asp:GridView>

    </div>


    </form>


</asp:Content>
