using Domain.DTOs;

namespace DataAccessLayer.Repositories;

public class GalleryRepository : BaseRepository<Gallery>
{
    protected override string GetContainerName() => "galleries";
}