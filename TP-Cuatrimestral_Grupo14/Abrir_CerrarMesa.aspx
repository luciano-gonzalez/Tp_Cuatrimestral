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
                <li class="active" id="btnMenu">
                    <a href="#">
                        <i class="fa-solid fa-receipt"></i>
                        <div class="tooltip">Seleccionar Mesas</div>
                    </a>
                </li>
                
                <li id="btnConocimientos">
                    <a href="#">
                        <i class="fa-regular fa-circle-xmark"></i>
                        <div class="tooltip">Cerrar Mesas</div>
                    </a>
                </li>
                
          
            </ul>

        </nav>
    </div>
    <asp:UpdatePanel runat="server">
      <ContentTemplate>

    <div class="container_home" id="contMenu">
        <div class="contenido">
             <h1>Seleccionar Mesas</h1>
                <div class="col-6">
                    <div class="mb-3">
                        <label for="ddlmesa1" class="form-label">Mesa Seleccionada:</label>
                        <asp:DropDownList ID="ddlmesa1" CssClass="btn btn-secondary" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlmesa1_SelectedIndexChanged"></asp:DropDownList>
                    </div> 
                    <div class="mb-3">
                        <label for="ddlmesa2" class="form-label">Mesa Seleccionada:</label>
                        <asp:DropDownList ID="ddlmesa2" CssClass="btn btn-secondary" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlmesa1_SelectedIndexChanged"></asp:DropDownList>
                    </div>  
                    <div class="mb-3">
                        <label for="ddlmesa3" class="form-label">Mesa Seleccionada:</label>
                        <asp:DropDownList ID="ddlmesa3" CssClass="btn btn-secondary" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlmesa1_SelectedIndexChanged"></asp:DropDownList>
                    </div>  
                    <div class="mb-3">
                        <label for="ddlmesa4" class="form-label">Mesa Seleccionada:</label>
                        <asp:DropDownList ID="ddlmesa4" CssClass="btn btn-secondary" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlmesa1_SelectedIndexChanged"></asp:DropDownList>
                    </div>  
                    <div class="mb-3">
                        <label for="ddlmesa5" class="form-label">Mesa Seleccionada:</label>
                        <asp:DropDownList ID="ddlmesa5" CssClass="btn btn-secondary" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlmesa1_SelectedIndexChanged"></asp:DropDownList>
                    </div>  
                    <div class="mb-3">
                        <label for="ddlmesa6" class="form-label">Mesa Seleccionada:</label>
                        <asp:DropDownList ID="ddlmesa6" CssClass="btn btn-secondary" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlmesa1_SelectedIndexChanged"></asp:DropDownList>
                    </div> 
                    <div class="mb-3">
                        <label for="ddlmesa7" class="form-label">Mesa Seleccionada:</label>
                        <asp:DropDownList ID="ddlmesa7" CssClass="btn btn-secondary" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlmesa1_SelectedIndexChanged"></asp:DropDownList>
                    </div>  
                    <div class="mb-3">
                        <label for="ddlmesa8" class="form-label">Mesa Seleccionada:</label>
                        <asp:DropDownList ID="ddlmesa8" CssClass="btn btn-secondary" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlmesa1_SelectedIndexChanged"></asp:DropDownList>
                    </div>  
                    <div class="mb-3">
                        <label for="ddlmesa9" class="form-label">Mesa Seleccionada:</label>
                        <asp:DropDownList ID="ddlmesa9" CssClass="btn btn-secondary" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlmesa1_SelectedIndexChanged"></asp:DropDownList>
                    </div>  
                    <div class="mb-3">
                        <label for="ddlmesa10" class="form-label">Mesa Seleccionada:</label>
                        <asp:DropDownList ID="ddlmesa10" CssClass="btn btn-secondary" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlmesa1_SelectedIndexChanged"></asp:DropDownList>
                    </div>  
                    <asp:Button ID="resetearMesas" runat="server" Text="Resetear Mesas" OnClick="resetearMesas_Click" CssClass="btn btn-success" />
                <asp:Button Text="Confirmar Mesas" runat="server" ID="btnConfirmar" CssClass="btn btn-success" />
                </div>
            

         
        </div>
    </div>
    

                    </ContentTemplate>
            </asp:UpdatePanel>

    
    
   
        <script src="Scripts/botones.js"></script>

    </main>
</asp:Content>