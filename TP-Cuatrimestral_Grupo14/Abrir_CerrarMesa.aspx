<%@ Page Title="Abrir/Cerrar Dia" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Abrir_CerrarMesa.aspx.cs" Inherits="TP_Cuatrimestral_Grupo14.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
   
    
    <meta charset="utf-8">
    <meta name = "viewport" content="width=device-width">

    <meta name="description" content = "portfolio de González Luciano">
    <meta name="url" content="https://lucianoGonzález.com">
    <link rel = "icon" href="chico.ico">
    
    <script src="https://kit.fontawesome.com/fb3527f234.js" crossorigin="anonymous"></script>
    <link href="Content/estilos.css" rel="stylesheet" />    
    

    
    <div class="cont_bg">
        <div class="efect_bg"></div>
    </div>
    <div class="cont_sidebar">
        <nav class="sidebar">
            <ul class="nav">
                <li id="btnConocimientos">
                    <a href="#">
                        <i class="fa-solid fa-brain"></i>
                        <div class="tooltip">Conocimientos</div>
                    </a>
                </li>
                <li id="btnProyectos">
                    <a href="#">
                        <i class="fa-solid fa-diagram-project"></i>
                        <div class="tooltip">Proyectos</div>
                    </a>
                </li>
          
            </ul>

        </nav>
    </div>

    
    <div class="container_Conocimiento" id="contConocimiento">
        <div class="contenido">
            <div>
    <h3>Abrir Dia</h3>
    <ul>
        <% for (int i = 1; i <= 10; i++) { %>
            <li>
                Mesa <%= i %>: 
                <asp:TextBox ID="TxtAbrir" runat="server" TextMode="SingleLine" onkeydown="return (event.keyCode !== 187);" MaxLength="50"></asp:TextBox>
            </li>
        <% } %>
    </ul>
    
</div>
            </div>
    </div>
    <div class="container_Proyectos" id="contProyectos">
        <div class="contenido">
            
            <h3>Cerrar Dia</h3>
            
        </div>
    </div>
   
        <script src="Scripts/botones.js"></script>

    </main>

</asp:Content>
