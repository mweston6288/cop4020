namespace Guests.Models;

public class Guest
{
    public string? Name { get; set; }
    public int Age {get;set;}
    public DateTime Arrival{get;set;}
    public bool RequiresParking { get; set; }
}
