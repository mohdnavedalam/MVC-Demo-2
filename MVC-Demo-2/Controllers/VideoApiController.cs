using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using MVC_Demo_2.Models;

namespace MVC_Demo_2.Controllers
{
    public class VideoApiController : ApiController
    {
        VideoDb _db = new VideoDb();

        // GET: api/VideoApi
        public IEnumerable<Video> Get()
        {
            return _db.Videos;
        }

        // GET: api/VideoApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/VideoApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/VideoApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/VideoApi/5
        public void Delete(int id)
        {
        }
    }
}
