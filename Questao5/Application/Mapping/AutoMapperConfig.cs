using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Questao5.Application.Queries.Responses;
using Questao5.Domain.Entities;
using Questao5.Infrastructure.Database.QueryStore.Responses;
using System.Diagnostics.Contracts;
using System.Globalization;

namespace Questao5.Application.Mapping
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(MappingProfile));
        }
    }

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ContaDetalheDTO, ContaCorrente>()
                 .ConstructUsing(c => new ContaCorrente(c.Id, c.Nome, c.Numero, c.Ativo))
                 .ForMember(dest => dest.Movimentos, opt => opt.MapFrom(src => src.Movimentacoes));

            CreateMap<MovimentacaoDto, Movimento>();
        }
    }
}
