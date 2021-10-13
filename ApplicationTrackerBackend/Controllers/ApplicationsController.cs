using ApplicationTrackerBackend.Models;
using ApplicationTrackerBackend.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace ApplicationTrackerBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationsController : ControllerBase
    {
        private ApplicationDbContext _context;
        public ApplicationsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: ApplicationsController
        [HttpGet]
        public IActionResult GetApplications()
        {
            var applications = _context.Applications;
            return Ok(applications);
        }

        // GET: ApplicationsController/Details/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)

        {
            var application = _context.Applications.FirstOrDefault(application => application.ApplicationsId == id);
            if (application == null)
            {
                return NotFound();
            }
            return Ok(application);
        }

        // POST api/<PostControlelr>
        // CREATE A POST
        [HttpPost]
        public IActionResult Post([FromBody] Applications value)
        {
            _context.Applications.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        // PUT api/<PostController>/{id}
        // PUT POST
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Applications value)
        {
            var application = _context.Applications.FirstOrDefault(application => application.ApplicationsId == id);
            application.ApplicationsId = value.ApplicationsId;
            _context.SaveChanges();
            return Ok(application);
        }

        // DELETE api/<PostController>/{id}
        // DELETE POST BY ID
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var post = _context.Applications.FirstOrDefault(post => post.ApplicationsId == id);
            _context.Remove(post);
            _context.SaveChanges();
            return Ok();
        }
    }


}
