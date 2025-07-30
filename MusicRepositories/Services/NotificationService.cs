using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class NotificationService : INotificationService
    {
        public IEnumerable<Notification> GetAll() { throw new NotImplementedException(); }
        public Notification GetById(int id) { throw new NotImplementedException(); }
        public void Add(Notification notification) { throw new NotImplementedException(); }
        public void Delete(int id) { throw new NotImplementedException(); }
    }
}
