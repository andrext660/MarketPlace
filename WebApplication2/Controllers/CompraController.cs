using MarketPlace.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Base;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{


    [ApiController]
    [Route("api/compras")]
    public class CompraController:ControllerBase
    {

        public Produto Produto;
        public Cartao Cartao;

       [HttpPost]
       [Route("")]
       public async Task<ActionResult<Compra>>
       Post([FromServices] DataContext context, [FromBody] Compra model)
        {
            if (ModelState.IsValid)
            {
                
                Produto = context.Produto.Find(model.ProdutoId);

                Cartao = context.Cartoes.Find(model.CartaoId);

                Produto.BaixaProduto(Produto, model);

                context.Compras.Add(model);

                context.Produto.Update(Produto);

                await context.SaveChangesAsync();
                return model;         
            }
            else
            {
                return BadRequest(ModelState);
            }

        }
    }
}
