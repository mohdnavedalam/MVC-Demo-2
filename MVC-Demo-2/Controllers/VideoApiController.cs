using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MVC_Demo_2.Models;

namespace MVC_Demo_2.Controllers
{
    [RoutePrefix("courses")]
    [RequireHttpAttribute]
    public class VideoApiController : ApiController
    {
        private VideoDb db = new VideoDb();

        // GET: api/VideoApi
        public IQueryable<Video> GetVideos()
        {
            return db.Videos;
        }

        // Attribute Routing
        [Authorize]
        [Route("")]
        public IQueryable<Video> GetVideos2()
        {
            return db.Videos;
        }

        // GET: api/VideoApi/5
        [ResponseType(typeof(Video))]
        public IHttpActionResult GetVideo(int id)
        {
            Video video = db.Videos.Find(id);
            if (video == null)
            {
                return NotFound();
            }

            return Ok(video);
        }

        [Route("{courseID}")]       // [Route(~/api/apun/{courseID})] ---> to override the RoutePrefix
        public IHttpActionResult GetVideo2(int courseID)
        {
            Video video = db.Videos.Find(courseID);
            if (video == null)
            {
                return NotFound();
            }

            return Ok(video);
        }

        // PUT: api/VideoApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVideo(int id, Video video)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != video.ID)
            {
                return BadRequest();
            }

            db.Entry(video).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VideoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/VideoApi
        [ResponseType(typeof(Video))]
        public IHttpActionResult PostVideo(Video video)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Videos.Add(video);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = video.ID }, video);
        }

        // DELETE: api/VideoApi/5
        [ResponseType(typeof(Video))]
        public IHttpActionResult DeleteVideo(int id)
        {
            Video video = db.Videos.Find(id);
            if (video == null)
            {
                return NotFound();
            }

            db.Videos.Remove(video);
            db.SaveChanges();

            return Ok(video);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VideoExists(int id)
        {
            return db.Videos.Count(e => e.ID == id) > 0;
        }
    }
}