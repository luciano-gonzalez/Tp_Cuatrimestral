<%@ Page Title="Asignar Mesa" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mesa.aspx.cs" Inherits="TP_Cuatrimestral_Grupo14.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/estilos.css" rel="stylesheet" />
    <link href="Content/estilosinicio.css" rel="stylesheet" />

    <d
        iv class="mesas-container" id="mesasContainer">
        <div class="mesa cuadrada">
            <div class="mesa-content" id="MesaContent1">1</div>
            <div class="form-container">
                <div class="mb-3">
                    <label for="TxtNombre1" class="form-label">Nombre del cliente</label>
                    <asp:TextBox ID="TxtNombre1" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="TxtMonto1" class="form-label">Monto total</label>
                    <asp:TextBox ID="TxtMonto1" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                </div>
            </div>
            <div class="boton-container">
                <asp:Button ID="BtnLiberar1" runat="server" Text="Liberar pedido" CssClass="boton" OnClick="LiberarPedidoButton_Click" />
            </div>
        </div>
        <div class="mesa cuadrada">
            <div class="mesa-content" id="MesaContent2">2</div>
            <div class="form-container">
                <div class="mb-3">
                    <label for="TxtNombre2" class="form-label">Nombre del cliente</label>
                    <asp:TextBox ID="TxtNombre2" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="TxtMonto2" class="form-label">Monto total</label>
                    <asp:TextBox ID="TxtMonto2" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                </div>
            </div>
            <div class="boton-container">
                <asp:Button ID="BtnLiberar2" runat="server" Text="Liberar pedido" CssClass="boton" OnClick="LiberarPedidoButton_Click" />
            </div>
        </div>
        <div class="mesa cuadrada">
            <div class="mesa-content" id="MesaContent3">3</div>
            <div class="form-container">
                <div class="mb-3">
                    <label for="TxtNombre3" class="form-label">Nombre del cliente</label>
                    <asp:TextBox ID="TxtNombre3" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="TxtMonto3" class="form-label">Monto total</label>
                    <asp:TextBox ID="TxtMonto3" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                </div>
            </div>
            <div class="boton-container">
                <asp:Button ID="BtnLiberar3" runat="server" Text="Liberar pedido" CssClass="boton" OnClick="LiberarPedidoButton_Click" />
            </div>
        </div>
        <div class="mesa cuadrada">
            <div class="mesa-content" id="MesaContent4">4</div>
            <div class="form-container">
                <div class="mb-3">
                    <label for="TxtNombre4" class="form-label">Nombre del cliente</label>
                    <asp:TextBox ID="TxtNombre4" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="TxtMonto4" class="form-label">Monto total</label>
                    <asp:TextBox ID="TxtMonto4" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                </div>
            </div>
            <div class="boton-container">
                <asp:Button ID="BtnLiberar4" runat="server" Text="Liberar pedido" CssClass="boton" OnClick="LiberarPedidoButton_Click" />
            </div>
        </div>
    <div class="mesa cuadrada">
            <div class="mesa-content" id="MesaContent5">5</div>
            <div class="form-container">
                <div class="mb-3">
                    <label for="TxtNombre5" class="form-label">Nombre del cliente</label>
                    <asp:TextBox ID="TxtNombre5" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="TxtMonto5" class="form-label">Monto total</label>
                    <asp:TextBox ID="TxtMonto5" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                </div>
            </div>
            <div class="boton-container">
                <asp:Button ID="BtnLiberar5" runat="server" Text="Liberar pedido" CssClass="boton" OnClick="LiberarPedidoButton_Click" />
            </div>
        </div>
    <div class="mesa cuadrada">
            <div class="mesa-content" id="MesaContent6">6</div>
            <div class="form-container">
                <div class="mb-3">
                    <label for="TxtNombre6" class="form-label">Nombre del cliente</label>
                    <asp:TextBox ID="TxtNombre6" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="TxtMonto6" class="form-label">Monto total</label>
                    <asp:TextBox ID="TxtMonto6" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                </div>
            </div>
            <div class="boton-container">
                <asp:Button ID="BtnLiberar6" runat="server" Text="Liberar pedido" CssClass="boton" OnClick="LiberarPedidoButton_Click" />
            </div>
        </div>
<div class="mesa cuadrada">
            <div class="mesa-content" id="MesaContent7">7</div>
            <div class="form-container">
                <div class="mb-3">
                    <label for="TxtNombre7" class="form-label">Nombre del cliente</label>
                    <asp:TextBox ID="TxtNombre7" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="TxtMonto7" class="form-label">Monto total</label>
                    <asp:TextBox ID="TxtMonto7" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                </div>
            </div>
            <div class="boton-container">
                <asp:Button ID="BtnLiberar7" runat="server" Text="Liberar pedido" CssClass="boton" OnClick="LiberarPedidoButton_Click" />
            </div>
        </div>
<div class="mesa cuadrada">
            <div class="mesa-content" id="MesaContent8">8</div>
            <div class="form-container">
                <div class="mb-3">
                    <label for="TxtNombre8" class="form-label">Nombre del cliente</label>
                    <asp:TextBox ID="TxtNombre8" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="TxtMonto8" class="form-label">Monto total</label>
                    <asp:TextBox ID="TxtMonto8" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                </div>
            </div>
            <div class="boton-container">
                <asp:Button ID="BtnLiberar8" runat="server" Text="Liberar pedido" CssClass="boton" OnClick="LiberarPedidoButton_Click" />
            </div>
        </div>
<div class="mesa cuadrada">
            <div class="mesa-content" id="MesaContent9">9</div>
            <div class="form-container">
                <div class="mb-3">
                    <label for="TxtNombre9" class="form-label">Nombre del cliente</label>
                    <asp:TextBox ID="TxtNombre9" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="TxtMonto9" class="form-label">Monto total</label>
                    <asp:TextBox ID="TxtMonto9" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                </div>
            </div>
            <div class="boton-container">
                <asp:Button ID="BtnLiberar9" runat="server" Text="Liberar pedido" CssClass="boton" OnClick="LiberarPedidoButton_Click" />
            </div>
        </div>
<div class="mesa cuadrada">
            <div class="mesa-content" id="MesaContent10">10</div>
            <div class="form-container">
                <div class="mb-3">
                    <label for="TxtNombre10" class="form-label">Nombre del cliente</label>
                    <asp:TextBox ID="TxtNombre10" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="TxtMonto10" class="form-label">Monto total</label>
                    <asp:TextBox ID="TxtMonto10" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                </div>
            </div>
            <div class="boton-container">
                <asp:Button ID="BtnLiberar10" runat="server" Text="Liberar pedido" CssClass="boton" OnClick="LiberarPedidoButton_Click" />
            </div>
        </div>
    </d>
    
       
      <script>
          function LiberarPedido(mesaIndex) {
              var mesaContent = document.getElementById('MesaContent' + mesaIndex).innerHTML;

              if (mesaContent.trim() === '') {
                  alert('La mesa no tiene un pedido asignado.');
                  return false; // Evita enviar el formulario al servidor
              }

              // Realiza la acciÃ³n en el servidor
              return true;
          }
      </script>
</asp:Content>
