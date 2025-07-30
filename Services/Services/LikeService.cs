using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class LikeService : ILikeService
    {
        public IEnumerable<Like> GetAll() { throw new NotImplementedException(); }
        public Like GetById(int id) { throw new NotImplementedException(); }
        public void Add(Like like) { throw new NotImplementedException(); }
        public void Delete(int id) { throw new NotImplementedException(); }
    }
}
