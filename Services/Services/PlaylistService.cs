using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class PlaylistService : IPlaylistService
    {
        public IEnumerable<Playlist> GetAll() { throw new NotImplementedException(); }
        public Playlist GetById(int id) { throw new NotImplementedException(); }
        public void Add(Playlist playlist) { throw new NotImplementedException(); }
        public void Update(Playlist playlist) { throw new NotImplementedException(); }
        public void Delete(int id) { throw new NotImplementedException(); }
    }
}
