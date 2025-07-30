using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IApplicationUserService
    {
        IEnumerable<ApplicationUser> GetAll();
        ApplicationUser GetById(string id);
        void Add(ApplicationUser user);
        void Update(ApplicationUser user);
        void Delete(string id);
    }
}
