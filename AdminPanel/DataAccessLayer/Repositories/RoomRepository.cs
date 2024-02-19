using Domain.DTOs;

namespace DataAccessLayer.Repositories;

public class RoomRepository : BaseRepository<Room>
{
    protected override string GetContainerName() => "rooms";
}