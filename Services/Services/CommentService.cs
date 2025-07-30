using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Services.Services
{
    public class CommentService : ICommentService
    {
        public IEnumerable<Comment> GetAll() { throw new NotImplementedException(); }
        public Comment GetById(int id) { throw new NotImplementedException(); }
        public void Add(Comment comment) { throw new NotImplementedException(); }
        public void Update(Comment comment) { throw new NotImplementedException(); }
        public void Delete(int id) { throw new NotImplementedException(); }
    }
}
