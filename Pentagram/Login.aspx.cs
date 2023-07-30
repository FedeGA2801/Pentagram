using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pentagram.UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(userreq.IsValid && passreq.IsValid)
            {
                Usuario user = new Usuario(username.Text, password.Text);
                LoginBLL logbll = new LoginBLL();
                logbll.Login(user);
            }
        }
    }
}