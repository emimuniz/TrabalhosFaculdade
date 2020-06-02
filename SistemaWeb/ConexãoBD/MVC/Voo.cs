using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTP.Models
{
    public class Voo
    {
        [Key]
        public string cdvoo { get; set; }
        public int cdcia { get; set; }
        public DateTime dtvoo { get; set; }
        public string lcori { get; set; }
        public string lcdes { get; set; }

        public int cdaero { get; set; }
        public decimal vlpass { get; set; }

    }
}
