using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class DislikeService : IDislikeService
    {
        public IEnumerable<Dislike> GetAll() { throw new NotImplementedException(); }
        public Dislike GetById(int id) { throw new NotImplementedException(); }
        public void Add(Dislike dislike) { throw new NotImplementedException(); }
        public void Delete(int id) { throw new NotImplementedException(); }
    }
}
