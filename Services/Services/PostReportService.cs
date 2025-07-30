using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class PostReportService : IPostReportService
    {
        public IEnumerable<PostReport> GetAll() { throw new NotImplementedException(); }
        public PostReport GetById(int id) { throw new NotImplementedException(); }
        public void Add(PostReport report) { throw new NotImplementedException(); }
        public void Delete(int id) { throw new NotImplementedException(); }
    }
}
