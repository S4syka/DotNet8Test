using Domain.DTOs;
using Domain.Interfaces;

namespace DataAccessLayer.Repositories;

public class GalleryRepository : BaseRepository<Gallery>, IGalleryRepository
{
    protected override string GetContainerName() => "galleries";
}