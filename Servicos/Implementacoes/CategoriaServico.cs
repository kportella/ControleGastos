using AutoMapper;
using Dominio.Modelos;
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

        public async Task<BuscarCategoriaDto?> BuscarPorId(Guid id)
        {
            var categoria = await categoriaRepositorio.BuscarPorId(id);
            return categoria != null ? mapper.Map<BuscarCategoriaDto>(categoria) : null;

        }

        public async Task<IEnumerable<BuscarCategoriaDto>> BuscarTodos()
        {
            return mapper.Map<IEnumerable<BuscarCategoriaDto>>(await categoriaRepositorio.BuscarTodos());
        }

        public async Task<GravarCategoriaDto> Criar(CategoriaDto categoria)
        {
            var categoriaModelo = mapper.Map<CategoriaModelo>(categoria);

            categoriaModelo = await categoriaRepositorio.Criar(categoriaModelo);

            var retornoCategoria = mapper.Map<GravarCategoriaDto>(categoriaModelo);

            return retornoCategoria;
        }
    }
}
