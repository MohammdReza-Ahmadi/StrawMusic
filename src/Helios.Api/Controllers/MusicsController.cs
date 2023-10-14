using Helios.Application.Music;
using Helios.Contracts.Music;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Helios.Api.Controllers;

[Route("musics")]
public class MusicsController : ApiController
{
    private readonly ISender _mediator;
    private readonly IMapper _mapper;

    public MusicsController(ISender mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }


    [HttpGet]
    public IActionResult ListMusics()
    {
        return Ok(Array.Empty<string>());
    }

    [HttpPost("upload")]
    public async Task<IActionResult> UploadMusic(UploadMusicRequest request)
    {
        var query = _mapper.Map<UploadCommand>(request);
        var uploadMusic = await _mediator.Send(query);
        return Ok(uploadMusic);
    }
}