using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrailerParkApp.Models;

namespace TrailerParkApp.Services
{
    public interface ITrailerService
    {
        Task<IEnumerable<Trailer>> GetAllAsync();
        Task<Trailer?> GetByIdAsync(Guid id);
        Task AddAsync(Trailer trailer);
        Task UpdateAsync(Trailer trailer);
        Task DeleteAsync(Guid id);
    }
}
