using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();

            var consulta = from p in db.tbvoos
                           orderby p.lcori
                           select p;

            GridView1.DataSource = consulta;
            GridView1.DataBind();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            var voo = new tbvoos();
            voo.cdvoo = TextBox1.Text;
            voo.cdcia = Int32.Parse(TextBox4.Text);
            voo.dtvoo = DateTime.Parse(TextBox2.Text);
            voo.lcori = TextBox5.Text;
            voo.lcdes = TextBox6.Text;
            voo.cdaero = Int32.Parse(TextBox7.Text);
            voo.vlpass = Decimal.Parse(TextBox3.Text);
            db.tbvoos.InsertOnSubmit(voo);
            db.SubmitChanges();

            var consulta = from p in db.tbvoos
                           select p;
            GridView1.DataSource = consulta;
            GridView1.DataBind();

            Limpar();

        }

        public void Limpar()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
        }
    }
}
