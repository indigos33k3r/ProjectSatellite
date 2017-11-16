using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SatelliteServer.Models;

namespace SatelliteServer.Controllers
{
    public class IncidentsController : ApiController
    {
        private SatelliteEntities _context;

        public IncidentsController()
        {
            _context = new SatelliteEntities();
        }


        // GET api/<controller>
        public IEnumerable<Incident> Get()
        {
            return _context.Incidents;
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            var incident = _context.Incidents.SingleOrDefault(i => i.IncidentID == id);
            if (incident == null)
            {
                return NotFound();
            }
            return Ok(incident);
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]Incident value)
        {
            _context.Incidents.Add(value);
            _context.SaveChanges();
            return Ok(value.IncidentID);
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]Incident value)
        {
            var incidentToUpdate = _context.Incidents.SingleOrDefault(i => i.IncidentID == id);
            if (incidentToUpdate == null)
            {
                return NotFound();
            }

            incidentToUpdate.Title = value.Title;
            incidentToUpdate.Body = value.Body;
            incidentToUpdate.ResolvedBy = value.ResolvedBy;
            incidentToUpdate.ResolvedDate = value.ResolvedDate;

            incidentToUpdate.Groups.Clear();
            foreach (var group in value.Groups)
            {
                incidentToUpdate.Groups.Add(group);
            }
            incidentToUpdate.Tags.Clear();
            foreach (var tag in value.Tags)
            {
                incidentToUpdate.Tags.Add(tag);
            }
            incidentToUpdate.Links.Clear();
            foreach (var link in value.Links)
            {
                incidentToUpdate.Links.Add(link);
            }

            _context.SaveChanges();
            return Ok();
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            var incidentToDelete = _context.Incidents.SingleOrDefault(i => i.IncidentID == id);
            if (incidentToDelete == null)
            {
                return NotFound();
            }
            _context.Incidents.Remove(incidentToDelete);
            _context.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}