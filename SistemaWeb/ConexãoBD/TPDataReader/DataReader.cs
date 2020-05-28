using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Albertinho09
{
    public partial class DBGrid4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DBConnection.Instance.Open();
            string comando = "Select dtvoo, lcori, lcdes, vlpass, cdcia  from TBvoos where cdvoo = '" + TextBox1.Text + "'";
            SqlCommand sqlcomando1 = new SqlCommand(comando, DBConnection.Instance);
            SqlDataReader dr = sqlcomando1.ExecuteReader();
              
            while (dr.Read())
            {
                DateTime data = Convert.ToDateTime(dr["dtvoo"]);
                TextBox2.Text = data.ToString("dd/MM/yyyy");
                TextBox3.Text = dr["lcori"].ToString();
                TextBox4.Text = dr["lcdes"].ToString();
                TextBox5.Text = dr["vlpass"].ToString();
                TextBox6.Text = dr["cdcia"].ToString();

            }
            
            DBConnection.Instance.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DBConnection.Instance.Open();
            string comando = "Update TBvoos SET dtvoo = '" + TextBox2.Text + "'" + ", lcori = " + "'" + TextBox3.Text + "'" + ", lcdes = " + "'" + TextBox4.Text + "'" + ", vlpass = " + "'" + TextBox5.Text + "'" + ",cdcia = " + "'" + TextBox6.Text + "'" + " where cdvoo = '" + TextBox1.Text + "'";
            SqlCommand sqlcomando1 = new SqlCommand(comando, DBConnection.Instance);
            sqlcomando1.ExecuteNonQuery();
            DBConnection.Instance.Close();
        }
    }
}
