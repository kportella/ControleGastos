using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos.Dtos
{
    public class TransacaoDto
    {
        public bool Tipo { get; set; }
        public Guid CategoriaId { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public float Valor { get; set; }
    }
}
