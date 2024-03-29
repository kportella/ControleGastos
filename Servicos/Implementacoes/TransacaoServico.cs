﻿using AutoMapper;
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

        public async Task<GravarTransacaoDto?> Atualizar(Guid id, TransacaoDto transacao)
        {
            var transacaoAtual = await transacaoRepositorio.BuscarPorId(id);
            if (transacaoAtual == null) return null;

            transacaoAtual.Data = transacao.Data;
            transacaoAtual.Descricao = transacao.Descricao;
            transacaoAtual.Valor = transacao.Valor;
            transacaoAtual.Tipo = transacao.Tipo;
            transacaoAtual.CategoriaId = transacao.CategoriaId;

            await transacaoRepositorio.Atualizar();

            return mapper.Map<GravarTransacaoDto>(transacaoAtual);
        }

        public async Task<BuscarTransacaoDto?> BuscarPorId(Guid id)
        {
            var transacao = await transacaoRepositorio.BuscarPorId(id);
            return transacao != null ? mapper.Map<BuscarTransacaoDto>(transacao) : null;
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

        public async Task Deletar(Guid id)
        {
            var transacaoAtual = await transacaoRepositorio.BuscarPorId(id);

            if (transacaoAtual == null) return;

            await transacaoRepositorio.Deletar(transacaoAtual);
        }
    }
}
