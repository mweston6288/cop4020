using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COP4020.Pages;
using Guests.Services;
using Guests.Models;

public class FormModel : PageModel
{
    private readonly ILogger<FormModel> _logger;

    public FormModel(ILogger<FormModel> logger)
    {
        _logger = logger;
    }
    [BindProperty]
	public Guest NewGuest { get; set; } = new();
    public static bool hidden = true;
    public IActionResult OnPost()
    {
        if(Request.Form["NewGuest.Name"] == "" || (int.TryParse(Request.Form["NewGuest.Age"], out int x)&& int.Parse(Request.Form["NewGuest.Age"])<=0)){
            hidden = false;
            return Page();
        }
        GuestService.Add(NewGuest);
        ThanksModel.name = NewGuest.Name;
        hidden = true;
        return RedirectToPage("Thanks");
    }
}
