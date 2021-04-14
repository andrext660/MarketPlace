using MarketPlace.Models;
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
        public int IdCompra { get; set; }

        public int ProdutoId { get; set; }
        public int Qtde_Comprada { get; set; }
        public int CartaoId { get; set; }
        public Cartao Cartao { get; set; }

        public Produto Produto { get; set; }


      
    }
}
