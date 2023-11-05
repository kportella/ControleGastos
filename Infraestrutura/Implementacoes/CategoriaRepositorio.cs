using Dominio.Modelos;
using Infraestrutura.Data;
using Infraestrutura.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
