using Core.DataAccessLayer;
using Core.Exceptions;
using Core.Models;
using Core.Services.Abstracts;

namespace Core.Services.Concretes
{
    public class RoomService : IRoomService
    {
        public void AddRoom(Room room)
        {
            AppDb.Rooms.Add(room);
        }

        public List<Room> FindAllRoom(Predicate<Room> predicate)
        {
            return AppDb.Rooms.FindAll(predicate);
        }

        public void MakeReservation(int? roomId, int customerCount)
        {
            if (roomId == null)
                throw new NullReferenceException("Room not found!");

            Room existRoom = AppDb.Rooms.Find(room => room.Id == roomId);

            if (existRoom == null || !existRoom.IsAvialable || existRoom.PersonCapacity < customerCount)
                throw new NotAvailableException("Room not available!");

            existRoom.IsAvialable = false;
        }
    }
}
