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
    public partial class ligas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            testeo();
        }

        public DataTable listaLigas()
        {
            DataTable dt;
            LigasBO oLigasBO = new LigasBO();
            LigasCTRL oLigasCTRL = new LigasCTRL();
            dt = oLigasCTRL.devuelveLigas(oLigasBO).Tables[0];
            return dt;
        }

        public void testeo()
        {
            GridView1.DataSource = listaLigas();
            GridView1.DataBind();


        }
    }
}