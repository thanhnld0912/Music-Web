﻿using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class UserService : IUserService
    {
        public IEnumerable<User> GetAll() { throw new NotImplementedException(); }
        public User GetById(int id) { throw new NotImplementedException(); }
        public void Add(User user) { throw new NotImplementedException(); }
        public void Update(User user) { throw new NotImplementedException(); }
        public void Delete(int id) { throw new NotImplementedException(); }
    }
}
