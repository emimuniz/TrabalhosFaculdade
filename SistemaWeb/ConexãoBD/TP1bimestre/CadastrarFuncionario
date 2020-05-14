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
    public partial class Cadastrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                    DBConnection.Instance.Open();
                    SqlCommand sqlcomando2 = new SqlCommand("select * from cargo",
                    DBConnection.Instance);
                    DropDownList1.DataTextField = "nm_cargo";
                    DropDownList1.DataValueField = "cd_cargo";
                    DropDownList1.DataSource = sqlcomando2.ExecuteReader(CommandBehavior.CloseConnection);
                    DropDownList1.DataBind();
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
                DBConnection.Instance.Open();
                SqlCommand sqlcomando = new SqlCommand("sp_funcionario", DBConnection.Instance);
                sqlcomando.CommandType = CommandType.StoredProcedure;
                sqlcomando.Parameters.Add(new SqlParameter("@nm_funcionario", TextBox1.Text));
                sqlcomando.Parameters.Add(new SqlParameter("@dt_nascimento", TextBox2.Text));
                sqlcomando.Parameters.Add(new SqlParameter("@nu_CPF", TextBox3.Text));
                sqlcomando.Parameters.Add(new SqlParameter("@nm_Login", TextBox4.Text));
                sqlcomando.Parameters.Add(new SqlParameter("@nu_Senha", TextBox5.Text));
                sqlcomando.Parameters.Add(new SqlParameter("@cd_cargo", DropDownList1.SelectedValue));
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
