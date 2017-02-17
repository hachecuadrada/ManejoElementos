using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManejoElementos
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cambiar(object sender, EventArgs e)
        {
            Control f = Page.FindControl("form1");
            Label l = (Label)f.FindControl("juan");
            //TextBox t = (TextBox)f.FindControl("pedro");
            l.Text = "Ola k ase?";
        }
    }
}