using Domain.Interfaces;
using Domain.DTOs;

namespace DataAccessLayer.Repositories;

public class FoodRepository : BaseRepository<Food>
{
    protected override string GetContainerName() => "foods";
}
