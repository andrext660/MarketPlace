using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Produto
    {


        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]

        [MaxLength(60, ErrorMessage = "Este campo deve conter 3 e 60 caracteres")]

        [MinLength(3, ErrorMessage = "Este campo deve conter 3 e 60 caracteres")]
        public string Nome { get; set; }
       
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1,int.MaxValue,ErrorMessage ="O preço o deve ser maior que zero")]
        public decimal Valor_Unitario { get; set; }
        public int Qtde_Estoque { get; set; }


        public static void BaixaProduto(Produto produto, Compra compra)
        {

            if (produto.Id == compra.ProdutoId)
            {

                if (produto.Qtde_Estoque >= compra.Qtde_Comprada)
                {
                    int value = produto.Qtde_Estoque - compra.Qtde_Comprada;
                    produto.Qtde_Estoque = value;

                }
            }


        }


    }
}
