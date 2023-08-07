<%@ Page Language="C#" Title="Alta de Usuario" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AltaUsuario.aspx.cs" Inherits="Pentagram.AltaUsuario" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        body {
            background: url('Images/james-stamler-k3heD_KwH0A-unsplash.jpg') no-repeat center center fixed;
            -webkit-background-size: cover;
            -moz-background-size: cover;
            background-size: cover;
            -o-background-size: cover;
        }

        .textbox {
            padding: 0.5rem 1.5rem;
        }

        .error-message {
            color: red;
            font-style: italic;
        }
    </style>

    <asp:Panel ID="panelMain" runat="server">
        <div class="container bg-dark bg-opacity-75 text-light mt-4 mb-5 border-0 rounded-3">
            <h2 class="p-2">Creación de Usuario</h2>
            <div class="form-group p-2">
                <asp:Label ID="lblUsername" runat="server" Text="Mail:"></asp:Label>
                <asp:TextBox class="form-control textbox" type="text" ID="username" runat="server" />
                <asp:RequiredFieldValidator ID="userreq" runat="server" CssClass="form-text text-danger" ControlToValidate="username" ErrorMessage="El nombre de usuario es obligatorio"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group p-2">
                <asp:Label ID="lblContrasena" runat="server" Text="Contraseña:"></asp:Label>
                <asp:TextBox class="form-control textbox" type="password" ID="txtPassword" runat="server" />
                <asp:RequiredFieldValidator ID="passreq" runat="server" ControlToValidate="txtPassword" ErrorMessage="La contraseña es obligatoria" CssClass="form-text text-danger" SetFocusOnError="True"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group p-2">
                <asp:Label ID="lblRepContrasena" runat="server" Text="Repetir Contraseña:"></asp:Label>
                <label for="txtContrasena">Repetir Contraseña:</label>
                <asp:TextBox class="form-control textbox" type="password" ID="txtRepContra" runat="server" />
            </div>
            <div class="form-group p-2">
                <asp:Label ID="lblMail" runat="server" Text="Mail:"></asp:Label>
                <asp:TextBox class="form-control textbox" type="text" ID="txtMail" runat="server" />
                <asp:RegularExpressionValidator CssClass="form-text text-danger" ControlToValidate="txtMail" ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$"></asp:RegularExpressionValidator>
            </div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="form-group p-2">
                        <label>Tipo de Usuario:</label>
                        <div class="p-1">
                            <asp:Label ID="lblCliente" runat="server" Text="Cliente"></asp:Label>
                            <asp:RadioButton type="radio" class="form-check-input" ID="radioCliente" runat="server" GroupName="tipoCliente" OnCheckedChanged="radioCliente_CheckedChanged" AutoPostBack="True" />
                        </div>
                        <div class="p-1">
                            <asp:Label ID="lblNegocio" runat="server" Text="Negocio"></asp:Label>
                            <asp:RadioButton type="radio" class="form-check-input" ID="radioNegocio" runat="server" GroupName="tipoCliente" OnCheckedChanged="radioNegocio_CheckedChanged" AutoPostBack="True" />
                        </div>
                    </div>
                    <asp:UpdatePanel ID="updPanelCliente" runat="server" UpdateMode="Conditional" Visible="false">
                        <ContentTemplate>
                            <div class="container text-white border-dark mt-3 mb-3">
                                <div class="card-header" id="headingCliente">
                                    <h5 class="mb-0">Datos de Cliente
                                    </h5>
                                </div>
                                <div class="card-body">
                                    <div class="form-group">
                                        <asp:Label ID="lblNombreCliente" runat="server" Text="Nombre:"></asp:Label>
                                        <asp:TextBox class="form-control textbox" type="text" ID="txtNomCliente" runat="server" />
                                    </div>
                                    <div class="form-group">
                                        <asp:Label ID="lblApellidoCliente" runat="server" Text="Apellido:"></asp:Label>
                                        <asp:TextBox class="form-control textbox" type="text" ID="txtApelCliente" runat="server" />
                                    </div>
                                    <div class="form-group">
                                        <asp:Label ID="lblCUIL" runat="server" Text="CUIL:"></asp:Label>
                                        <asp:TextBox class="form-control textbox" type="text" ID="txtCUIL" runat="server" />
                                    </div>
                                    <div class="form-group">
                                        <asp:Label ID="lblIconoCliente" runat="server" Text="Icono del Cliente:"></asp:Label>
                                        <input type="file" class="form-control-file" id="fileIconoCliente" accept="image/*" required>
                                    </div>
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <asp:UpdatePanel ID="updPanelNegocio" runat="server" UpdateMode="Conditional" Visible="false">
                        <ContentTemplate>
                            <div class="container text-white border-dark mt-3 mb-3">
                                <div class="card-header" id="headingNegocio">
                                    <h5 class="mb-0">Datos de Negocio
                                    </h5>
                                </div>
                                <div class="card-body">
                                    <div class="form-group">
                                        <div class="custom-control custom-checkbox">
                                            <input type="checkbox" class="custom-control-input" id="chkNuevoNegocio">
                                            <label class="custom-control-label" for="chkNuevoNegocio">Nuevo Negocio</label>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label for="selNegocios">Negocios Preexistentes:</label>
                                        <select class="form-control" id="selNegocios">
                                            <option value="Negocio1">Negocio 1</option>
                                            <option value="Negocio2">Negocio 2</option>
                                            <!-- Agrega más opciones según tus necesidades -->
                                        </select>
                                    </div>
                                    <div class="form-group">
                                        <label for="txtCuitNegocio">CUIT:</label>
                                        <input type="text" class="form-control" id="txtCuitNegocio" required>
                                    </div>
                                    <div class="form-group">
                                        <label for="txtRazonSocial">Razón Social:</label>
                                        <input type="text" class="form-control" id="txtRazonSocial" required>
                                    </div>
                                    <div class="form-group">
                                        <label for="fileLogoNegocio">Logo del Negocio:</label>
                                        <input type="file" class="form-control-file" id="fileLogoNegocio" accept="image/*" required>
                                    </div>
                                    <div class="form-group">
                                        <label for="txtDescripcionNegocio">Descripción:</label>
                                        <textarea class="form-control" id="txtDescripcionNegocio" rows="4" required></textarea>
                                    </div>
                                    <div class="form-group">
                                        <label for="txtUrlPaginaOficial">URL de Página Oficial:</label>
                                        <input type="text" class="form-control" id="txtUrlPaginaOficial" required>
                                    </div>
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </asp:Panel>
    <asp:Panel runat="server" ID="panelAlerta" Visible="false">
        <div class="alert alert-dismissible alert-warning mt-5">
            <button type="button" class="btn-close" data-bs-dismiss="alert"></button>
            <h4 class="alert-heading">Aviso!</h4>
            <p class="mb-0">Oops! Parece que no tenes permiso para realizar esta accion.  <a href="Home" class="alert-link">Volver al Inicio</a>.</p>
        </div>
    </asp:Panel>
</asp:Content>
