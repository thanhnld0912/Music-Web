using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ISongService
    {
        IEnumerable<Song> GetAll();
        Song GetById(int id);
        void Add(Song song);
        void Update(Song song);
        void Delete(int id);
    }
}
