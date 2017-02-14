﻿using System.Collections.Generic;
using System.Web.Http;
using ProjectVally.Application;
using ProjectVally.Application.Interface;
using ProjectVally.Domain.Entities;
using ProjectVally.Domain.Services;
using ProjectVally.Infra.Data.Repositories;

namespace ProjectVally.MVC.Controllers
{
    public class UsersController : ApiController
    {
        private readonly IUserAppService _userApp;

        public UsersController()
        {
            _userApp = new UserAppService(new UserService(new UserRepository()));
        }


        // GET: api/Users
        public IEnumerable<User> Get()
        {

            return _userApp.GetAll();
        }

        // GET: api/Users/5
        public User Get(int id)
        {
            return _userApp.GetById(id);
        }

        // POST: api/Users
        [HttpPost]
        public void Post(User user)
        {
            _userApp.Add(user);
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]User value)
        {
            _userApp.Update(value);
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
            var user = _userApp.GetById(id);
            _userApp.Remove(user);
        }
    }
}
