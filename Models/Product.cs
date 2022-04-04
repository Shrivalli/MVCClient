using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCClient.Models
{
    public class Product
    {
        [Key]
        public int Pid { get; set; }
        public string Pname { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }
    }
}
