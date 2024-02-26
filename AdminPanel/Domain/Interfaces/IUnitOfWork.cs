using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces;

public interface IUnitOfWork
{
    public IFoodRepository FoodRepo();
    public IGalleryRepository GalleryRepo();
    public IHomePictureRepository HomePictureRepo();
    public IRoomRepository RoomRepo();
}
