using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CommentReportService : ICommentReportService
    {
        public IEnumerable<CommentReport> GetAll() { throw new NotImplementedException(); }
        public CommentReport GetById(int id) { throw new NotImplementedException(); }
        public void Add(CommentReport report) { throw new NotImplementedException(); }
        public void Update(CommentReport report) { throw new NotImplementedException(); }
        public void Delete(int id) { throw new NotImplementedException(); }
    }
}
