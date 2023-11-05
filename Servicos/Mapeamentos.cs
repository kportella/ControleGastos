using AutoMapper;
using Dominio.Modelos;
using Servicos.Dtos;

namespace Servicos
{
    public class Mapeamentos : Profile
    {
        public Mapeamentos() 
        {
            CreateMap<TransacaoModelo, TransacaoDto>().ReverseMap();
            CreateMap<TransacaoModelo, GravarTransacaoDto>().ReverseMap();
            CreateMap<TransacaoModelo, BuscarTransacaoDto>().ReverseMap();

            CreateMap<CategoriaModelo, BuscarCategoriaDto>().ReverseMap();
            CreateMap<CategoriaModelo, GravarCategoriaDto>().ReverseMap();
            CreateMap<CategoriaModelo, CategoriaDto>().ReverseMap();

        }
    }
}
