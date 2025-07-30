using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ILikeService
    {
        IEnumerable<Like> GetAll();
        Like GetById(int id);
        void Add(Like like);
        void Delete(int id);
    }
}
