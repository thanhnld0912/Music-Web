using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IRecentPlayService
    {
        IEnumerable<RecentPlay> GetAll();
        RecentPlay GetById(int id);
        void Add(RecentPlay recentPlay);
        void Delete(int id);
    }
}
