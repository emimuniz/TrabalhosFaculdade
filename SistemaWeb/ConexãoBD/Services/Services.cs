using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServicesTP
{
    [WebService(Namespace = "http://teste/webservices/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public DataSet DvdsDataSet(String idBanda)
        {
            clsDvdsModel oModel = new clsDvdsModel();
            DataSet ds = new DataSet();
            ds = oModel.getDvdsDataSet("sp_lis_Dvds " + idBanda, "dvds");
            return ds;
        }
        
    }
}
