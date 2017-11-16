using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SatelliteServer.Models;

namespace SatelliteServer.Controllers
{
    public class GroupsController : ApiController
    {
        private SatelliteEntities _context;

        public GroupsController()
        {
            _context = new SatelliteEntities();
        }



        // GET api/<controller>
        public IEnumerable<Group> Get()
        {
            return _context.Groups;
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            var group = _context.Groups.SingleOrDefault(g => g.GroupID == id);
            if (group == null)
            {
                return NotFound();
            }
            return Ok(group);
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]Group value)
        {
            _context.Groups.Add(value);
            _context.SaveChanges();
            return Ok(value.GroupID);
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]Group value)
        {
            var group = _context.Groups.SingleOrDefault(g => g.GroupID == id);
            if (group == null)
            {
                return NotFound();
            }
            group.Name = value.Name;
            group.ADName = value.ADName;
            _context.SaveChanges();
            return Ok();
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            var group = _context.Groups.SingleOrDefault(g => g.GroupID == id);
            if (group == null)
            {
                return NotFound();
            }
            _context.Groups.Remove(group);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}