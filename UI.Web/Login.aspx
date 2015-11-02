<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Web.Login" %>
<asp:Content ID="login" ContentPlaceHolderID="cplCenter" runat="server">
    <div class="panel panel-default" style="width:58%; margin:0 auto; margin-top:50px;">
        <form class="form-horizontal" runat="server">
            
          <div class="form-group">
              <br />
            <label for="inputEmail3" class="col-sm-2 control-label">Usuario: </label>
            <div class="col-sm-10">
              <input type="text" class="form-control" id="txtusu" runat="server" />
            </div>
          </div>
          <div class="form-group">
            <label for="inputPassword3" class="col-sm-2 control-label">Contraseña: </label>
            <div class="col-sm-10">
              <input type="password" class="form-control" id="txtPass" runat="server"/>
            </div>
          </div>
          <div class="form-group">
            <div class="col-sm-offset-2 col-sm-10">
              <asp:Button ID="btnLogin" runat="server" Text="Ingresar" cssclass="btn btn-default" OnClick="btnLogin_Click"/>
            </div>
              <div style="text-align:center;">
                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            </div>
          </div>
        </form>
    </div>
</asp:Content>