using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class PlaylistSongService : IPlaylistSongService
    {
        public IEnumerable<PlaylistSong> GetAll() { throw new NotImplementedException(); }
        public PlaylistSong GetById(int id) { throw new NotImplementedException(); }
        public void Add(PlaylistSong playlistSong) { throw new NotImplementedException(); }
        public void Delete(int id) { throw new NotImplementedException(); }
    }
}
