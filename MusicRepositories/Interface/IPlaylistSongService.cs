using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IPlaylistSongService
    {
        IEnumerable<PlaylistSong> GetAll();
        PlaylistSong GetById(int id);
        void Add(PlaylistSong playlistSong);
        void Delete(int id);
    }
}
