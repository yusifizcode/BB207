using Core.Models;

namespace Core.Services.Abstracts
{
    public interface IRoomService
    {
        void AddRoom(Room room);
        List<Room> FindAllRoom(Predicate<Room> predicate);
        void MakeReservation(int? roomId, int customerCount);
    }
}
