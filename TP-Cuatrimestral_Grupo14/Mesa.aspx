<%@ Page Title="Asignar Mesa" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mesa.aspx.cs" Inherits="TP_Cuatrimestral_Grupo14.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/estilos.css" rel="stylesheet" />
    <link href="Content/estilosinicio.css" rel="stylesheet" />
    <div class="mesas-container" id="mesasContainer">


        <% for (int i = 1; i <= 10; i++) { %>
            <div class="mesa <%= i <= 8 ? "cuadrada" : "rectangular" %>">
                <%= i %>
                <div class="botones-container">
                    <button id="Button1" class="boton verde" onclick="CambiarColor(this);" data-color="verde" runat="server"></button>
                </div>
            </div>
        <% } %>
    </div>
    
</asp:Content>
