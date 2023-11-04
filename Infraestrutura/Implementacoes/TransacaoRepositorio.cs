using Dominio.Modelos;
using Infraestrutura.Data;
using Infraestrutura.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Implementacoes
{
    public class TransacaoRepositorio : ITransacaoRepositorio
    {
        private readonly ControleGastosDbContext dbContext;

        public TransacaoRepositorio(ControleGastosDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<TransacaoModelo> Criar(TransacaoModelo transacao)
        {
            await dbContext.Transacoes.AddAsync(transacao);
            await dbContext.SaveChangesAsync();

            return transacao;
        }
    }
}
