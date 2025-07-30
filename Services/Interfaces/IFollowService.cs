using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IFollowService
    {
        IEnumerable<Follow> GetAll();
        Follow GetById(int id);
        void Add(Follow follow);
        void Delete(int id);
    }
}
