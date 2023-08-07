<%@ Page EnableEventValidation="false" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Pentagram.Home" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <style>
        body {
          background: url('Images/danny-howe-bn-D2bCvpik-unsplash.jpg') no-repeat center center fixed;
          -webkit-background-size: cover;
          -moz-background-size: cover;
          background-size: cover;
          -o-background-size: cover;
        }

        .textbox {
            padding: 0.5rem 1.5rem;
        }
    </style>

    <div class="card bg-light bg-opacity-75 mt-3 mb-3 text-center" >
        <h2 class="card-title mt-5 text-primary-emphasis">¡Bienvenido a Pentagram!</h2>
        <h3 class="card-subtitle mb-2 text-primary">Donde la música cobra vida</h3>
        <div class="card-body">
            <div class="container text-center">
                <div class="row mt-5">
                    <div class="col-lg-3 col-md-6">
                        <i class="fas fa-music fa-4x"></i>
                        <h4 class="text-primary">Amplia selección de instrumentos</h4>
                        <p class="text-primary">Encuentra los mejores instrumentos musicales de alta calidad para expresar tu arte y pasión.</p>
                    </div>

                    <div class="col-lg-3 col-md-6">
                        <i class="fas fa-graduation-cap fa-4x"></i>
                        <h4 class="text-primary">Clases personalizadas</h4>
                        <p class="text-primary">Aprende y perfecciona tus habilidades musicales con expertos en el mundo de la música.</p>
                    </div>

                    <div class="col-lg-3 col-md-6">
                        <i class="fas fa-microphone-alt fa-4x"></i>
                        <h4 class="text-primary">Emocionantes eventos</h4>
                        <p class="text-primary">Participa en espectáculos y eventos musicales para mostrar tu talento al mundo.</p>
                    </div>

                    <div class="col-lg-3 col-md-6">
                        <i class="fas fa-users fa-4x"></i>
                        <h4 class="text-primary">Forma la banda de tus sueños</h4>
                        <p class="text-primary">Encuentra músicos talentosos y colabora en proyectos musicales increíbles.</p>
                    </div>
                </div>
                <asp:Button runat="server" class="btn btn-primary btn-lg mt-5" ID="btnJoin" Text="Únete a nuestra comunidad musical" OnClick="btnJoin_Click" UseSubmitBehavior="False"></asp:Button>
            </div>
        </div>
    </div>
</asp:Content>
