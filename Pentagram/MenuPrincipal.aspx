<%@ Page EnableEventValidation="false" Title="Menu Principal" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MenuPrincipal.aspx.cs" Inherits="Pentagram._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        body {
            background: url('Images/danny-howe-bn-D2bCvpik-unsplash.jpg') no-repeat center center fixed;
            -webkit-background-size: cover;
            -moz-background-size: cover;
            background-size: cover;
            -o-background-size: cover;
        }
    </style>

    <div class="card bg-light bg-opacity-75 mt-3 mb-3 text-center border-0 shadow rounded-3 my-5">
        <h2 class="text-primary-emphasis title-page">¿Que necesitas hacer?</h2>
        <div class="container">
            <div class="row justify-content-center text-center" runat="server" id="ContainerUsuarios">
                <div class="col-lg-3 mb-3 d-flex align-items-stretch">
                    <div class="card text-white bg-dark mb-3" style="width: 18rem;">
                        <img src="Images/john-matychuk-gUK3lA3K7Yo-unsplash.jpg" class="card-img-top">
                        <div class="card-body d-flex flex-column">
                            <h5 class="card-title">Salas de Ensayo</h5>
                            <p class="card-text">Practica el tiempo que necesites en salas seleccionadas.</p>
                            <asp:Button runat="server" class="btn btn-primary mt-auto align-self-center" ID="btnSalas" Text="Reserva tu sala!" UseSubmitBehavior="False" OnClick="btnSalas_Click"></asp:Button>
                        </div>
                    </div>
                </div>
                <div class="col-lg-3 mb-3 d-flex align-items-stretch">
                    <div class="card text-white bg-dark mb-3" style="width: 18rem;">
                        <img src="Images/james-stamler-k3heD_KwH0A-unsplash.jpg" class="card-img-top">
                        <div class="card-body d-flex flex-column">
                            <h5 class="card-title">Instrumentos y equipos</h5>
                            <p class="card-text">Busca lo que necesitas en los mejores negocios.</p>
                            <asp:Button runat="server" class="btn btn-primary mt-auto align-self-center" ID="btnNegocios" Text="Buscar!" UseSubmitBehavior="False" OnClick="btnNegocios_Click"></asp:Button>
                        </div>
                    </div>
                </div>
                <div class="col-lg-3 mb-3 d-flex align-items-stretch">
                    <div class="card text-white bg-dark mb-3" style="width: 18rem;">
                        <img src="Images/nainoa-shizuru-NcdG9mK3PBY-unsplash.jpg" class="card-img-top">
                        <div class="card-body d-flex flex-column">
                            <h5 class="card-title">Eventos</h5>
                            <p class="card-text">Busca y mira los proximos conciertos y eventos.</p>
                            <a class="btn btn-primary mt-auto align-self-center">Proximamente!</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
