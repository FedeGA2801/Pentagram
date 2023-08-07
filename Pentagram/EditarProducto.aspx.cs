using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pentagram
{
    public partial class EditarProducto : System.Web.UI.Page
    {
        protected int idNegocio;
        private bool todoOK = false;
        private readonly int _accesoRequerido = 9;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (EvaluarAcceso())
            {
                idNegocio = ((UsuarioNegocio)Sesion.ObtenerInstancia().usuario).NegocioPadre;
            }
            else
            {
                panelMain.Visible = false;
                panelAlerta.Visible = true;
            }
        }

        public bool EvaluarAcceso()
        {
            if (!(Sesion.ObtenerInstancia().usuario is UsuarioNegocio))
            {
                (this.Master as SiteMaster).MostrarMensaje("El usuario no tiene permiso para realizar esta acción.", TipoEvento.Error);
                return false;
            }
            else
            {
                if (((UsuarioNegocio)Sesion.ObtenerInstancia().usuario).NegocioPadre == -1)
                {
                    (this.Master as SiteMaster).MostrarMensaje("El usuario no tiene vinculado un negocio, por favor contactarse con soporte", TipoEvento.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}