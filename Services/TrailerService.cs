using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrailerParkApp.Models;

namespace TrailerParkApp.Services
{
    // Simple in-memory store for early development / UI wiring
    public class TrailerService : ITrailerService
    {
        private readonly ConcurrentDictionary<Guid, Trailer> _store = new();

        public TrailerService()
        {
            // seed example
            var t = new Trailer { Name = "Demo Trailer", VIN = "VIN123456" };
            _store[t.Id] = t;
        }

        public Task AddAsync(Trailer trailer)
        {
            _store[trailer.Id] = trailer;
            return Task.CompletedTask;
        }

        public Task DeleteAsync(Guid id)
        {
            _store.TryRemove(id, out _);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Trailer>> GetAllAsync()
        {
            return Task.FromResult(_store.Values.AsEnumerable());
        }

        public Task<Trailer?> GetByIdAsync(Guid id)
        {
            _store.TryGetValue(id, out var trailer);
            return Task.FromResult(trailer);
        }

        public Task UpdateAsync(Trailer trailer)
        {
            _store[trailer.Id] = trailer;
            return Task.CompletedTask;
        }
    }
}
