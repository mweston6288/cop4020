using Guests.Models;
using Guests.Services;
using Microsoft.AspNetCore.Mvc;

namespace Guests.Controllers;

[ApiController]
[Route("[controller]")]
public class GuestController : ControllerBase
{
    public GuestController()
    {
    }
	[Route("api/GetAll")]
	[HttpGet]
	public ActionResult<List<Guest>> GetAll() =>
		GuestService.GetAll();
}
