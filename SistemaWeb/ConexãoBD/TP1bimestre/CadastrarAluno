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
    public partial class CadastrarAluno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                DBConnection.Instance.Open();
                SqlCommand sqlcomando2 = new SqlCommand("select * from idioma",
                DBConnection.Instance);
                DropDownList1.DataTextField = "nm_periodo";
                DropDownList1.DataValueField = "cd_idioma";
                DropDownList1.DataSource = sqlcomando2.ExecuteReader(CommandBehavior.CloseConnection);
                DropDownList1.DataBind();

            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

            DBConnection.Instance.Open();
            SqlCommand sqlcomando = new SqlCommand("sp_aluno", DBConnection.Instance);
            sqlcomando.CommandType = CommandType.StoredProcedure;
            sqlcomando.Parameters.Add(new SqlParameter("@nm_aluno", TextBox1.Text));
            sqlcomando.Parameters.Add(new SqlParameter("@dt_nascimentoAluno", TextBox2.Text));
            sqlcomando.Parameters.Add(new SqlParameter("@num_CPFAluno", TextBox3.Text));
            sqlcomando.Parameters.Add(new SqlParameter("@cd_idioma", DropDownList1.SelectedValue));
            sqlcomando.ExecuteNonQuery();
            DBConnection.Instance.Close();
        }


        [WebMethod]
        public static string ConfirmaCadastro()
        {
            return string.Format("Cadastro realizado com sucesso");
        }
    }
}
