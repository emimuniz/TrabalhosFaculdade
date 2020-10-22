using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TP02___Alberto
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Criação do arquivo 
            Voos depar = new Voos("VG456", "CGH", "POA", DateTime.Parse("14:35:00"), "Varig", true);
            FileStream fs = new FileStream(@"C:\Teste\Voos.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, depar);
            fs.Close();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(@"C:\Teste\Voos.bin");
            if (fi.Exists)
            {
                FileStream fs = new FileStream(@"C:\Teste\Voos.bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                Voos novo = (Voos)bf.Deserialize(fs);
                fs.Close();
                MessageBox.Show($"{novo.Cdvoo} - {novo.Origem} - {novo.Destino} - {novo.Horario} -  {novo.Compania}");
            }
            else
                MessageBox.Show("Arquivo inexistente.");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Voos depar = new Voos("AZ002", "VCP", "SSA", DateTime.Parse("18:00:00"), "Azul", true);
            FileStream fs = new FileStream(@"C:\Teste\Voos.xml", FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(Voos));
            xs.Serialize(fs, depar);
            fs.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(@"C:\Teste\Voos.xml");
            if (fi.Exists)
            {
                FileStream fs = new FileStream(@"C:\Teste\Voos.xml", FileMode.Open);
                XmlSerializer xs = new XmlSerializer(typeof(Voos));
                Voos novo = (Voos)xs.Deserialize(fs);
                fs.Close();
                MessageBox.Show($"{novo.Cdvoo} - {novo.Origem} - {novo.Destino} - {novo.Horario} -  {novo.Compania}");

            }
            else
                MessageBox.Show("Arquivo inexistente.");

        }
    }
}
