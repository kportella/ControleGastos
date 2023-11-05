using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Interfaces
{
    public interface ICategoriaRepositorio
    {
        Task<IEnumerable<CategoriaModelo>> BuscarTodos();
        Task<CategoriaModelo?> BuscarPorId(Guid id);

    }
}
