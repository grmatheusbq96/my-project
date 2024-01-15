using AutoMapper;
using DemoProject.CQS.Commands.Demo;
using DemoProject.CQS.ViewModels;
using DemoProject.Domain.Models;
using MediatR;

namespace DemoProject.Application.Handlers.Demo;

public class InsertDemoObjectHandler(IMapper mapper) : IRequestHandler<InsertDemoObjectCommand, DemoObjectViewModel>
{
    private readonly IMapper _mapper = mapper;

    public async Task<DemoObjectViewModel> Handle(InsertDemoObjectCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var retornoAposCadastroNaBase = new DemoObjectModel(request.Name, 1);

            var retorno = _mapper.Map<DemoObjectViewModel>(retornoAposCadastroNaBase);

            return await Task.FromResult(retorno);
        }
        catch (Exception)
        {
            return null;
        }
    }
}