using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace WebAPIAlberto.Models
{
    public class Voos
    { 

        public Voos(string cdvoo, int cdcia, DateTime dtvoo, string lcori, string lcdes, int cdaero, decimal vlpass)
        {
            this.cdvoo = cdvoo;
            this.cdcia = cdcia;
            this.dtvoo = dtvoo;
            this.lcori = lcori;
            this.lcdes = lcdes;
            this.cdaero = cdaero;
            this.vlpass = vlpass;
        }

        public string cdvoo { get; set; }
        public int cdcia { get; set; }
        public DateTime dtvoo { get; set; }
        public string lcori { get; set; }
        public string lcdes { get; set; }

        public int cdaero { get; set; }
        public decimal vlpass { get; set; }



    }
}
