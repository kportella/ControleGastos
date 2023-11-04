using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Interfaces
{
    public interface ITransacaoRepositorio
    {
        Task<TransacaoModelo> Criar(TransacaoModelo transacao);
    }
}
