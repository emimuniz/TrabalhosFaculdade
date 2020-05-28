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
            DBConnection.Instance.Open();
            SqlCommand sqlcomando = new SqlCommand("Select * from tbvoos", DBConnection.Instance);
            //GridView1.DataSource = sqlcomando.ExecuteReader(CommandBehavior.CloseConnection);
            GridView1.DataSource = sqlcomando.ExecuteReader();
            GridView1.DataBind();
            DBConnection.Instance.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
