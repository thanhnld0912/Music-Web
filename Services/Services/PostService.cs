using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class PostService : IPostService
    {
        public IEnumerable<Post> GetAll() { throw new NotImplementedException(); }
        public Post GetById(int id) { throw new NotImplementedException(); }
        public void Add(Post post) { throw new NotImplementedException(); }
        public void Update(Post post) { throw new NotImplementedException(); }
        public void Delete(int id) { throw new NotImplementedException(); }
    }
}
