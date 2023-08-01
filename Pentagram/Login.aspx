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



    <div id="modal" class="modal">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title">Modal title</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true"></span>
                    </button>
                </div>
                <div class="modal-body">
                    <p>Modal body text goes here.</p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-primary">Save changes</button>
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                </div>
            </div>
        </div>
    </div>



    <div>
        <br />
        <br />
        <br />
        <div class="container">
            <div class="d-flex justify-content-center h-100">
                <div class="card">
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
                            <asp:Label ID="Label1" runat="server" Text="Label" Visible="false"></asp:Label>
                        </div>
                    </div>
                    <div class="card-footer">
                        <div class="d-flex justify-content-center links">
                            Don't have an account?<a href="#">Sign Up</a>
                        </div>
                        <div class="d-flex justify-content-center">
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

    <script type="text/javascript">  
        $(document).ready(function () {
            function miFuncion() {
                $("#loginModal").modal('show');
            };

            function miFuncion() {
                $("#loginModal").modal('hide');
            };

        });
    </script>

</asp:Content>
