using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Albertinho09
{
    public partial class DBGrid3 : System.Web.UI.Page
    {
        public static Int32 teste;
        static DateTime data1;
        static DateTime data2;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string ConfirmaExclusao()
        {
            testeOi();
            return string.Format("Tem certeza que deseja excluir " + teste + " registros?");
        }

        [WebMethod]
        public static void DeletaRegistro()
        {
            DBConnection.Instance.Open();
            string comando = "delete from tbvoos where dtvoo between '" + data1.ToString("yyyy-MM-dd") + "' and '" + data2.ToString("yyyy-MM-dd") + "'";
            SqlCommand sqlcomando1 = new SqlCommand(comando, DBConnection.Instance);

            sqlcomando1.ExecuteNonQuery();
            DBConnection.Instance.Close();
        }

        
        public static void testeOi()
        {
            DBConnection.Instance.Open();
            string comando = "Select count(*) from tbvoos where dtvoo between '" + data1.ToString("yyyy-MM-dd") +"' and '" + data2.ToString("yyyy-MM-dd") + "'";
            SqlCommand sqlcomando1 = new SqlCommand(comando, DBConnection.Instance);
            
            teste = Convert.ToInt32(sqlcomando1.ExecuteScalar());
            Console.WriteLine(teste);
            DBConnection.Instance.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            data1 = Convert.ToDateTime(TextBox1.Text.ToString());
            data2 = Convert.ToDateTime(TextBox2.Text.ToString());
        }
    }
}
