using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ICommentReportService
    {
        IEnumerable<CommentReport> GetAll();
        CommentReport GetById(int id);
        void Add(CommentReport report);
        void Update(CommentReport report);
        void Delete(int id);
    }

}
