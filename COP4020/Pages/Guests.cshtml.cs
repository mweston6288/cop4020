using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COP4020.Pages;
using Guests.Services;
using Guests.Models;
public class GuestsModel : PageModel
{
    public List<Guest> guests = new();

    public void OnGet()
    {
        guests = GuestService.GetAll();
    }
    public string Arrival(Guest guest){
        return guest.Arrival.ToString("hh:mm tt");
    }
    public string requiresParking(Guest guest){
        if(guest.RequiresParking)
            return "Yes";
        return "No";
    }
}
