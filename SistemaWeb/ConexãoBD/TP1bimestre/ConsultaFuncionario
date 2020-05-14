using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPAlberto
{
    public partial class Consultar : System.Web.UI.Page
    {
        public static string cpf;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            DBConnection.Instance.Close();
            DBConnection.Instance.Open();
            //hashbytes('MD5', nu_senha)
            string comando = "Select nm_Funcionario, dt_Nascimento, nm_Login, nu_senha" +
                "  from Funcionario where nu_CPF = '" + TextBox3.Text + "'";
            SqlCommand sqlcomando1 = new SqlCommand(comando, DBConnection.Instance);
            SqlDataReader dr = sqlcomando1.ExecuteReader();

            while (dr.Read())
            {
                DateTime data = Convert.ToDateTime(dr["dt_Nascimento"]);
                TextBox2.Text = data.ToString("dd/MM/yyyy");
                TextBox1.Text = dr["nm_Funcionario"].ToString();
                TextBox4.Text = dr["nm_Login"].ToString();
                TextBox5.Text = dr["nu_senha"].ToString();

            }

            DBConnection.Instance.Close();
        }


        protected void Button2_Click(object sender, EventArgs e)
        {

            DBConnection.Instance.Open();
            string comando = "Update Funcionario SET dt_Nascimento = '" 
                + TextBox2.Text + "'" + ",  nm_Login = " + "'" + TextBox4.Text + "'" 
                + ", nu_senha = " + "'" + TextBox5.Text + "'" 
                 + ", nm_funcionario = " + "'" + TextBox1.Text + "'" +  " where nu_CPF = '" + TextBox3.Text + "'";

            SqlCommand sqlcomando1 = new SqlCommand(comando, DBConnection.Instance);
            sqlcomando1.ExecuteNonQuery();
            DBConnection.Instance.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            cpf = TextBox3.Text;
        }


        [WebMethod]
        public static void DeletaRegistro()
        {
            DBConnection.Instance.Open();
            string comando = "Delete from Funcionario where nu_CPF = '" + cpf + "'";

            SqlCommand sqlcomando1 = new SqlCommand(comando, DBConnection.Instance);
            sqlcomando1.ExecuteNonQuery();
            DBConnection.Instance.Close();
        }

        [WebMethod]
        public static string ConfirmaExclusao()
        {
            return string.Format("Confirma a exclusão?");
        }

        [WebMethod]
        public static string ConfirmacaoAlteracao()
        {
           return string.Format("Alteração realizada com sucesso");          
        }
    }
}
