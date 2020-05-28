using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace Albertinho09
{
    public partial class Grid3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DBConnection.Instance.Open();
            SqlCommand sqlcomando = new SqlCommand("select * from tbvoos where cdvoo = '" + TextBox1.Text + "'", DBConnection.Instance);
            SqlDataReader dr = sqlcomando.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                TextBox2.Text = dr["lcdest"].ToString();
                TextBox3.Text = dr["lcorig"].ToString();
                dr.Close();


            }

           DBConnection.Instance.Close();
        }
    }
}
