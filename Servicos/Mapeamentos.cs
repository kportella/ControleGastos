﻿using AutoMapper;
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
        }
    }
}
