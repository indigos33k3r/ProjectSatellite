using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using SatelliteServer.Models;

namespace SatelliteServer.Controllers
{
    public class NotificationsController : ApiController
    {
        private SatelliteEntities _context;

        public NotificationsController()
        {
            _context = new SatelliteEntities();
        }


        // GET api/values
        public IEnumerable<Notification> Get()
        {
            return _context.Notifications;
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            var notification = _context.Notifications.SingleOrDefault(n => n.NotificationID == id);
            if (notification == null)
            {
                return NotFound();
            }
            return Ok(notification);
        }

        // POST api/values
        public IHttpActionResult Post([FromBody]Notification value)
        {
            _context.Notifications.Add(value);
            _context.SaveChanges();
            return Ok(value.NotificationID);
        }

        // PUT api/values/5
        public IHttpActionResult Put(int id, [FromBody]Notification value)
        {
            var notificationToUpdate = _context.Notifications.SingleOrDefault(n => n.NotificationID == id);
            if (notificationToUpdate == null)
            {
                return NotFound();
            }

            notificationToUpdate.Title = value.Title;
            notificationToUpdate.Body = value.Body;
            notificationToUpdate.Start = value.Start;
            notificationToUpdate.Finish = value.Finish;
            notificationToUpdate.Groups.Clear();
            foreach (var group in value.Groups)
            {
                notificationToUpdate.Groups.Add(group);
            }
            notificationToUpdate.Tags.Clear();
            foreach (var tag in value.Tags)
            {
                notificationToUpdate.Tags.Add(tag);
            }
            notificationToUpdate.Links.Clear();
            foreach (var link in value.Links)
            {
                notificationToUpdate.Links.Add(link);
            }
            _context.SaveChanges();
            return Ok();
        }

        // DELETE api/values/5
        public IHttpActionResult Delete(int id)
        {
            var notificationToDelete = _context.Notifications.SingleOrDefault(n => n.NotificationID == id);
            if (notificationToDelete == null)
            {
                return NotFound();
            }
            _context.Notifications.Remove(notificationToDelete);
            _context.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
