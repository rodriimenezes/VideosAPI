using VideosAPI.Data.Dtos;
using VideosAPI.Models;

namespace VideosAPI.Profile;

public class VideoProfile : AutoMapper.Profile
{
    public VideoProfile() 
    {
        CreateMap<CreateVideoDto, Video>();
    }
}
