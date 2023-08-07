using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pentagram
{
    public partial class AltaUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void radioCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCliente.Checked)
            {
                updPanelCliente.Visible = true;
                updPanelNegocio.Visible = false;
            }
            updPanelNegocio.Update();
            updPanelCliente.Update();
        }

        protected void radioNegocio_CheckedChanged(object sender, EventArgs e)
        {
            if(radioNegocio.Checked)
            {
                updPanelCliente.Visible = false;
                updPanelNegocio.Visible = true;
            }
            updPanelCliente.Update();
            updPanelNegocio.Update();
        }
    }
}