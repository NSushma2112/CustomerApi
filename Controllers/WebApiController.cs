using CustomerApi.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerApi.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class WebApiController : ControllerBase
    {
        // GET: api/<WebApiController>
        [HttpGet]
        public string Get()
        {
            DBHandle db = new DBHandle();
            // List <Customer>listP= db.getRecords();
            //return JsonConvert.SerializeObject(listP);
            // return new string[] { "value1", "value2" };
            return db.getAllRecords();
        }
       

        // POST api/<WebApiController>
        /*[HttpPost]
        public void Post([FromBody] string value)
        {
        }*/
        [HttpPost]
        [Route("register")]
        public void Post(Customer c)
        {
            DBHandle db = new DBHandle();
            db.addCustomer(c);
            return;
        }

        // PUT api/<WebApiController>/5
        [HttpPut]
        public void Put(Customer c)
        {
            DBHandle db = new DBHandle();
            db.updatecustomer(c);
            return;
        }
        // DELETE api/<WebApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DBHandle db = new DBHandle();
            db.DeleteCustomer(id);
            return;
        }
        [Route("getrecord")]
        public Customer Get(int Customer_Id)
        {
            DBHandle db = new DBHandle();
            Customer cust = db.getCustomer(Customer_Id);
            return cust;
        }



    }
}
