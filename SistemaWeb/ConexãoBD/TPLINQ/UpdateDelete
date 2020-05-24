using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            var db = new DataClasses1DataContext();
            var voo = from p in db.tbvoos
                      where p.cdvoo == TextBox1.Text
                      select p; 

            foreach(var q in voo)
            {
                TextBox4.Text = q.cdcia.ToString();
                TextBox5.Text = q.lcori;
                TextBox6.Text = q.lcdes;
                TextBox2.Text = q.dtvoo.ToString();
                TextBox8.Text = q.cdvoo;    
                TextBox3.Text = q.vlpass.ToString();
                TextBox7.Text = q.cdaero.ToString();
            };

            db.SubmitChanges();

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            var voo = from p in db.tbvoos
                      where p.cdvoo == TextBox1.Text
                      select p;

            foreach (var q in voo)
            {
                q.cdcia = int.Parse(TextBox4.Text); 
                q.lcori = TextBox5.Text;
                q.lcdes = TextBox6.Text;
                q.dtvoo = DateTime.Parse(TextBox2.Text);
                q.cdvoo = TextBox8.Text;
                q.vlpass = decimal.Parse(TextBox3.Text);
                q.cdaero = int.Parse(TextBox7.Text);
            };

            db.SubmitChanges();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            var voo = from p in db.tbvoos
                      where p.cdvoo == TextBox1.Text
                      select p;

            db.tbvoos.DeleteAllOnSubmit(voo);
            db.SubmitChanges();
        }
    }
}
