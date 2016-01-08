using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_CarDetails.Models;

namespace WebApi_CarDetails.Controllers
{
    
    public class CarDetailsController : ApiController
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<CarsStock> GetAllCarDetails()
        {
            CarsStock ST = new CarsStock();
            CarsStock ST1 = new CarsStock();
            List<CarsStock> li = new List<CarsStock>();
            ST.CarName = "Maruti Waganor";
            ST.CarPrice = "4 lakhs";
            ST.CarModel = "VXI";
            ST.CarColor = "Brown";
            ST.CarName = "Maruti Swift";
            ST.CarPrice = "5 lakhs";
            ST.CarModel = "VXI";
            ST.CarColor = "Red";
            li.Add(ST);
            li.Add(ST1);
            return li;
        }

        // GET api/values/5
        
        public IEnumerable<CarsStock> Get(int id)
        {
            CarsStock ST = new CarsStock();
            CarsStock ST1 = new CarsStock();
            List<CarsStock> li = new List<CarsStock>();
            if (id == 1)
            {
                ST.CarName = "Maruti Waganor";
                ST.CarPrice = "4 lakhs";
                ST.CarModel = "VXI";
                ST.CarColor = "Brown";
                li.Add(ST);
            }
            else
            {
                ST.CarName = "Maruti Swift";
                ST.CarPrice = "5 lakhs";
                ST.CarModel = "VXI";
                ST.CarColor = "Red";
                li.Add(ST1);
            }
            
            
            return li;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]CarsStock cs)
        {
        }

        // PUT api/values/5
        [HttpPut]
        public void Put(int id)
        {
        }

        // DELETE api/values/5
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
