using Microsoft.AspNetCore.Mvc;
using VideosAPI.Models;

namespace VideosAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class VideoController : ControllerBase
{
    private static List<Video> videos = new List<Video>();

    [HttpPost]
    public IActionResult AdicionaVideo([FromBody] Video video)
    {
        videos.Add(video);
        return Ok();
    }

    [HttpGet]
    public IEnumerable<Video> RecuperaVideos()
    {
        return videos;
    }
}
