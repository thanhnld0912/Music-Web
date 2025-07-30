using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class SongService : ISongService
    {
        public IEnumerable<Song> GetAll() { throw new NotImplementedException(); }
        public Song GetById(int id) { throw new NotImplementedException(); }
        public void Add(Song song) { throw new NotImplementedException(); }
        public void Update(Song song) { throw new NotImplementedException(); }
        public void Delete(int id) { throw new NotImplementedException(); }
    }
}
