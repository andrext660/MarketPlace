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
    [Route("api/produtos")]
    public class ProdutoController : ControllerBase
    {


        public async Task<ActionResult<List<Produto>>> Get([FromServices] DataContext context)
        {
            var produtos = await context.Produto.ToListAsync();
            return produtos;
        }


        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Produto>> GetById([FromServices] DataContext context, int id)
        {
            var produtos = await context.Produto.FirstOrDefaultAsync(x => x.Id == id);
            return produtos;
        }


        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Produto>>
        Post([FromServices] DataContext context, [FromBody] Produto model)
        {
            if (ModelState.IsValid)
            {
                context.Produto.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }

        }


        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<Produto>> DeleteById([FromServices] DataContext context, int id)
        {
            var produtos = await context.Produto.FirstOrDefaultAsync(x => x.Id == id);
            context.Produto.Remove(produtos);
            await context.SaveChangesAsync();

            return produtos;

        }



    }
}
