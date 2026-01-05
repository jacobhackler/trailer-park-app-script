using System;

namespace TrailerParkApp.Models
{
    public class Trailer
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string VIN { get; set; } = string.Empty;
        public DateTime LastServiced { get; set; } = DateTime.UtcNow;
    }
}
