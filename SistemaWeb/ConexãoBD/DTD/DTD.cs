using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.IO;
using System.Xml.Linq;
using System.Web.UI;
using System.Windows.Forms;

namespace DTDAlberto
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static bool flag = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlReaderSettings settings = new XmlReaderSettings();

            settings.XmlResolver = new XmlUrlResolver();

            settings.ValidationType = ValidationType.DTD;
            settings.DtdProcessing = DtdProcessing.Parse;
            settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
            settings.IgnoreWhitespace = true;

            XmlReader reader = XmlReader.Create(@"C:\DTD\voos.xml", settings);

            while (reader.Read()) ;

            if (!flag)
                MessageBox.Show("Não foi encontrado nenhum erro");

        }

        private static void ValidationCallBack(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Error)
            {
                MessageBox.Show("Validation error: " + e.Message);
                flag = true;
            }
            


        }
    }
}
