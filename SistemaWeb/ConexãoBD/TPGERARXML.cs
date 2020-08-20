using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace TP02_XML
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Charset = "utf-8";


            string strFilePath = Server.MapPath("exemplo3.xml");
            XmlTextWriter xtw = new XmlTextWriter(strFilePath, Encoding.UTF8);
            xtw.Formatting = Formatting.Indented;

            xtw.WriteStartDocument();

            xtw.WriteStartElement("cursos");
            xtw.WriteStartElement("aulas");
            xtw.WriteAttributeString("linguagem", "asp.net");
            xtw.WriteStartElement("aula");
            xtw.WriteElementString("titulo", "DataSet para XML em ASP.NET / C#");
            xtw.WriteEndElement();
            xtw.WriteStartElement("aula");
            xtw.WriteElementString("titulo", "Hooks / React");
            xtw.WriteEndElement();
            xtw.WriteStartElement("aula");
            xtw.WriteElementString("titulo", "Ler arquivo XML usando XmlTextReader e XmlDocument em C# - ASP.NET");
            xtw.WriteEndElement();
            xtw.WriteEndElement();
            xtw.WriteStartElement("aulas");
            xtw.WriteAttributeString("linguagem", "JAVA");
            xtw.WriteStartElement("aula");
            xtw.WriteElementString("titulo", "Calcular idade em JAVA");
            xtw.WriteEndElement();
            xtw.WriteEndElement();
            xtw.WriteEndElement();

            xtw.WriteEndDocument();

            //libera o XmlTextWriter
            xtw.Flush();
            //fechar o XmlTextWriter
            xtw.Close();
            //Termina aqui

            Button3.Visible = true;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            string sCaminhoDoArquivo = Server.MapPath("exemplo3.xml");
            xml.Text = VisualizarXml(sCaminhoDoArquivo);


        }


        public static string VisualizarXml(string caminho)
        {
            StringBuilder sb = new StringBuilder();

            using (XmlTextReader xml = new XmlTextReader(caminho))
            {
                while (xml.Read())
                {

                    if (xml.NodeType == XmlNodeType.Text)
                    {
                        sb.Append(xml.Value + "<br />");
                    
                    }

                }

               
            }

            return sb.ToString();
        }
    }
}
