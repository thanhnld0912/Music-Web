using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class RecentPlayService : IRecentPlayService
    {
        public IEnumerable<RecentPlay> GetAll() { throw new NotImplementedException(); }
        public RecentPlay GetById(int id) { throw new NotImplementedException(); }
        public void Add(RecentPlay recentPlay) { throw new NotImplementedException(); }
        public void Delete(int id) { throw new NotImplementedException(); }
    }
}
