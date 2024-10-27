using MusicStore.Models;

namespace MusicStore.ViewModels
{
    public class ArtistViewModel
    {
        public List<Album> Album { get; set; } = new List<Album>();
        public List<Artist> Artists { get; set; } = new List<Artist>();
    }
}
