using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication11
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Connectioncs.Instance.Open();
            string comando = "Select cdcia, dtvoo, lcori, lcdes, cdaero, vlpass" +
                "  from tbvoos where cdvoo = '" + TextBox1.Text + "'";
            SqlCommand sqlcomando1 = new SqlCommand(comando, Connectioncs.Instance);
            SqlDataReader dr = sqlcomando1.ExecuteReader();

            while (dr.Read())
            {
                DateTime data = Convert.ToDateTime(dr["dtvoo"]);
                TextBox2.Text = dr["cdcia"].ToString(); 
                TextBox3.Text = data.ToString("dd/MM/yyyy");
                TextBox4.Text = dr["lcori"].ToString();
                TextBox5.Text = dr["lcdes"].ToString();
                TextBox6.Text = dr["cdaero"].ToString();
                TextBox7.Text = dr["vlpass"].ToString();

            }

            Connectioncs.Instance.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Connectioncs.Instance.Open();
            string comando = "Update tbvoos SET cdcia = '"
                + TextBox2.Text + "'" + ",  dtvoo = " + "'" + TextBox3.Text + "'"
                + ", lcori = " + "'" + TextBox4.Text + "'"
                 + ", lcdes = " + "'" + TextBox5.Text + "'" + ", cdaero = " + "'" + TextBox6.Text + "'" 
                 + ", vlpass = " + "'" + TextBox7.Text + "'" + " where cdvoo = '" + TextBox1.Text + "'";

            SqlCommand sqlcomando1 = new SqlCommand(comando, Connectioncs.Instance);
            sqlcomando1.ExecuteNonQuery();
            Connectioncs.Instance.Close();
        }
    }
}
