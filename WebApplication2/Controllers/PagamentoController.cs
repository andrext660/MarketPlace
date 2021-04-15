using MarketPlace.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Base;

namespace MarketPlace.Controllers
{
    public class PagamentoController:ControllerBase
    {
        public Cartao Cartao;


        [HttpPost]
        [Route("api/pagamento/compras")]
        public async Task<ActionResult<Pagamento>>
        Post([FromServices] DataContext context, [FromBody] Pagamento model)
        {
            if (model.Valor > 100.0)
            {
                if (ModelState.IsValid)  {
          
                    Cartao = context.Cartoes.Find(model.CartaoId);
                    context.Pagamentos.Add(model);
                    await context.SaveChangesAsync();   
            }
                
                return model;  
              
            }

            else
            {
                return BadRequest("Reprovado");
            }

        }
    }
}
