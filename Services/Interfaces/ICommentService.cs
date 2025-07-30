using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Services.Interfaces
{
    public interface ICommentService
    {
        IEnumerable<Comment> GetAll();
        Comment GetById(int id);
        void Add(Comment comment);
        void Update(Comment comment);
        void Delete(int id);
    }

}
