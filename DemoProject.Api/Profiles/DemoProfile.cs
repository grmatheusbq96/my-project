using AutoMapper;
using DemoProject.CQS.Commands.Demo;
using DemoProject.CQS.Dtos.Demo;
using DemoProject.CQS.ViewModels;
using DemoProject.Domain.Models;

namespace DemoProject.Api.Profiles;

public class DemoProfile : Profile
{
    public DemoProfile()
    {
        #region Mapeamentos de input

        CreateMap<InsertDemoObjectCommand, InsertDemoObjectDto>();
        CreateMap<InsertDemoObjectDto, InsertDemoObjectCommand>();

        #endregion Mapeamentos de input

        #region Mapeamentos de output

        CreateMap<DemoObjectModel, DemoObjectViewModel>();
        CreateMap<DemoObjectViewModel, DemoObjectModel>();

        #endregion Mapeamentos de output
    }
}