using System.Collections.Generic;
using TrailerParkApp.Models;

namespace TrailerParkApp.Services
{
    public class TrailerService
    {
        private readonly List<Trailer> _trailers = new();

        public void AddTrailer(Trailer trailer)
        {
            _trailers.Add(trailer);
        }

        public IEnumerable<Trailer> GetAllTrailers()
        {
            return _trailers;
        }

        public Trailer? GetTrailerByLot(int lotNumber)
        {
            return _trailers.Find(t => t.LotNumber == lotNumber);
        }
    }
}
