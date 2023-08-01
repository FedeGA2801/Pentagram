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
                throw new Exception();
                if (userreq.IsValid && passreq.IsValid)
                {
                    Usuario user = new Usuario(username.Text, password.Text);
                    LoginBLL logbll = new LoginBLL();
                    logbll.Login(user);

                }
            }
            catch (System.Exception ex)
            {
                //label.Text = ex.toString();
                //HERE IS WHERE YOU PUT THIS

                string script = "var myModal = new bootstrap.Modal(document.getElementById('modal'), {  keyboard: false});myModal.toggle();";
                ScriptManager.RegisterStartupScript(this, GetType(),"pop", script,    true);
            }
        }
    }
}