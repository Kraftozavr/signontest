using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Text;
using System.IO;
using signontest.service.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
namespace signontest.service.Controllers
{
    public class MoviesController : ApiController
    {

        const string CLIENT_SECRET = "16CxZt1EvarF5j3FZhbaC69aArt7Obq2 ";
        // GET api/movies
        public HttpResponseMessage Get()
        {
            var auth_token = Request.Headers.GetValues("authenticationtoken").FirstOrDefault();
            if (auth_token == null)
            {
                return new HttpResponseMessage(HttpStatusCode.Unauthorized);
            }

            var d = new Dictionary<int, string>();
            return new HttpResponseMessage(HttpStatusCode.Unauthorized);

            try
            {
                var jwt = new JsonWebToken(auth_token, d);

            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.Unauthorized);
            }
            return Request.CreateResponse(HttpStatusCode.OK, new List<Movie> { 
             new Movie {Title="Star Wars", Director="Lucas"},
                    new Movie {Title="King Kong", Director="Jackson"},
                    new Movie {Title="Memento", Director="Nolan"}
            });
        }

        // GET api/movies/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/movies
        public void Post(string value)
        {
        }

        // PUT api/movies/5
        public void Put(int id, string value)
        {
        }

        // DELETE api/movies/5
        public void Delete(int id)
        {
        }
    }
}
