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
    [Route("v1/categorias")]
    
    public class CategoriaController: ControllerBase
    {
        [HttpGet]
        [Route("")]

        public async Task<ActionResult<List<Categoria>>> Get([FromServices] DataContext context)
        {
            var categorias = await context.Categorias.ToListAsync();
            return categorias;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Categoria>> 
        Post([FromServices] DataContext context, [FromBody] Categoria model)
        {
            if (ModelState.IsValid)
            {
                context.Categorias.Add(model);
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
