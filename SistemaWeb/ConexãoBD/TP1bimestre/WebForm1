using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPAlberto
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static Int32 teste;
        static String usuario;
        static String senha;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Acesso"] != null && !IsPostBack)
            {
                TextBox1.Text = Request.Cookies["Acesso"]["funcionario"];
                TextBox2.Attributes.Add("value", Request.Cookies["Acesso"]["senha"]);
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            testeOi();
            usuario = TextBox1.Text;
            senha = TextBox2.Text;

            DBConnection.Instance.Open();
            string comando = "select nm_Funcionario from Funcionario where nm_Login ='" + usuario + "'" 
                + "and nu_Senha = '" + senha + "'";
            SqlCommand sqlcomando = new SqlCommand(comando, DBConnection.Instance);
            SqlDataReader dr = sqlcomando.ExecuteReader();

            try
            {
                if(teste != 0)
                {
                    DateTime now = DateTime.Now;

                    Session["sessionUser"] = TextBox1.Text;
                    Session["sessionPassword"] = TextBox2.Text;
                    Session["sessionBrowser"] = HttpContext.Current.Request.Browser.Browser;
                    //Session["sessionNome"] = dr["nm_Funcionario"].ToString();
                    Session["sessionData"] = now;

                    Response.Redirect("WebForm2.aspx");
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }

            DBConnection.Instance.Close();

        }

        public static  void testeOi()
        {
            DBConnection.Instance.Close();
            DBConnection.Instance.Open();
            string comando = "select * from Funcionario where nm_Login ='" + usuario + "'" + "and nu_Senha = '" + senha + "'";
            SqlCommand sqlcomando = new SqlCommand(comando, DBConnection.Instance);
            teste = Convert.ToInt32(sqlcomando.ExecuteScalar());
            DBConnection.Instance.Close();
        }

     
        [WebMethod]
        public static string ErroLogin()
        {
            if (teste == 0) return string.Format("Senha e Usuarios Incorretos, tente novamente");
            else return string.Format("Login realizado com sucesso");

            //HttpContext.Current.Response.Redirect("WebForm2.aspx");

        }
    }
}
