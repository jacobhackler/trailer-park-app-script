using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TrailerParkApp.Models;
using TrailerParkApp.Services;

namespace TrailerParkApp.ViewModels
{
    public class TrailerViewModel : INotifyPropertyChanged
    {
        private readonly ITrailerService _service;

        public ObservableCollection<Trailer> Trailers { get; } = new();

        public TrailerViewModel(ITrailerService service)
        {
            _service = service;
        }

        public async Task LoadAsync()
        {
            Trailers.Clear();
            var items = await _service.GetAllAsync();
            foreach (var t in items)
                Trailers.Add(t);
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void Raise([CallerMemberName] string? name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
