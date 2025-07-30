using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface INotificationService
    {
        IEnumerable<Notification> GetAll();
        Notification GetById(int id);
        void Add(Notification notification);
        void Delete(int id);
    }
}
