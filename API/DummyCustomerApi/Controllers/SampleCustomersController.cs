using Microsoft.AspNetCore.Mvc;
using DummyCustomerApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace DummyCustomerApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SampleCustomersController : ControllerBase
    {
        // In-memory store (static so it remains while app runs)
        private static readonly List<Customer> _customers = new List<Customer>
        {
            new Customer { CustomerId = 1, Name = "John D", Email = "john@test.com", Country = "USA" },
            new Customer { CustomerId = 2, Name = "Priya K", Email = "priya@test.com", Country = "India" },
            new Customer { CustomerId = 3, Name = "Li Wei", Email = "li.wei@test.com", Country = "China" }
        };

        // GET: api/samplecustomers
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            return Ok(_customers);
        }

        // GET: api/samplecustomers/2
        [HttpGet("{id:int}")]
        public ActionResult<Customer> GetById(int id)
        {
            var customer = _customers.FirstOrDefault(c => c.CustomerId == id);
            if (customer == null) return NotFound();
            return Ok(customer);
        }

        // POST: api/samplecustomers
        [HttpPost]
        public ActionResult<Customer> Create(Customer newCustomer)
        {
            if (newCustomer == null) return BadRequest();

            // generate next id
            var nextId = (_customers.Count == 0) ? 1 : _customers.Max(c => c.CustomerId) + 1;
            newCustomer.CustomerId = nextId;

            _customers.Add(newCustomer);

            // Return 201 Created with location header
            return CreatedAtAction(nameof(GetById), new { id = newCustomer.CustomerId }, newCustomer);
        }
    }
}
