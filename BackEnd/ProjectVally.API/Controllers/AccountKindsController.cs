using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using ProjectVally.Domain.Entities;
using ProjectVally.Application.Interface;
using ProjectVally.API.ViewModels;

namespace ProjectVally.API.Controllers
{
    public class AccountKindsController : ApiControllerBase<AccountKindViewModel, AccountKind>
    {
        private readonly IAccountKindAppService _accountKindApp;

        public AccountKindsController(IAccountKindAppService accountKindApp):base(accountKindApp)
        {
            this._accountKindApp = accountKindApp;
        }

        // GET: api/AccountKinds
        public IEnumerable<AccountKindViewModel> GetAccountKinds()
        {
            return GetAll();
        }

        // GET: api/AccountKinds/5
        [ResponseType(typeof(AccountKindViewModel))]
        public IHttpActionResult GetAccountKind(int id)
        {
            var accountKind = GetViewModelById(id);
            if (accountKind == null)
            {
                return NotFound();
            }

            return Ok(accountKind);
        }

        // PUT: api/AccountKinds/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAccountKind(int id, AccountKindViewModel accountKind)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != accountKind.AccountKindId)
            {
                return BadRequest();
            }
            var accountKindDomain = GetEntityByViewModel(accountKind);
            _accountKindApp.Update(accountKindDomain);


            if (!EntityExists(id))
            {
                return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/AccountKinds
        [ResponseType(typeof(AccountKindViewModel))]
        public IHttpActionResult PostAccountKind(AccountKindViewModel accountKind)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var accountKindDomain = GetEntityByViewModel(accountKind);
            _accountKindApp.Add(accountKindDomain);

            return CreatedAtRoute("DefaultApi", new { id = accountKindDomain.AccountKindId }, accountKind);
        }

        // DELETE: api/AccountKinds/5
        [ResponseType(typeof(AccountKindViewModel))]
        public IHttpActionResult DeleteAccountKind(int id)
        {
            AccountKind accountKind = _accountKindApp.GetById(id);
            if (accountKind == null)
            {
                return NotFound();
            }

            _accountKindApp.Remove(accountKind);

            var accountKindViewModel = GetViewModelByEntity(accountKind);

            return Ok(accountKindViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _accountKindApp.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}