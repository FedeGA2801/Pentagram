using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pentagram
{
    public partial class ErrorModal : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        internal void MostrarMensaje(string msg, TipoEvento tipo)
        {
            switch (tipo)
            {
                case TipoEvento.Aviso:
                    MensajeHeader.Text = "Aviso";
                    HeaderModal.Attributes["class"] = "modal-header bg-warning";
                    break;
                case TipoEvento.Error:
                    MensajeHeader.Text = "Error";
                    HeaderModal.Attributes["class"] = "modal-header bg-danger";
                    break;
                case TipoEvento.Mensaje:
                    MensajeHeader.Text = "OK";
                    HeaderModal.Attributes["class"] = "modal-header bg-success";
                    break;
                default:
                    break;
            }
            MensajeCuerpo.Text = msg;
            string script = "var myModal = new bootstrap.Modal(document.getElementById('modal'), {backdrop: 'static',  keyboard: false});myModal.toggle();";
            ScriptManager.RegisterStartupScript(this, GetType(), "pop", script, true);
        }
    }
}