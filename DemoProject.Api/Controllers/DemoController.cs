using AutoMapper;
using DemoProject.CQS.Commands.Demo;
using DemoProject.CQS.Dtos.Demo;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DemoProject.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DemoController(IMapper mapper, IMediator mediator) : ControllerBase
{
    private readonly IMapper _mapper = mapper;
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Ok");
    }

    [HttpPost]
    public IActionResult Post([FromBody] InsertDemoObjectDto dto) =>
        Ok(_mediator.Send(_mapper.Map<InsertDemoObjectCommand>(dto)).Result);
}