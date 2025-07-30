using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ApplicationUserService : IApplicationUserService
    {
        public IEnumerable<ApplicationUser> GetAll() { throw new NotImplementedException(); }
        public ApplicationUser GetById(int id) { throw new NotImplementedException(); }
        public void Add(ApplicationUser user) { throw new NotImplementedException(); }
        public void Update(ApplicationUser user) { throw new NotImplementedException(); }
        public void Delete(int id) { throw new NotImplementedException(); }

        public IEnumerable<CommentReport> GetAll() { throw new NotImplementedException(); }
        public CommentReport GetById(int id) { throw new NotImplementedException(); }
        public void Add(CommentReport report) { throw new NotImplementedException(); }
        public void Update(CommentReport report) { throw new NotImplementedException(); }
        public void Delete(int id) { throw new NotImplementedException(); }
    }
}
