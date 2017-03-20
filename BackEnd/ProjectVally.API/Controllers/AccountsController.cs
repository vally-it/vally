using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using ProjectVally.Domain.Entities;
using ProjectVally.Application.Interface;
using ProjectVally.API.ViewModels;
using AutoMapper;

namespace ProjectVally.API.Controllers
{
    public class AccountsController : ApiControllerBase<AccountViewModel, Account>
    {
        private readonly IAccountAppService _accountApp;
        
        public AccountsController(IAccountAppService accountApp):base(accountApp)
        {
            this._accountApp = accountApp;
        }

        // GET: api/Accounts
        public IEnumerable<AccountViewModel> GetAccounts()
        {
            return GetAll();
        }

        // GET: api/Accounts/5
        [ResponseType(typeof(AccountViewModel))]
        public IHttpActionResult GetAccount(int id)
        {
            var accountViewModel = GetViewModelById(id);
            if (accountViewModel == null)
            {
                return NotFound();
            }

            return Ok(accountViewModel);
        }

        // PUT: api/Accounts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAccount(int id, AccountViewModel account)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != account.AccountId)
            {
                return BadRequest();
            }
            var accountDomain = GetEntityByViewModel(account);
            _accountApp.Update(accountDomain);


            if (!EntityExists(id))
            {
                return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Accounts
        [ResponseType(typeof(AccountViewModel))]
        public IHttpActionResult PostAccount(AccountViewModel account)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var accountDomain = GetEntityByViewModel(account);
            _accountApp.Add(accountDomain);

            return CreatedAtRoute("DefaultApi", new { id = accountDomain.AccountId }, account);
        }

        // DELETE: api/Accounts/5
        [ResponseType(typeof(AccountViewModel))]
        public IHttpActionResult DeleteAccount(int id)
        {
            Account account = _accountApp.GetById(id);
            if (account == null)
            {
                return NotFound();
            }
            var accountViewModel = GetViewModelByEntity(account);
            _accountApp.Remove(account);

            return Ok(accountViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _accountApp.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}