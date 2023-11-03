using StrawMusic.Application.Music;
using StrawMusic.Contracts.Music;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using StrawMusic.Application.Music.Queries;

namespace StrawMusic.Api.Controllers;

[Route("[controller]/[action]")]
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

    [HttpPost]
    public async Task<IActionResult> UploadMusic(UploadMusicRequest request)
    {
        var query = _mapper.Map<UploadCommand>(request);
        var uploadMusic = await _mediator.Send(query);
        return Ok(uploadMusic);
    }

    [HttpGet]
    public async Task<IActionResult> GetMusicById(GetMusicRequest id)
    {
        var query = new MusicQuery(id.id);
        return Ok(await _mediator.Send(query));
    }
}