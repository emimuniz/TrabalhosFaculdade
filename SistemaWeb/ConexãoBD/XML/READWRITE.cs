using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

namespace TP01
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string strFilePath = Server.MapPath("exemplo3.xml");
            string sCaminhoDoArquivo = Server.MapPath("voos.xml");
            VisualizarXml(sCaminhoDoArquivo, strFilePath);
        }
      

        public static void VisualizarXml(string caminho, string strFilePath)
        {
            StringBuilder sb = new StringBuilder();
            
            using (XmlTextReader xml = new XmlTextReader(caminho))
            {
                XDocument doc = XDocument.Load(caminho);
                XmlTextReader reader = new XmlTextReader(caminho);
                reader.Read();

                XElement root = new XElement("voo");

                root.Add(new XAttribute("codigo", "LL145"));
                root.Add(new XElement("origem", "CWB"));
                root.Add(new XElement("destino", "GAL"));
                root.Add(new XElement("horario", "19:00"));
                root.Add(new XElement("compania", "Avianca"));
                root.Add(new XElement("operando", "T"));

                doc.Root.Add(root);            
                doc.Save(strFilePath);


            }

        }
    }
}
