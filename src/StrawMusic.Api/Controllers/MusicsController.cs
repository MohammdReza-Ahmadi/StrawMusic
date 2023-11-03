using StrawMusic.Application.Music;
using StrawMusic.Contracts.Music;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using StrawMusic.Application.Music.Queries;

namespace StrawMusic.Api.Controllers;

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

    [HttpGet("{id}")]
    public async Task<IActionResult> GetMusicById(GetMusicRequest id)
    {
        var query = _mapper.Map<MusicQuery>(id);
        return Ok(await _mediator.Send(query));
    }
}