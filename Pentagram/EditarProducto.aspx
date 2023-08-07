<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="EditarProducto.aspx.cs" Inherits="Pentagram.EditarProducto" %>

<%@ Register Src="~/ValidarImporte.ascx" TagPrefix="uc1" TagName="ValidarImporte" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel runat="server" ID="panelMain">
        <style>
            body {
                background: url('Images/annie-spratt-LtD7qn9k108-unsplash.jpg') no-repeat center center fixed;
                -webkit-background-size: cover;
                -moz-background-size: cover;
                background-size: cover;
                -o-background-size: cover;
            }


            .error-message {
                color: red;
                font-style: italic;
            }
        </style>


        <div class="container mt-4 text-light bg-light bg-opacity-25 mt-4 mb-4">
            <h2 class="text-light">Formulario de Alta de Producto</h2>
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Nombre del Producto:"></asp:Label>
                <asp:TextBox class="form-control" type="text" ID="txtNombre" runat="server" />
                <asp:RequiredFieldValidator ID="reqNombre" runat="server" CssClass="form-text text-danger" ControlToValidate="txtNombre" ErrorMessage="El nombre de usuario es obligatorio"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Descripción:"></asp:Label>
                <asp:TextBox class="form-control" type="text" ID="txtDescripcion" runat="server" Rows="4" TextMode="MultiLine" MaxLength="1000" />
                <asp:RequiredFieldValidator ID="reqDescripcion" runat="server" CssClass="form-text text-danger" ControlToValidate="txtDescripcion" ErrorMessage="El nombre de usuario es obligatorio"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Icono del Producto:"></asp:Label>
                <asp:FileUpload class="form-control-file" ID="fileIconoProducto" runat="server" accept="image/*" />
            </div>
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Precio:"></asp:Label>
                <uc1:ValidarImporte runat="server" ID="ValidarImporte" />
            </div>
            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Stock:"></asp:Label>
                <asp:TextBox class="form-control" type="text" ID="txtStock" runat="server" />
                <asp:RequiredFieldValidator ID="reqStock" runat="server" CssClass="form-text text-danger" ControlToValidate="txtStock" ErrorMessage="El nombre de usuario es obligatorio"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <div class="accordion mb-4" id="accordionExample">
                    <div class="accordion-item">
                        <h2 class="accordion-header" id="headingOne">
                            <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                                Categoria
                            </button>
                        </h2>
                        <div id="collapseOne" class="accordion-collapse collapse show" aria-labelledby="headingOne" data-bs-parent="#accordionExample">
                            <div class="accordion-body">
                                <asp:TreeView ID="categoriasProd" runat="server"></asp:TreeView>
                            </div>
                        </div>
                    </div>
                </div>
                <button type="submit" class="btn btn-primary mt-4 mb-4">Guardar Producto</button>
            </div>
        </div>
    </asp:Panel>
    <asp:Panel runat="server" ID="panelAlerta">
        <div class="alert alert-dismissible alert-warning mt-5">
            <button type="button" class="btn-close" data-bs-dismiss="alert"></button>
            <h4 class="alert-heading">Aviso!</h4>
            <p class="mb-0">Oops! Parece que no tenes permiso para realizar esta accion.  <a href="Home" class="alert-link">Volver al Inicio</a>.</p>
        </div>
    </asp:Panel>

</asp:Content>
