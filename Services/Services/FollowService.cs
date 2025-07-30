using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class FollowService : IFollowService
    {
        public IEnumerable<Follow> GetAll() { throw new NotImplementedException(); }
        public Follow GetById(int id) { throw new NotImplementedException(); }
        public void Add(Follow follow) { throw new NotImplementedException(); }
        public void Delete(int id) { throw new NotImplementedException(); }
    }
}
