using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ServicesTP
{
    public class clsDvdsModel
    {

        string _connection = @"data source= LAPTOP-LFF0LEIP\SQLEXPRESS; Integrated Security= SSPI; user id = userSisDist; Password = 'pastel123'; Initial Catalog= DbSisDist";

        public DataSet getDvdsDataSet(String strSQL, String strName)
        {
            try
            {
                using (SqlConnection cCommand = new SqlConnection(_connection))
                {
                    cCommand.Open();

                    SqlDataAdapter da;
                    DataSet ds;

                    da = new SqlDataAdapter(strSQL, cCommand);
                    ds = new DataSet();
                    da.Fill(ds, strName);
                    DataSet dtRetorno = new DataSet();


                    return ds;

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
