using DemoProject.CQS.ViewModels;
using MediatR;

namespace DemoProject.CQS.Commands.Demo;

public class InsertDemoObjectCommand : IRequest<DemoObjectViewModel>
{
    public string Name { get; set; }
}