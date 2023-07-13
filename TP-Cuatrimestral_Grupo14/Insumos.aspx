<%@ Page Title="Insumos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Insumos.aspx.cs" Inherits="TP_Cuatrimestral_Grupo14._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main aria-labelledby="title">
   
    
    <meta charset="utf-8">
    <meta name = "viewport" content="width=device-width">

    <meta name="description" content = "portfolio de González Luciano">
    <meta name="url" content="https://lucianoGonzález.com">
    <link rel = "icon" href="chico.ico">
    
    <script src="https://kit.fontawesome.com/fb3527f234.js" crossorigin="anonymous"></script>
    <link href="Content/estilos.css" rel="stylesheet" />    
    

    <main aria-labelledby="title">
   
    
    <meta charset="utf-8">
    <meta name = "viewport" content="width=device-width">

    <meta name="description" content = "portfolio de González Luciano">
    <meta name="url" content="https://lucianoGonzález.com">
    <link rel = "icon" href="chico.ico">
    
    <script src="https://kit.fontawesome.com/fb3527f234.js" crossorigin="anonymous"></script>
    <link href="Content/estilos.css" rel="stylesheet" />    
    

    </main>
    <div class="cont_bg">
        <div class="efect_bg"></div>
    </div>
    <div class="cont_sidebar">
        <nav class="sidebar">
            <ul class="nav">
                <li id="btnConocimientos">
                    <a href="#">
                        <i class="fa-solid fa-burger"></i>
                        <div class="tooltip">Stock</div>
                    </a>
                </li>
                <li id="btnProyectos">
                    <a href="#">
                        <i class="fa-solid fa-bottle-water"></i>
                        <div class="tooltip">bebidas</div>
                    </a>
                </li>
                <li class="active" id="btnMenu">
                    <a href="#">
                        <i class="fa-solid fa-carrot"></i>
                        <div class="tooltip">Insumo</div>
                    </a>
                </li>
          
            </ul>

        </nav>
    </div>

    <div class="container_home" id="contMenu">
        <div class="contenido">
             <h1>Stock de Insumos</h1>
            
            <asp:GridView ID="gvStockInsumos" runat="server" CssClass="table" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Stock" HeaderText="Stock Total" />
                </Columns>
            </asp:GridView>
         
        </div>
    </div>
    <div class="container_Conocimiento" id="contConocimiento">
        <div class="contenido">
            <h1>Stock de Platos</h1>
            <asp:GridView ID="gvStockPlatos" runat="server" CssClass="table" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="NombrePlato" HeaderText="Nombre del Plato" />
                    <asp:BoundField DataField="StockTotalPlato" HeaderText="Stock Total del Plato" />
                </Columns>
            </asp:GridView>
            </div>
    </div>
    <div class="container_Proyectos" id="contProyectos">
        <div class="contenido">
            <h1>Stock de Bebidas</h1>
            <asp:GridView ID="gvStockBebidas" runat="server" CssClass="table" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="StockTotalBebidas" HeaderText="Stock Total de Bebidas" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
   
        <script src="Scripts/botones.js"></script>

    </main>

</asp:Content>
