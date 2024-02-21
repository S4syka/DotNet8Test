using Domain.DTOs;
using Domain.Interfaces;

namespace DataAccessLayer.Repositories;

public class HomePictureRepository : BaseRepository<HomePicture>, IHomePictureRepository
{
    protected override string GetContainerName() => "homepictures";
}