using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Models
{
    public class Pagamento
    {
        [Key]
        public int Id { get; set; }
        public float Valor { get; set; }
        public int CartaoId { get; set; }
        public Cartao Cartao { get; set; }
    }
}
