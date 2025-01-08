using Microsoft.EntityFrameworkCore;
using VideosAPI.Models;

namespace VideosAPI.Data;

public class VideoContext : DbContext
{
    public DbSet<Video> Videos { get; set; }

    public VideoContext(DbContextOptions<VideoContext> options) : base(options)
    {

    }
}
