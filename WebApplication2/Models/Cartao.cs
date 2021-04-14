using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Models
{
    public class Cartao
    {
        [Key]
       public int Id { get; set; }
        public string Titular { get; set; }
        public string Numero { get; set; }
        public string Data_Expiracao { get; set; }
        public string Bandeira { get; set; }
        public int Cvv { get; set; }
    }
}
