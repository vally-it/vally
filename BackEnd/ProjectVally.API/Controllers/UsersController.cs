using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using AutoMapper;
using ProjectVally.Domain.Entities;
using ProjectVally.Application.Interface;
using ProjectVally.API.ViewModels;

namespace ProjectVally.API.Controllers
{
    public class UsersController : ApiControllerBase<UserViewModel, User>
    {
        private readonly IUserAppService _userApp;

        public UsersController(IUserAppService userApp):base(auserApp)
        {
            this._userApp = userApp;
        }

        // GET: api/Users
        public IEnumerable<UserViewModel> GetUsers()
        {
            return GetAll();
        }

        // GET: api/Users/5
        [ResponseType(typeof(UserViewModel))]
        public IHttpActionResult GetUser(int id)
        { 
            var userViewModel = GetViewModelById(id);
            if (userViewModel == null)
            {
                return NotFound();
            }

            return Ok(userViewModel);
        }

        // PUT: api/Users/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUser(int id, UserViewModel user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user.UserId)
            {
                return BadRequest();
            }
            var userDomain = GetEntityByViewModel(user);
            _userApp.Update(userDomain);


            if (!EntityExists(id))
            {
                return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Users
        [ResponseType(typeof(UserViewModel))]
        public IHttpActionResult PostUser(UserViewModel user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var userDomain = GetEntityByViewModel(user);
            _userApp.Add(userDomain);

            return CreatedAtRoute("DefaultApi", new { id = userDomain.UserId }, user);
        }

        // DELETE: api/Users/5
        [ResponseType(typeof(UserViewModel))]
        public IHttpActionResult DeleteUser(int id)
        {
            User user = _userApp.GetById(id);
            if (user == null)
            {
                return NotFound();
            }
            var userViewModel = GetViewModelByEntity(user);
            _userApp.Remove(user);

            return Ok(userViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _userApp.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}