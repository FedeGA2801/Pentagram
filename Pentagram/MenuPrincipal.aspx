<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MenuPrincipal.aspx.cs" Inherits="Pentagram._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        body {
          background: url('Images/austin-neill-hgO1wFPXl3I-unsplash.jpg') no-repeat center center fixed;
          -webkit-background-size: cover;
          -moz-background-size: cover;
          background-size: cover;
          -o-background-size: cover;
        }
    </style>
    <h2 class="text-white title-page">¿Que necesitas hacer?</h2>
    <div class="container">
        <div class="row mbr-justify-content-center">
            <div class="col-lg-4 mb-3 d-flex align-items-stretch">
                <div class="card text-white bg-dark mb-3" style="width: 18rem;">
                    <img src="Images/john-matychuk-gUK3lA3K7Yo-unsplash.jpg" class="card-img-top">
                    <div class="card-body d-flex flex-column">
                        <h5 class="card-title">Salas de Ensayo</h5>
                        <p class="card-text">Practica el tiempo que necesites en salas seleccionadas.</p>
                        <a href="#" class="btn btn-primary mt-auto align-self-center">Reserva tu sala!</a>
                    </div>
                </div>
            </div>
            <div class="col-lg-4 mb-3 d-flex align-items-stretch">
                <div class="card text-white bg-dark mb-3" style="width: 18rem;">
                    <img src="Images/james-stamler-k3heD_KwH0A-unsplash.jpg" class="card-img-top">
                    <div class="card-body d-flex flex-column">
                        <h5 class="card-title">Instrumentos y equipos</h5>
                        <p class="card-text">Busca lo que necesitas en los mejores negocios.</p>
                        <a href="#" class="btn btn-primary mt-auto align-self-center">Buscar!</a>
                    </div>
                </div>
            </div>
            <div class="col-lg-4 mb-3 d-flex align-items-stretch">
                <div class="card text-white bg-dark mb-3" style="width: 18rem;">
                    <img src="Images/nainoa-shizuru-NcdG9mK3PBY-unsplash.jpg" class="card-img-top">
                    <div class="card-body d-flex flex-column">
                        <h5 class="card-title">Eventos</h5>
                        <p class="card-text">Busca y mira los proximos conciertos y eventos.</p>
                        <a href="#" class="btn btn-primary mt-auto align-self-center">Proximamente!</a>
                    </div>
                </div>
            </div>
        </div>

    </div>
</asp:Content>
