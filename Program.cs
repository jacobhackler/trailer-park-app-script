using TrailerParkApp.Models;
using TrailerParkApp.Services;

var service = new TrailerService();

service.AddTrailer(new Trailer("Red Trailer", 1));
service.AddTrailer(new Trailer("Blue Trailer", 2));

foreach (var trailer in service.GetAllTrailers())
{
    Console.WriteLine($"Lot {trailer.LotNumber}: {trailer.Name}, Occupied: {trailer.IsOccupied}");
}
