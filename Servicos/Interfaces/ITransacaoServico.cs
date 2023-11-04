﻿using Servicos.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos.Interfaces
{
    public interface ITransacaoServico
    {
        Task<GravarTransacaoDto> Criar(TransacaoDto transacao);
    }
}
