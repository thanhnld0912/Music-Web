using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IPlaylistService
    {
        IEnumerable<Playlist> GetAll();
        Playlist GetById(int id);
        void Add(Playlist playlist);
        void Update(Playlist playlist);
        void Delete(int id);
    }
}
