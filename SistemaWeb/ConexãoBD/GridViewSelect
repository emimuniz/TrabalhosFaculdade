using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Albertinho09
{
    public partial class DBGrid1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (!IsPostBack) { 
                DBConnection.Instance.Open();
                SqlCommand sqlcomando1 = new SqlCommand("Select distinct dscia from tbcias", DBConnection.Instance);
                DropDownList1.DataTextField = "dscia";
                DropDownList1.DataValueField = "dscia";
                DropDownList1.DataSource = sqlcomando1.ExecuteReader();
                DropDownList1.DataBind();
                DBConnection.Instance.Close();
                DropDownList1.Items.Insert(0, new ListItem("Selecione um item"));
            }

            DBConnection.Instance.Open();
            string comando = "select * from tbvoos";
            SqlCommand sqlcomando = new SqlCommand(comando, DBConnection.Instance);
            SqlDataReader dr = sqlcomando.ExecuteReader();

            if (dr.HasRows)
            {
                dt.Columns.AddRange(new DataColumn[7] { new DataColumn("Vôo"), new DataColumn("Data do Vôo"), new DataColumn("Origem (2)"),
                    new DataColumn("Origem"), new DataColumn("Destino"), new DataColumn("Valor Passagem"), new DataColumn("Aeronave") });

                while (dr.Read())
                {
                    string lcori = trocaOrigem(dr["lcori"].ToString());
                    DateTime data = Convert.ToDateTime(dr["dtvoo"]);
                    string vl = dr["vlpass"].ToString();
                    dt.Rows.Add(dr["cdvoo"], data.ToString("dd/MM/yyyy"), lcori, dr["lcori"], dr["lcdes"], vl, dr["cdcia"]);
                }

            }

            GridView1.DataSource = dt;
            GridView1.DataBind();
            DBConnection.Instance.Close();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConnection.Instance.Open();
            string comando = "select * from tbvoos a inner join tbcias b on a.cdcia = b.cdcia where b.dscia = '" + DropDownList1.SelectedValue.ToString() + "'";
            SqlCommand sqlcomando = new SqlCommand(comando, DBConnection.Instance);
            SqlDataReader dr = sqlcomando.ExecuteReader();
            DataTable dt = (DataTable)GridView1.DataSource;

            if (dr.HasRows)
            {
                dt.Rows.Clear();
                while (dr.Read())
                {
                    string lcori = trocaOrigem(dr["lcori"].ToString());
                    dt.Rows.Add(dr["cdvoo"], dr["dtvoo"], lcori, dr["lcori"], dr["lcdes"], dr["vlpass"], dr["cdcia"]);
                }
            }

            GridView1.DataSource = dt;
            GridView1.DataBind();
            DBConnection.Instance.Close();
        }


        public string trocaOrigem(string origem)
        {
            if (origem == "GRU" || origem == "gru")
                return "Guarulhos";
            else
            {
                if (origem == "CGH" || origem == "cgh")
                    return "Congonhas";
                else
                    return origem.ToUpper();
            }
        }

    }
}
