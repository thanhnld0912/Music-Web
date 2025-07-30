using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IDislikeService
    {
        IEnumerable<Dislike> GetAll();
        Dislike GetById(int id);
        void Add(Dislike dislike);
        void Delete(int id);
    }
}
