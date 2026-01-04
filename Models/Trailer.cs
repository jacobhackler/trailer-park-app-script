namespace TrailerParkApp.Models
{
    public class Trailer
    {
        public string Name { get; set; } = string.Empty;
        public int LotNumber { get; set; }
        public bool IsOccupied { get; set; } = false;

        public Trailer(string name, int lotNumber)
        {
            Name = name;
            LotNumber = lotNumber;
        }
    }
}
