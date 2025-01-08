using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;
using VideosAPI.Data;
using VideosAPI.Data.Dtos;
using VideosAPI.Models;

namespace VideosAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class VideoController : ControllerBase
{   
    private VideoContext _videoContext;
    private IMapper _mapper;

    public VideoController(VideoContext context, IMapper mapper)
    {
        _videoContext = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaVideo([FromBody] CreateVideoDto dto)
    {
        Video video = _mapper.Map<Video>(dto);
        _videoContext.Videos.Add(video);
        _videoContext.SaveChanges();
        return CreatedAtAction(nameof(RecuperaVideoPorId), new { id = videod.Id }, video);
    }

    [HttpGet]
    public IEnumerable<Video> RecuperaVideos([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _videoContext.Videos.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaVideoPorId(int id)
    {
        var video = _videoContext.Videos.FirstOrDefault(video => video.Id == id);
        if(video == null) return NotFound();
        return Ok(video);
    }
}
