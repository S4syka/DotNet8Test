using Domain.DTOs;
using Domain.Interfaces;

namespace DataAccessLayer.Repositories;

public class RoomRepository : BaseRepository<Room>, IRoomRepository
{
    protected override string GetContainerName() => "rooms";
}