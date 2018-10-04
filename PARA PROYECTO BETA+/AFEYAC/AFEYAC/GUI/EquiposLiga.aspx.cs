using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Registros.BO;
using Registros.Services;

namespace AFEYAC.GUI
{
    public partial class EquiposLiga : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            testeo();
        }

        public DataTable listaAlumnos()
        {
            DataTable dt;
            EquipoBO oEquipoBO = new EquipoBO();
            EquipoCTRL oEquipoCTRL = new EquipoCTRL();
            dt = oEquipoCTRL.devuelveEquipo(oEquipoBO).Tables[0];
            return dt;
        }

        public void testeo()
        {

            GridView1.DataSource = listaAlumnos();
            GridView1.DataBind();

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Detalle")
            {
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                int valor = Convert.ToInt32(this.GridView1.DataKeys[index].Value);
                Session["valor"] = valor;
                Response.Redirect("Jugadores.aspx");
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}