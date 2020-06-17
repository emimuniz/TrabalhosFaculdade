using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication13
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cabecalho.Text = gerarData();
        }
        private string gerarData()
        {
            StringBuilder sb = new StringBuilder();
            DateTime now = DateTime.Now;
            var data = now.ToString("dd/MM/yyyy");
            sb.AppendLine("<h1>" + data + "</h1>");
            return sb.ToString();


        }
    }
}
