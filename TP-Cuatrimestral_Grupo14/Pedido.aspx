<%@ Page Title="Pedido" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pedido.aspx.cs" Inherits="TP_Cuatrimestral_Grupo14.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/estilos.css" rel="stylesheet" />
    
    <h2>Pedidos</h2>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="row">
                <div class="col-6">
                    <asp:Label Text="Nombre plato (Opcional)" runat="server" />
                    <div class="mb-3">
                        <asp:DropDownList ID="ddlPlatos" CssClass="btn btn-secondary dropdown-toggle" runat="server">
                        </asp:DropDownList>
                        <asp:Button Text="+" CssClass="btn btn-secondary" runat="server" ID="btn_plato" OnClick="btn_plato_Click" />
                        <asp:Label ID="lblPlatosSeleccionados" runat="server" />
                    </div>
                    <asp:Label Text="Nombre Bebida (Opcional)" runat="server" />
                    <div class="mb-3">
                        <asp:DropDownList ID="ddlBebidas" CssClass="btn btn-secondary dropdown-toggle" runat="server"  AutoPostBack="true">
                        </asp:DropDownList>
                        <asp:Button Text="+" CssClass="btn btn-secondary" runat="server" ID="btn_bebida" OnClick="btn_bebida_Click" />
                        <asp:Label ID="lblBebidasSeleccionadas" runat="server" />
                    </div>
            <!-- GridView para mostrar platos seleccionados -->
                </div>

                <div class="col-6">
                    <div class="mb-3">
                        <label for="Txtnombre" class="form-label">Nombre del cliente</label>
                        <asp:TextBox ID="Txtnombre" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="Txtmesa" class="form-label">Mesa</label>
                        <asp:DropDownList CssClass="btn btn-secondary" runat="server" ID="ddlmesa">
                            <asp:ListItem Text="0" />
                            <asp:ListItem Text="1" />
                            <asp:ListItem Text="2" />
                            <asp:ListItem Text="3" />
                            <asp:ListItem Text="4" />
                            <asp:ListItem Text="5" />
                            <asp:ListItem Text="6" />
                            <asp:ListItem Text="7" />
                            <asp:ListItem Text="8" />
                            <asp:ListItem Text="9" />
                            <asp:ListItem Text="10" />
                        </asp:DropDownList>
                    </div>
                    <div class="mb-3">
                        <label for="TxtMonto" class="form-label">Monto total</label>
                        <asp:TextBox ID="TxtMonto" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="Txtdescripcion" class="form-label">Descripcion del pedido</label>
                        <asp:TextBox ID="Txtdescripcion" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="5" Columns="50"></asp:TextBox>
                    </div>
                    <asp:Button ID="btn_reset" Text="Resetear Pedido" runat="server" CssClass="btn btn-success" OnClick="btn_reset_Click" />
                    
                </div>

            </div>          
                
            <div>
                <asp:Button CssClass="btn btn-success" Text="confirmar pedido" runat="server" ID="ConfirmarPedido" OnClick="ConfirmarPedido_Click" />
            </div>


            <asp:GridView ID="gvPlatosSeleccionados" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="IDPlato" HeaderText="IDPlato" />
                    <asp:BoundField DataField="NombrePlato" HeaderText="Nombre" />
                    <asp:BoundField DataField="Costo" HeaderText="Costo" />
                </Columns>
            </asp:GridView>
            <!-- GridView para mostrar bebidas seleccionadas -->
            <asp:GridView ID="gvBebidasSeleccionadas" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="IDInsumo" HeaderText=" IDInsumo " />
                    <asp:BoundField DataField="Nombre" HeaderText=" Nombre " />
                    <asp:BoundField DataField="Precio" HeaderText=" Precio " />
                </Columns>
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
