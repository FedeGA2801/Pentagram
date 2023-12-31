﻿using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pentagram
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Si no estoy logeado, te mando al Login
            if (!Sesion.ObtenerInstancia().Logeado())
                Response.Redirect("Login");
        }

        protected void btnSalas_Click(object sender, EventArgs e)
        {

        }

        protected void btnNegocios_Click(object sender, EventArgs e)
        {
            Response.Redirect("NegociosMusica");
        }
    }
}