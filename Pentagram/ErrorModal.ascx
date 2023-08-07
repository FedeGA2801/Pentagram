<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ErrorModal.ascx.cs" Inherits="Pentagram.ErrorModal" %>


<div id="modal" class="modal fade">
    <div class="modal-dialog modal-dialog-centered" role="document">
        <div class="modal-content">
            <div ID="HeaderModal" runat="server" class="modal-header bg-danger">
                <asp:Label class="h5 modal-title" ID="MensajeHeader" runat="server" Text="Error"></asp:Label>
                <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true"></span>
                </button>
            </div>
            <div class="modal-body">
                <asp:Label ID="MensajeCuerpo" runat="server" Text="Modal body text goes here."></asp:Label>
            </div>
            <div class="modal-footer">
                <button type="button" ID="btnModal" runat="server" class="btn btn-secondary" data-bs-dismiss="modal">Cerrar</button>
            </div>
        </div>
    </div>
</div>
