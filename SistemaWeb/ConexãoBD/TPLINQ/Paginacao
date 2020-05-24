using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var pagina = Int32.Parse(TextBox1.Text) - 1;
            var qtd = 2;
            if (pagina != 0)
                pagina = pagina * qtd;
            var db = new DataClasses1DataContext();
            var consulta = (from p in db.tbvoos
                            select p).Skip(pagina).Take(qtd);
            GridView1.DataSource = consulta;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            var consulta = from p in db.tbvoos
                           where p.lcori == TextBox2.Text
                           select p;
            GridView1.DataSource = consulta;
            GridView1.DataBind();

        }
    }
}
