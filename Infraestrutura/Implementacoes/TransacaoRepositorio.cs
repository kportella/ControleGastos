using Dominio.Modelos;
using Infraestrutura.Data;
using Infraestrutura.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.Implementacoes
{
    public class TransacaoRepositorio : ITransacaoRepositorio
    {
        private readonly ControleGastosDbContext dbContext;

        public TransacaoRepositorio(ControleGastosDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<TransacaoModelo?> BuscarPorId(Guid id)
        {
            return await dbContext.Transacoes.FindAsync(id);
        }

        public async Task<IEnumerable<TransacaoModelo>> BuscarTodos()
        {
            return await dbContext.Transacoes.ToListAsync();
        }

        public async Task<TransacaoModelo> Criar(TransacaoModelo transacao)
        {
            await dbContext.Transacoes.AddAsync(transacao);
            await dbContext.SaveChangesAsync();

            return transacao;
        }
    }
}
