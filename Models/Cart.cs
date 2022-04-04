using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCClient.Models
{
    public class Cart
    {
        [Key]
        public int Cid { get; set; }
        public string Desc { get; set; }
        public DateTime OrdDate { get; set; }
        public float Amount { get; set; }
    }
}
