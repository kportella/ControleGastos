using Dominio.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.Data
{
    public class ControleGastosDbContext : DbContext
    {
        public ControleGastosDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        public DbSet<CategoriaModelo> Categorias { get; set; }
        public DbSet<TransacaoModelo> Transacoes { get; set; }
    }
}
