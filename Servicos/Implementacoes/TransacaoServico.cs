using AutoMapper;
using Dominio.Modelos;
using Infraestrutura.Interfaces;
using Servicos.Dtos;
using Servicos.Interfaces;

namespace Servicos.Implementacoes
{
    public class TransacaoServico : ITransacaoServico
    {
        private readonly IMapper mapper;
        private readonly ITransacaoRepositorio transacaoRepositorio;

        public TransacaoServico(IMapper mapper, ITransacaoRepositorio transacaoRepositorio)
        {
            this.mapper = mapper;
            this.transacaoRepositorio = transacaoRepositorio;
        }

        public async Task<IEnumerable<BuscarTransacaoDto>> BuscarTodos()
        {
            return mapper.Map<IEnumerable<BuscarTransacaoDto>>(await transacaoRepositorio.BuscarTodos());
        }

        public async Task<GravarTransacaoDto> Criar(TransacaoDto transacao)
        {
            var transacaoModelo = mapper.Map<TransacaoModelo>(transacao);

            transacaoModelo = await transacaoRepositorio.Criar(transacaoModelo);

            var retornoTransacao = mapper.Map<GravarTransacaoDto>(transacaoModelo);

            return retornoTransacao;
        }
    }
}
