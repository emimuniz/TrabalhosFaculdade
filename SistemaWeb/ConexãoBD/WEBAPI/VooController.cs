using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebAPIAlberto.Models;

namespace WebAPIAlberto.Controllers
{
    public class VooController : ApiController
    {

        string connetionString = @"data source= LAPTOP-LFF0LEIP\SQLEXPRESS; Integrated Security= SSPI; Initial Catalog= dbvoos";
        SqlConnection cnn = default(SqlConnection);
        SqlCommand cmd = default(SqlCommand);
        string query = null;
        private static List<Voos> voos = new List<Voos>();


        [HttpGet]
        public List<Voos> GetVoos()
        {
            query = "Select cdvoo, cdcia,  dtvoo, lcori, lcdes, cdaero, vlpass from TBvoos ";
            cnn = new SqlConnection(connetionString);

            cnn.Open();

            cmd = new SqlCommand(query, cnn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                var lista = new Voos(dr.GetString(0), dr.GetInt32(1), dr.GetDateTime(2), dr.GetString(3), dr.GetString(4), dr.GetInt32(5), dr.GetDecimal(6));
                voos.Add(lista);
            }

            cnn.Close();
            return voos;
        }


        [HttpGet]
        [Route("api/voo/{id}")]
        public Voos GetVoos(string id)
        {
            query = "Select cdvoo, cdcia,  dtvoo, lcori, lcdes, cdaero, vlpass from TBvoos where cdvoo = '" + id + "'";
            cnn = new SqlConnection(connetionString);

            cnn.Open();

            cmd = new SqlCommand(query, cnn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                return new Voos(dr.GetString(0), dr.GetInt32(1), dr.GetDateTime(2), dr.GetString(3), dr.GetString(4), dr.GetInt32(5), dr.GetDecimal(6));
                
            }

            cnn.Close();
            return null;
        }



        [HttpDelete]
        [Route("api/voo/{id}")]
        public void DeleteVoos(string id)
        {
            query = "Delete from TBvoos where cdvoo = '" + id + "'";
            cnn = new SqlConnection(connetionString);

            cnn.Open();

            cmd = new SqlCommand(query, cnn);
            cmd.ExecuteNonQuery();

            cnn.Close();
        }
    }
}
