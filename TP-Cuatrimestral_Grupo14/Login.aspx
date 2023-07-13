<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TP_Cuatrimestral_Grupo14.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
  <div class="mb-3">
      <asp:Label Text="Usuario" runat="server" CssClass="form-label"/>
      <asp:TextBox runat="server" ID="txtUsuario" CssClass="form-control" />
  </div>
  <div class="mb-3">
    <asp:Label Text="Contraseña" runat="server" CssClass="form-label"/>
    <asp:TextBox runat="server" ID="txtContraseña" CssClass="form-control" TextMode="Password"  />
  </div>
    
  
    <asp:Button Text="Ingresar" runat="server" ID="BtnIngresar" CssClass="btn btn-success" OnClick="BtnIngresar_Click" />

</asp:Content>
