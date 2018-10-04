using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AFEYAC.GUI
{
    public partial class sesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text == "Juan" & TextBox2.Text == "12345")
            {
                Session["operacion"] = 1;
                Response.Redirect("Miembros.aspx");
            }
            else
            {
                
            }
        }
    }
}