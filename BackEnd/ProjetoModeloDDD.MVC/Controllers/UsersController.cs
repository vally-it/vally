using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProjectVally.Application.Interface;
using ProjectVally.Domain.Entities;

namespace ProjectVally.MVC.Controllers
{
    public class UsersController : ApiController
    {
        private readonly IUserAppService _userApp;

        public UsersController(IUserAppService userApp)
        {
            _userApp = userApp;
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
            
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
