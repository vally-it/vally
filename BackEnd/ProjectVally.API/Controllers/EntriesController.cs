using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using ProjectVally.Domain.Entities;
using ProjectVally.Application.Interface;
using ProjectVally.API.ViewModels;

namespace ProjectVally.API.Controllers
{
    public class EntriesController : ApiControllerBase<EntryViewModel, Entry>
    {
        private readonly IEntryAppService _entryApp;

        public EntriesController(IEntryAppService entryApp):base(entryApp)
        {
            this._entryApp = entryApp;
        }

        // GET: api/Entries
        public IEnumerable<EntryViewModel> GetEntries()
        {
            return GetAll();
        }

        // GET: api/Entries/5
        [ResponseType(typeof(EntryViewModel))]
        public IHttpActionResult GetEntry(int id)
        {
            var entry = GetViewModelById(id);
            if (entry == null)
            {
                return NotFound();
            }

            return Ok(entry);
        }

        // PUT: api/Entries/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEntry(int id, EntryViewModel entry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != entry.EntryId)
            {
                return BadRequest();
            }
            var entryDomain = GetEntityByViewModel(entry);
            _entryApp.Update(entryDomain);


            if (!EntityExists(id))
            {
                return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Entries
        [ResponseType(typeof(EntryViewModel))]
        public IHttpActionResult PostEntry(EntryViewModel entry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entryDomain = GetEntityByViewModel(entry);
            _entryApp.Add(entryDomain);

            return CreatedAtRoute("DefaultApi", new { id = entryDomain.EntryId }, entry);
        }

        // DELETE: api/Entries/5
        [ResponseType(typeof(EntryViewModel))]
        public IHttpActionResult DeleteEntry(int id)
        {
            Entry entry = _entryApp.GetById(id);
            if (entry == null)
            {
                return NotFound();
            }

            _entryApp.Remove(entry);

            var entryViewModel = GetViewModelByEntity(entry);

            return Ok(entryViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _entryApp.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}