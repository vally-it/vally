using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using ProjectVally.Domain.Entities;
using ProjectVally.Application.Interface;
using ProjectVally.API.ViewModels;

namespace ProjectVally.API.Controllers
{
    public class EntryKindsController : ApiControllerBase<EntryKindViewModel, EntryKind>
    {
        private readonly IEntryKindAppService _entryKindApp;

        public EntryKindsController(IEntryKindAppService entryKindApp):base(entryKindApp)
        {
            this._entryKindApp = entryKindApp;
        }

        // GET: api/EntryKinds
        public IEnumerable<EntryKindViewModel> GetEntryKinds()
        {
            return GetAll();
        }

        // GET: api/EntryKinds/5
        [ResponseType(typeof(EntryKindViewModel))]
        public IHttpActionResult GetEntryKind(int id)
        {
            var entryKind = GetViewModelById(id);
            if (entryKind == null)
            {
                return NotFound();
            }

            return Ok(entryKind);
        }

        // PUT: api/EntryKinds/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEntryKind(int id, EntryKindViewModel entryKind)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != entryKind.EntryKindId)
            {
                return BadRequest();
            }
            var entryKindDomain = GetEntityByViewModel(entryKind);
            _entryKindApp.Update(entryKindDomain);


            if (!EntityExists(id))
            {
                return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/EntryKinds
        [ResponseType(typeof(EntryKindViewModel))]
        public IHttpActionResult PostEntryKind(EntryKindViewModel entryKind)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entryKindDomain = GetEntityByViewModel(entryKind);
            _entryKindApp.Add(entryKindDomain);

            return CreatedAtRoute("DefaultApi", new { id = entryKindDomain.EntryKindId }, entryKind);
        }

        // DELETE: api/EntryKinds/5
        [ResponseType(typeof(EntryKindViewModel))]
        public IHttpActionResult DeleteEntryKind(int id)
        {
            EntryKind entryKind = _entryKindApp.GetById(id);
            if (entryKind == null)
            {
                return NotFound();
            }

            _entryKindApp.Remove(entryKind);

            var entryKindViewModel = GetViewModelByEntity(entryKind);

            return Ok(entryKindViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _entryKindApp.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}