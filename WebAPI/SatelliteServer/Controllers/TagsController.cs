using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SatelliteServer.Models;

namespace SatelliteServer.Controllers
{
    public class TagsController : ApiController
    {
        private SatelliteEntityDB _context;

        public TagsController()
        {
            _context = new SatelliteEntityDB();
        }



        // GET api/<controller>
        public IEnumerable<Tag> Get()
        {
            return _context.Tags;
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            var tag = _context.Tags.SingleOrDefault(t => t.TagID == id);
            if (tag == null)
            {
                return NotFound();
            }

            return Ok(tag);
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]Tag value)
        {
            _context.Tags.Add(value);
            _context.SaveChanges();
            return Ok(value.TagID);
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]Tag value)
        {
            var tag = _context.Tags.SingleOrDefault(t => t.TagID == id);
            if (tag == null)
            {
                return NotFound();
            }
            tag.Name = value.Name;
            _context.SaveChanges();
            return Ok();
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            var tag = _context.Tags.SingleOrDefault(t => t.TagID == id);
            if (tag == null)
            {
                return NotFound();
            }
            _context.Tags.Remove(tag);
            _context.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}