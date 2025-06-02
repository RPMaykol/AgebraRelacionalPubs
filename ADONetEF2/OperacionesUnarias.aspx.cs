using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADONetEF2
{
    public partial class OperacionesUnarias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Declarar el objeto para el mapeado objeto relacional
        private pubsEntities pub = new pubsEntities();

        //EJERCICIOS DE SELECCION
        protected void btnConsulta1_Click(object sender, EventArgs e)
        {
            var consulta = from t in pub.titles
                           where t.price > 20
                           select t;
            gvConsulta.DataSource = consulta.ToList();
            gvConsulta.DataBind();
        }

        protected void btnConsulta2_Click(object sender, EventArgs e)
        {
            var consulta = from a in pub.authors
                           where a.state == "CA"
                           select a;
            gvConsulta.DataSource = consulta.ToList();
            gvConsulta.DataBind();
        }

        protected void btnConsulta3_Click(object sender, EventArgs e)
        {
            var consulta = from t in pub.titles
                           where t.type == "business" && t.price >= 15 && t.price <= 30
                           select t;
            gvConsulta.DataSource = consulta.ToList();
            gvConsulta.DataBind();
        }

        //EJERCICIO DE PROYECCION
        protected void btnConsulta4_Click(object sender, EventArgs e)
        {
            var consulta = from a in pub.authors
                           select new { a.au_fname, a.au_lname };
            gvConsulta.DataSource = consulta.ToList();
            gvConsulta.DataBind();
        }

        protected void btnConsulta5_Click(object sender, EventArgs e)
        {
            var consulta = (from a in pub.authors
                            select a.state).Distinct();
            gvConsulta.DataSource = consulta.ToList();
            gvConsulta.DataBind();
        }

        protected void btnConsulta6_Click(object sender, EventArgs e)
        {
            var consulta = from t in pub.titles
                           select new { t.title, t.price };
            gvConsulta.DataSource = consulta.ToList();
            gvConsulta.DataBind();
        }

        //EJHERCICIO DE RENOMBRAMIENTO
        protected void btnConsulta7_Click(object sender, EventArgs e)
        {
            var consulta = from a in pub.authors
                           select new
                           {
                               Nombre = a.au_fname,
                               Apellido = a.au_lname
                           };
            gvConsulta.DataSource = consulta.ToList();
            gvConsulta.DataBind();
        }

        protected void btnConsulta8_Click(object sender, EventArgs e)
        {
            var consulta = from t in pub.titles
                           select new
                           {
                               NombreLibro = t.title,
                               Precio = t.price
                           };
            gvConsulta.DataSource = consulta.ToList();
            gvConsulta.DataBind();
        }

        protected void btnConsulta9_Click(object sender, EventArgs e)
        {
            var consulta = from p in pub.publishers
                           select new
                           {
                               Editorial = p.pub_name,
                               Ciudad = p.city
                           };
            gvConsulta.DataSource = consulta.ToList();
            gvConsulta.DataBind();
        }
    }
}