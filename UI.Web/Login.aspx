<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Web.Login" %>
<asp:Content ID="login" ContentPlaceHolderID="cplCenter" runat="server">
    <div>
        <form runat="server">
        <div class="login-box">
            <div style="height:55%;">
                <div style="width:50%; float:left;">
                    <br />
                    <br />
                    <p style="text-align:center; font-size:large;"> Usuario: </p>
                    <p style="text-align:center; font-size:large;"> Contraseña:</p>
                    <br />
                </div>

                <div style="width:50%; float:right; height: 128px;"> 
                    <asp:TextBox ID="txtUsu" runat="server" style="margin-top:40px;"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="txtPass" runat="server" style="margin-top:10px;"></asp:TextBox>
                </div>
            </div>
            <div style="text-align:center;">
                <asp:Button ID="btnLogin" runat="server" Text="Log In"  style="margin:0 auto; position:relative; width:100px;" OnClick="btnLogin_Click"/>
            </div>
            <div>
                <asp:Label id="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
            </div>
        </div>
        </form>
    </div>
</asp:Content>