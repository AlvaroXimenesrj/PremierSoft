using AutoMapper;
using MediatR;
using Questao5.Application.Commands.Requests;
using Questao5.Domain.Entities;
using Questao5.Infrastructure.Database.CommandStore.Requests;
using Questao5.Infrastructure.Database.QueryStore.Requests;

namespace Questao5.Application.Handlers
{
    public class ContaMovimentacaoCommandHandler : IRequestHandler<ContaMovimentacaoCommand, (object retorno, bool isValid)>
    {        
        private readonly IMapper _mapper;
        private readonly IContaReadRepository _contaReadRepository;
        private readonly IContaWriteRepository _contaWriteRepository;

        public ContaMovimentacaoCommandHandler(IMapper mapper,
                                               IContaReadRepository contaReadRepository,
                                               IContaWriteRepository contaWriteRepository)
        {   
            _mapper = mapper;
            _contaReadRepository = contaReadRepository;
            _contaWriteRepository = contaWriteRepository;
        }

        public async Task<(object retorno, bool isValid)> Handle(ContaMovimentacaoCommand request, CancellationToken cancellationToken)
        {

            var validationResult = request.ValidateRequisicaoMovimentacao();

            if (!validationResult)
            {
                var errosMessage = new { Erros = request.ValidationResult.Errors.Select(e => e.ErrorMessage) };
                return (errosMessage, false);
            }
            
            var contaId = Convert.ToInt32(request.Movimentacao.IdentificacaoContaId);
            var contaDTO = await _contaReadRepository.GetContabyId(contaId);

            if(contaDTO == null || contaDTO.ValidationResult.Errors.Select(e => e.ErrorMessage).Any())
            {
                
                var errosMessage = new { Erros = contaDTO.ValidationResult.Errors.Select(e => e.ErrorMessage).Any() };
                return (errosMessage, false);
            }            
            
            var conta = _mapper.Map<ContaCorrente>(contaDTO);
                       
            var movimentoId = await _contaWriteRepository.Movimentar(conta);

            return (new { movimentoId }, true);
        }

        
    }
}