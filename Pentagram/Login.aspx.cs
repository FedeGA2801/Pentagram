using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Pentagram.UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (userreq.IsValid && passreq.IsValid)
                {
                    LoginUser user = new LoginUser(username.Text, password.Text);
                    LoginBLL logbll = new LoginBLL();
                    logbll.Login(user);
                    Response.Redirect("MenuPrincipal");
                }
            }
            catch (System.Exception ex)
            {
                (this.Master as SiteMaster).MostrarMensaje("Ocurrio un error, por favor reintentar", TipoEvento.Error);
            }
        }
    }
}