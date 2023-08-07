<%@ Page EnableEventValidation="false" Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Pentagram.UI.Login" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        body {
            background: url('Images/austin-neill-hgO1wFPXl3I-unsplash.jpg') no-repeat center center fixed;
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



    <div>
        <br />
        <br />
        <br />
        <div class="container">
            <div class="d-flex justify-content-center h-100">
                <div class="card bg-dark text-light border-0 shadow rounded-3 my-5">
                    <div class="card-header">
                        <h3>Sign In</h3>
                    </div>
                    <div class="card-body">
                        <div class="form-group">
                            <div class="input-group mb-3">
                                <div class="input-group-prepend">
                                    <span class="input-group-text"><i class="fas fa-user"></i></span>
                                </div>
                                <div>
                                    <asp:TextBox class="form-control textbox" type="text" ID="username" placeholder="Usuario" runat="server" />
                                    <asp:RequiredFieldValidator ID="userreq" runat="server" CssClass="form-text text-danger" ControlToValidate="username" ErrorMessage="El nombre de usuario es obligatorio"></asp:RequiredFieldValidator>
                                </div>
                            </div>

                            <div class="input-group mb-3">
                                <div class="input-group-prepend">
                                    <span class="input-group-text"><i class="fas fa-key"></i></span>
                                </div>
                                <div>
                                    <asp:TextBox class="form-control textbox" type="password" ID="password" placeholder="Contraseña" runat="server" />
                                    <asp:RequiredFieldValidator ID="passreq" runat="server" ControlToValidate="password" ErrorMessage="La contraseña es obligatoria" CssClass="form-text text-danger" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Button runat="server" class="btn btn-primary col-md-12 text-center" ID="btnLogin" Text="Log in" OnClick="btnLogin_Click" UseSubmitBehavior="False"></asp:Button>
                        </div>
                    </div>
                    <div class="card-footer">
                        <div class="d-flex justify-content-center links text-light">
                            Don't have an account?<a href="#">Sign Up</a>
                        </div>
                        <div class="d-flex justify-content-center text-light">
                            <a href="#">Forgot your password?</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <br />
        <br />
        <br />
    </div>
</asp:Content>
