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

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string descricao = (string)GridView1.DataKeys[e.RowIndex].Value;
            ExcluiVoo(descricao);
        }
        public void ExcluiVoo(string descricao)
        {
            DBConnection.Instance.Open();
            string comando = "delete from TBvoos where cdvoo = '"+descricao+ "'";
            SqlCommand sqlcomando1 = new SqlCommand(comando, DBConnection.Instance);
            sqlcomando1.ExecuteNonQuery();
            DBConnection.Instance.Close();
        }
    }
}
