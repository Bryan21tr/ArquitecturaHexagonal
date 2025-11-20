using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using PedidosAPI.Core.Dominio.Entidades;

namespace PedidosAPI.Configuracion
{

    public class AppDbContext : DbContext
    {
        public DbSet<Pedido> Pedidos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>().HasKey(p => p.Id);
        }
    }
}