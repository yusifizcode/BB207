using Core.DataAccessLayer;
using Core.Models;
using Core.Services.Abstracts;

namespace Core.Services.Concretes
{
    public class HotelService : IHotelService
    {
        public void AddHotel(Hotel hotel)
        {
            AppDb.Hotels.Add(hotel);
        }

        public List<Hotel> GetAllHotels()
        {
            return AppDb.Hotels;
        }

        public Hotel GetHotel(string name)
        {
            return AppDb.Hotels.Find(hotel => hotel.Name.ToLower() == name.ToLower());
        }
    }
}
