using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP02_XML.Models;

namespace TP02_XML
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string arquivo = Server.MapPath("voos.json");
            JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();

            using (StreamReader r = new StreamReader(arquivo))
            {

                string json = r.ReadToEnd();
                var array = serializer.Deserialize<List<Voo>>(json);

                if (!IsPostBack)
                {
                    foreach (Voo arrayVoo in array)
                    {
                        DropDownList1.Items.Add(arrayVoo.cdvoo);
                    }

                    DropDownList1.Items.Insert(0, new ListItem("Selecione um item"));
                }


                DataTable dt = new DataTable();

                dt.Columns.AddRange(new DataColumn[6] { new DataColumn("Vôo"), new DataColumn("Data do Vôo"), 
                new DataColumn("Origem"), new DataColumn("Destino"), new DataColumn("Valor Passagem"), new DataColumn("Aeronave") });

                foreach (Voo arrayVoo in array)
                {
                    DateTime data = Convert.ToDateTime(arrayVoo.dtvoo);
                    string vl = arrayVoo.vlpass.ToString();
                    dt.Rows.Add(arrayVoo.cdvoo, data.ToString("dd/MM/yyyy"), arrayVoo.lcori,  arrayVoo.lcdes, vl, arrayVoo.cdcia);
                }

                GridView1.DataSource = dt;
                GridView1.DataBind();
                
            }   
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string arquivo = Server.MapPath("voos.json");
            JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();

            string strFilePath = Server.MapPath("voo.json");
            List<Voo> _data = new List<Voo>();



            using (StreamReader r = new StreamReader(arquivo))
            {
                    
                string json = r.ReadToEnd();
                var array = serializer.Deserialize<List<Voo>>(json);
                 DataTable dt = (DataTable)GridView1.DataSource;

                dt.Rows.Clear();
                foreach (Voo arrayVoo in array)
                {
                    if(arrayVoo.cdvoo == DropDownList1.SelectedValue.ToString())
                    {
                        DateTime data = Convert.ToDateTime(arrayVoo.dtvoo);
                        string vl = arrayVoo.vlpass.ToString();
                        dt.Rows.Add(arrayVoo.cdvoo, data.ToString("dd/MM/yyyy"), arrayVoo.lcori, arrayVoo.lcdes, vl, arrayVoo.cdcia);

                        _data.Add(new Voo()
                        {
                            cdvoo = arrayVoo.cdvoo,
                            cdcia = arrayVoo.cdcia,
                            dtvoo = arrayVoo.dtvoo,
                            lcori =  arrayVoo.lcori,
                            lcdes = arrayVoo.lcdes,
                            cdaero = arrayVoo.cdaero,
                            vlpass = arrayVoo.vlpass
                        });

                 
                    }
                    
                }
                string json2 = JsonConvert.SerializeObject(_data.ToArray(), Formatting.Indented);
                System.IO.File.WriteAllText(strFilePath, json2);

                GridView1.DataSource = dt;
                GridView1.DataBind();

            }
        }
    }
}
