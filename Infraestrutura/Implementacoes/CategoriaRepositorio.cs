using Dominio.Modelos;
using Infraestrutura.Data;
using Infraestrutura.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.Implementacoes
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly ControleGastosDbContext dbContext;

        public CategoriaRepositorio(ControleGastosDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<CategoriaModelo>> BuscarTodos()
        {
            return await dbContext.Categorias.ToListAsync();
        }

        public async Task<CategoriaModelo?> BuscarPorId(Guid id)
        {
            return await dbContext.Categorias.FindAsync(id);
        }

        public async Task<CategoriaModelo> Criar(CategoriaModelo categoria)
        {
            await dbContext.Categorias.AddAsync(categoria);
            await dbContext.SaveChangesAsync();

            return categoria;
        }

        public async Task Atualizar()
        {
            await dbContext.SaveChangesAsync();
        }
    }
}
