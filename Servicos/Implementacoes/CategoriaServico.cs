using AutoMapper;
using Infraestrutura.Implementacoes;
using Infraestrutura.Interfaces;
using Servicos.Dtos;
using Servicos.Interfaces;

namespace Servicos.Implementacoes
{
    public class CategoriaServico : ICategoriaServico
    {
        private readonly ICategoriaRepositorio categoriaRepositorio;
        private readonly IMapper mapper;

        public CategoriaServico(ICategoriaRepositorio categoriaRepositorio, IMapper mapper)
        {
            this.categoriaRepositorio = categoriaRepositorio;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<BuscarCategoriaDto>> BuscarTodos()
        {
            return mapper.Map<IEnumerable<BuscarCategoriaDto>>(await categoriaRepositorio.BuscarTodos());
        }
    }
}
