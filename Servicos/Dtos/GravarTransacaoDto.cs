using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos.Dtos
{
    public class GravarTransacaoDto : TransacaoDto
    {
        public Guid Id { get; set; }
    }
}
