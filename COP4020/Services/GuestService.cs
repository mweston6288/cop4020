using Guests.Models;

namespace Guests.Services;

public static class GuestService
{
    static List<Guest> Guests { get; }
    static GuestService()
    {
        Guests = new List<Guest>{};
    }

    public static List<Guest> GetAll() => Guests;

    public static void Add(Guest guest)
    {
        Guests.Add(guest);
    }

}
