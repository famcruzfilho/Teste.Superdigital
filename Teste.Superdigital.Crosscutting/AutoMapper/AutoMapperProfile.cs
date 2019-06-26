using AutoMapper;
using Teste.Superdigital.Domain.DTOs;
using Teste.Superdigital.Domain.Models;
using Teste.Superdigital.Domain.ViewModels;

namespace Teste.Superdigital.Crosscutting.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            AutoMapperFilters();
        }

        private void AutoMapperFilters()
        {
            //Models para view models and vice versa
            CreateMap<ContaCorrente, ContaCorrenteViewModel>().ReverseMap();
            CreateMap<Lancamento, LancamentoViewModel>().ReverseMap();

            //Models para DTO's and vice versa
            CreateMap<ContaCorrente, ContaCorrenteDTO>().ReverseMap();
            CreateMap<Lancamento, LancamentoDTO>().ReverseMap();
        }
    }
}