using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

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
            SqlCommand sqlcomando =
                  new SqlCommand("SELECT voos.dsaero, voos.lcorig , voos.lcdest, voos.dtvoo From tbvoos AS voos JOIN TBCIA AS CIA ON voos.cdcia = CIA.cdcia INNER JOIN tbaeronaves AS AERO ON voos.cdaereo = AERO.cdaereo  where CIA.dscia like '%" + TextBox1.Text + "%'", DBConnection.Instance);

            SqlDataReader dr = sqlcomando.ExecuteReader();
            DropDownList1.Items.Clear();

            if (dr.HasRows)
            {
                DropDownList1.Items.Add("");
                while (dr.Read())
                {
                    DateTime dt = Convert.ToDateTime(dr["dtvoo"]);
                    DropDownList1.Items.Add(dr["dsaero"].ToString() + " - " + dr["lcorig"].ToString() + "->" + dr["lcdest"].ToString() + " " + dt.ToString("dd/MM/yyyy"));
                }
                dr.Close();
            } else
            {
                Console.WriteLine("Dados não encontrados.");
            }

            DBConnection.Instance.Close();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
