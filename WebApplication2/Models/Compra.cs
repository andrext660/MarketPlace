using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Base;

namespace WebApplication2.Models
{
    public class Compra
    {
        [Key]
        public int Id;
       
        [Required]
        public int Qtde_Comprada {get;set;}
        public string Titular { get; set; }
        public int Numero { get; set; }

        public string Data_Expiracao { get; set; }
        public string Bandeira { get; set; }
        public int Cvv { get; set; }

        [Required]
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }



    }
}
