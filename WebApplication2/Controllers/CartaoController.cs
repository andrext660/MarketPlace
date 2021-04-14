using MarketPlace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Base;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{

    [ApiController]
    [Route("api/cartao")]
    
    public class CartaoController: ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Cartao>>> Get([FromServices] DataContext context)
        {
            var cartao = await context.Cartoes.ToListAsync();

            return cartao;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Cartao>> 
        Post([FromServices] DataContext context, [FromBody] Cartao model)
        {
            if (ModelState.IsValid)
            {
                context.Cartoes.Add(model);
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
