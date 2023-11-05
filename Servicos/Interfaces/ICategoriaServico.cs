using Servicos.Dtos;

namespace Servicos.Interfaces
{
    public interface ICategoriaServico
    {
        Task<IEnumerable<BuscarCategoriaDto>> BuscarTodos();
    }
}
