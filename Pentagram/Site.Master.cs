using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pentagram
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Sesion.ObtenerInstancia().Logeado())
                PerfilUser.Visible = true;
        }

        public void MostrarMensaje(string msg, TipoEvento tipo)
        {
            ErrorModal.MostrarMensaje(msg, tipo);
        }
    }
}