<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="NegociosMusica.aspx.cs" Inherits="Pentagram.NegociosMusica" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        body {
            background: url('Images/simon-weisser-phS37wg8cQg-unsplash.jpg') no-repeat center center fixed;
            -webkit-background-size: cover;
            -moz-background-size: cover;
            background-size: cover;
            -o-background-size: cover;
        }
    </style>
    <%--    <div class="card bg-light bg-opacity-75 mt-3 mb-3 p-4 border-0 shadow rounded-3 my-5 mx-5">
        
    </div>--%>

    <div class="row row-cols-1 row-cols-md-3 g-4 mt-3 mb-3">
        <asp:Repeater ID="repeaterNegocios" runat="server" ItemType="BE.TiendaMusica" OnItemCommand="repeaterNegocios_ItemCommand">
            <ItemTemplate>
                <div class="col">
                    <div class="card mb-3 rounded-3">
                        <h3 class="card-header"><%#: Item.Nombre %></h3>
                        <svg class="d-block user-select-none" width="100%" height="200" aria-label="Placeholder: Image cap" focusable="false" role="img" preserveAspectRatio="xMidYMid slice" viewBox="0 0 318 180" style="font-size: 1.125rem; text-anchor: middle">
                            <rect width="100%" height="100%" fill="#868e96"></rect>
                            <image xlink:href="<%#: Item.UrlLogo %>" width="100%" height="100%" preserveAspectRatio="xMidYMid slice" />
                        </svg>

                        <div class="card-body">
                            <p class="card-text"><%#: Item.Descripcion %></p>
                        </div>
                        <ul class="list-group list-group-flush">
                            <li class="list-group-item">Direccion: <%#: Item.Direccion.DireccionCompleta %></li>
                        </ul>
                        <div class="card-body">
                            <a href="<%#: Item.PaginaOficial %>" class="card-link">Pagina Oficial</a>
                        </div>
                        <asp:Button runat="server" class="btn btn-primary col-md-12 text-center" ID="btnVerTienda" Text="Ver Productos" CommandName="VerProductos" CommandArgument="<%#: Item.Id %>" UseSubmitBehavior="False"></asp:Button>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>

