using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();

            var consulta = from p in db.tbvoos
                           orderby p.lcori
                           select p;

            GridView1.DataSource = consulta;
            GridView1.DataBind();

            var total = (from p in db.tbvoos
                         select p).Count();
            Label1.Text = total.ToString() + " registros";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            var consulta1 = from p in db.tbvoos
                            where p.lcori == TextBox1.Text
                            select p;
            var consulta2 = from p in db.tbvoos
                            where p.lcdes == TextBox1.Text
                            select p;
            var consulta = consulta1.Union(consulta2);
            GridView1.DataSource = consulta;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            var consulta = from p in db.tbvoos
                           join c in db.tbaeros on p.cdaero equals c.cdaero
                           join d in db.tbcias on p.cdcia equals d.cdcia
                           select new
                           {
                               Código = p.cdvoo,
                               Cia = d.dscia,
                               Data = p.dtvoo,
                               Origem = p.lcori,
                               Destino = p.lcdes,
                               Aeronave = c.dsaero,
                               Valor = p.vlpass
                           };

            GridView1.DataSource = consulta;
            GridView1.DataBind();
        }
    }
}
