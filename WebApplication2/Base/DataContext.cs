using MarketPlace.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Base
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Cartao> Cartoes { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
    }
}