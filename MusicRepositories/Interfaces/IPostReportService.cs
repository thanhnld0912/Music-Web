using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IPostReportService
    {
        IEnumerable<PostReport> GetAll();
        PostReport GetById(int id);
        void Add(PostReport report);
        void Delete(int id);
    }
}
