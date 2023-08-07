using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pentagram
{
    public partial class NegociosMusica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NegociosBLL negociosBLL = new NegociosBLL();
            List<TiendaMusica> tiendaMusicaList = negociosBLL.ObtenerTiendasMusica();
            repeaterNegocios.DataSource = tiendaMusicaList;
            repeaterNegocios.DataBind();
        }


        protected void btnVerTienda_Click(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse((sender as Button).CommandArgument);
                string la = "";
            }
            catch (System.Exception ex)
            {
                (this.Master as SiteMaster).MostrarMensaje("Ocurrio un error, por favor reintentar", TipoEvento.Error);
            }
        }

        protected void repeaterNegocios_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "VerProductos")
                {
                    int idNegocio = Convert.ToInt32(e.CommandArgument);
                }
            }
            catch (System.Exception ex)
            {
                (this.Master as SiteMaster).MostrarMensaje("Ocurrio un error, por favor reintentar", TipoEvento.Error);
            }
            
        }
    }
}