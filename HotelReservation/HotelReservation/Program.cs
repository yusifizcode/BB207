using Core.Exceptions;
using Core.Models;
using Core.Services.Concretes;

namespace HotelReservation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HotelService hotelService = new HotelService();
            RoomService roomService = new RoomService();
            bool check = true;
            bool checkSub = true;
            do
            {
                Console.WriteLine("1. Enter system\n" +
                                  "0. Exit");

                string answer = Console.ReadLine();
                switch (answer)
                {

                    case "1":
                        do
                        {
                            Console.WriteLine("1.Hotel yarat\n" +
                                          "2.Butun Hotelleri gor\n" +
                                          "3.Hotel sec\n" +
                                          "0.Exit");

                            string subAnswer = Console.ReadLine();
                            switch (subAnswer)
                            {
                                case "1":
                                    Console.WriteLine("Yaratmaq istediyiniz hotelin adini daxil edin: ");
                                    string name = Console.ReadLine();
                                    Hotel hotel = new Hotel(name);
                                    hotelService.AddHotel(hotel);
                                    break;
                                case "2":
                                    hotelService.GetAllHotels()
                                                .ForEach(hotel => Console.WriteLine(hotel.Name));
                                    break;
                                case "3":
                                    do
                                    {
                                        Console.WriteLine("Secmek istediyiniz hotelin adini daxil edin: ");
                                        name = Console.ReadLine();
                                        Console.WriteLine("\t" + hotelService.GetHotel(name).Name);

                                        Console.WriteLine("1.Room yarat\n" +
                                                          "2.Roomlari gor\n" +
                                                          "3.Rezervasya et\n" +
                                                          "4.Evvelki menuya qayit.\n" +
                                                          "0.Exit");
                                        subAnswer = Console.ReadLine();
                                        switch (subAnswer)
                                        {
                                            case "1":
                                                Console.WriteLine("Otagin adini daxil edin: ");
                                                string roomName = Console.ReadLine();
                                                string roomPriceStr = String.Empty;
                                                double roomPrice;
                                                do
                                                {
                                                    Console.WriteLine("Otagin qiymetini daxil edin: ");
                                                    roomPriceStr = Console.ReadLine();
                                                } while (!double.TryParse(roomPriceStr, out roomPrice));

                                                string roomCapacityStr = String.Empty;
                                                byte roomCapacity;
                                                do
                                                {
                                                    Console.WriteLine("Otagin tutumunu daxil edin: ");
                                                    roomCapacityStr = Console.ReadLine();
                                                } while (!byte.TryParse(roomCapacityStr, out roomCapacity));

                                                Room room = new Room(roomName, roomPrice, roomCapacity);
                                                roomService.AddRoom(room);
                                                break;
                                            case "2":
                                                roomService.FindAllRoom(x => true)
                                                           .ForEach(room => Console.WriteLine(room));
                                                break;
                                            case "3":
                                                string idStr = "";
                                                int id;
                                                do
                                                {
                                                    Console.WriteLine("Istediyiniz otagin id'ni daxil edin: ");
                                                    idStr = Console.ReadLine();
                                                } while (!int.TryParse(idStr, out id));

                                                roomCapacityStr = String.Empty;
                                                do
                                                {
                                                    Console.WriteLine("Istediyiniz otagin tutumunu daxil edin: ");
                                                    roomCapacityStr = Console.ReadLine();
                                                } while (!byte.TryParse(roomCapacityStr, out roomCapacity));

                                                try
                                                {
                                                    roomService.MakeReservation(id, roomCapacity);
                                                    Console.WriteLine("Rezerv olundu!");
                                                }
                                                catch (NullReferenceException ex)
                                                {
                                                    Console.WriteLine(ex.Message);
                                                }
                                                catch (NotAvailableException ex)
                                                {
                                                    Console.WriteLine(ex.Message);
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine("Bilinmedik bir xeta bash verdi!");
                                                }
                                                break;
                                            case "4":
                                                checkSub = false;
                                                break;
                                            case "0":
                                                check = false;
                                                break;
                                            default:
                                                break;
                                        }
                                        break;
                                    } while (checkSub);
                                    break;
                                case "0":
                                    check = false;
                                    break;
                                default:
                                    break;
                            }
                        } while (check);
                        break;
                    case "0":
                        check = false;
                        break;
                    default:
                        break;
                }

            } while (check);
        }
    }
}