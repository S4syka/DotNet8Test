using Domain.DTOs;

namespace DataAccessLayer.Repositories;

public class HomePictureRepository : BaseRepository<HomePicture>
{
    protected override string GetContainerName() => "homepictures";
}