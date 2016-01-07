using BuildingServiceLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BuildingServiceLayer.Controllers
{
    
    public class PersonController : ApiController
    {
        List<Person> People;
        public PersonController()
        {
            People = new List<Person>();
            People.AddRange(new Person[]
                {
                    new Person{ID=1,Name="Pradeep"},
                    new Person{ID=2,Name="Vishnu"},
                    new Person{ID=3,Name="jay"}
                });
        }
        // GET api/Person
        public IEnumerable<Person> Get()
        {
            return People;
        }

        // GET api/Person/5
        public Person Get(int id)
        {
            return People.First(x=>x.ID==id);
        }

        // POST api/Person
        public void Post([FromBody]string value)
        {
        }

        // PUT api/Person/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Person/5
        public void Delete(int id)
        {
        }
    }
}
