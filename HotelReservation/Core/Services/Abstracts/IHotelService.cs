using Core.Models;

namespace Core.Services.Abstracts
{
    public interface IHotelService
    {
        void AddHotel(Hotel hotel);
        List<Hotel> GetAllHotels();
        Hotel GetHotel(string name);
    }
}
