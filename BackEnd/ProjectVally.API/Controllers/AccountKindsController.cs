using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using ProjectVally.Domain.Entities;
using ProjectVally.Application.Interface;

namespace ProjectVally.API.Controllers
{
    public class AccountKindsController : ApiController
    {
        private readonly IAccountKindAppService _accountKindApp;

        public AccountKindsController(IAccountKindAppService accountKindApp)
        {

            this._accountKindApp = accountKindApp;
        }

        // GET: api/AccountKinds
        public IEnumerable<AccountKind> GetAccountKinds()
        {
            return _accountKindApp.GetAll();
        }

        // GET: api/AccountKinds/5
        [ResponseType(typeof(AccountKind))]
        public IHttpActionResult GetAccountKind(int id)
        {
            AccountKind accountKind = _accountKindApp.GetById(id);
            if (accountKind == null)
            {
                return NotFound();
            }

            return Ok(accountKind);
        }

        // PUT: api/AccountKinds/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAccountKind(int id, AccountKind accountKind)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != accountKind.AccountKindId)
            {
                return BadRequest();
            }

            _accountKindApp.Update(accountKind);


            if (!AccountKindExists(id))
            {
                return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/AccountKinds
        [ResponseType(typeof(AccountKind))]
        public IHttpActionResult PostAccountKind(AccountKind accountKind)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _accountKindApp.Add(accountKind);

            return CreatedAtRoute("DefaultApi", new { id = accountKind.AccountKindId }, accountKind);
        }

        // DELETE: api/AccountKinds/5
        [ResponseType(typeof(AccountKind))]
        public IHttpActionResult DeleteAccountKind(int id)
        {
            AccountKind accountKind = _accountKindApp.GetById(id);
            if (accountKind == null)
            {
                return NotFound();
            }

            _accountKindApp.Remove(accountKind);

            return Ok(accountKind);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _accountKindApp.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AccountKindExists(int id)
        {
            return _accountKindApp.GetById(id) != null;
        }
    }
}