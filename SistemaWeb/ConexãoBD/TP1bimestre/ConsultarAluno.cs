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
    public partial class ConsultaAluno : System.Web.UI.Page
    {
        public static string cpf;
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

        protected void Button3_Click(object sender, EventArgs e)
        {
            DBConnection.Instance.Close();
            DBConnection.Instance.Open();

            string comando = "SELECT A.nm_Aluno, A.dt_NascimentoAluno, I.nm_Periodo " +
                "FROM Alunos AS A INNER JOIN Idioma AS I ON A.cd_Idioma = I.cd_Idioma " +
                " where A.num_CPFAluno = '" + TextBox3.Text + "'";


            SqlCommand sqlcomando1 = new SqlCommand(comando, DBConnection.Instance);
            SqlDataReader dr = sqlcomando1.ExecuteReader();

            while (dr.Read())
            {
                DateTime data = Convert.ToDateTime(dr["dt_NascimentoAluno"]);
                TextBox2.Text = data.ToString("dd/MM/yyyy");
                TextBox1.Text = dr["nm_Aluno"].ToString();
                TextBox4.Text = dr["nm_periodo"].ToString();
            }

            DBConnection.Instance.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            cpf = TextBox3.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DBConnection.Instance.Open();
            string comando = "Update Alunos SET dt_NascimentoAluno = '"
                + TextBox2.Text + "'" + ",  nm_aluno = " + "'" + TextBox1.Text + "'" 
                + ",  cd_idioma = " + "'" + DropDownList1.SelectedValue + "'" +
                " where num_CPFAluno = '" + TextBox3.Text + "'";

            SqlCommand sqlcomando1 = new SqlCommand(comando, DBConnection.Instance);
            sqlcomando1.ExecuteNonQuery();
            DBConnection.Instance.Close();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Label9.Visible = true;
            DropDownList1.Visible = true;
        }


        [WebMethod]
        public static void DeletaRegistro()
        {
            DBConnection.Instance.Open();
            string comando = "Delete from Alunos where num_CPFAluno = '" + cpf + "'";
            SqlCommand sqlcomando1 = new SqlCommand(comando, DBConnection.Instance);
            sqlcomando1.ExecuteNonQuery();
            DBConnection.Instance.Close();
        }

        [WebMethod]
        public static string ConfirmacaoExclusao()
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
