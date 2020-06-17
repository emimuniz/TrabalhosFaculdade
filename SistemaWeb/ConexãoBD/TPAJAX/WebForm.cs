using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication13
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBConnection.Instance.Close();
            DataTable dt = new DataTable();
            DBConnection.Instance.Open();
            string comando = "select * from tbcias";
            SqlCommand sqlcomando = new SqlCommand(comando, DBConnection.Instance);
            SqlDataReader dr = sqlcomando.ExecuteReader();

            if (dr.HasRows)
            {
                dt.Columns.AddRange(new DataColumn[2] { new DataColumn("Aeronave"), new DataColumn("Descrição") });

                while (dr.Read())
                {
                    dt.Rows.Add(dr["cdcia"], dr["dscia"]);
                }

            }

            GridView2.DataSource = dt;
            GridView2.DataBind();
            DBConnection.Instance.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DBConnection.Instance.Open();
            string comando = "select * from tbvoos";
            SqlCommand sqlcomando = new SqlCommand(comando, DBConnection.Instance);
            SqlDataReader dr = sqlcomando.ExecuteReader();

            if (dr.HasRows)
            {
                dt.Columns.AddRange(new DataColumn[6] { new DataColumn("Vôo"), new DataColumn("Data do Vôo"),
                    new DataColumn("Origem"), new DataColumn("Destino"), new DataColumn("Valor Passagem"), new DataColumn("Aeronave") });

                while (dr.Read())
                {
                    DateTime data = Convert.ToDateTime(dr["dtvoo"]);
                    string vl = dr["vlpass"].ToString();
                    dt.Rows.Add(dr["cdvoo"], data.ToString("dd/MM/yyyy"), dr["lcori"], dr["lcdes"], vl, dr["cdcia"]);
                }

            }

            GridView1.DataSource = dt;
            GridView1.DataBind();
            DBConnection.Instance.Close();

            Button1.Visible = false;
            TextBox1.Visible = true;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DBConnection.Instance.Open();
            string comando = "select * from tbvoos where cdvoo like '%"+TextBox1.Text+"%'";
            SqlCommand sqlcomando = new SqlCommand(comando, DBConnection.Instance);
            SqlDataReader dr = sqlcomando.ExecuteReader();

            if (dr.HasRows)
            {
                dt.Columns.AddRange(new DataColumn[6] { new DataColumn("Vôo"), new DataColumn("Data do Vôo"),
                    new DataColumn("Origem"), new DataColumn("Destino"), new DataColumn("Valor Passagem"), new DataColumn("Aeronave") });

                while (dr.Read())
                {
                    DateTime data = Convert.ToDateTime(dr["dtvoo"]);
                    string vl = dr["vlpass"].ToString();
                    dt.Rows.Add(dr["cdvoo"], data.ToString("dd/MM/yyyy"), dr["lcori"], dr["lcdes"], vl, dr["cdcia"]);
                }

            }

            GridView1.DataSource = dt;
            GridView1.DataBind();
            DBConnection.Instance.Close();

        }

        private string gerarDados()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Total de Registros: " + GridView1.Rows.Count);
            registros.Text = sb.ToString();
            return sb.ToString();
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            gerarDados();
        }
    }
}
