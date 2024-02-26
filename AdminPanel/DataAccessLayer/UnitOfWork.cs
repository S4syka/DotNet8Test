using DataAccessLayer.Repositories;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer;

public class UnitOfWork : IUnitOfWork
{
    private Lazy<FoodRepository> _lazyFoodRepository = new Lazy<FoodRepository>();
    private Lazy<GalleryRepository> _lazyGalleryRepository = new Lazy<GalleryRepository>();
    private Lazy<HomePictureRepository> _lazyHomePictureRepository = new Lazy<HomePictureRepository>();
    private Lazy<RoomRepository> _lazyRoomRepository = new Lazy<RoomRepository>();

    public IFoodRepository FoodRepo()  => _lazyFoodRepository.Value;
    public IGalleryRepository GalleryRepo() => _lazyGalleryRepository.Value;
    public IHomePictureRepository HomePictureRepo() => _lazyHomePictureRepository.Value;
    public IRoomRepository RoomRepository() => _lazyRoomRepository.Value;
}
