using Microsoft.AspNetCore.Mvc;
using zh3gyak.ProjectModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zh3gyak.Controllers
{
    [Route("api/project")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        ProjectManagementContext context = new();
        // GET: api/<ProjectController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(context.Projects.ToList());
        }

        // GET api/<ProjectController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var kiv = (from x in context.Projects
                       where id == x.ProjectId
                       select x).FirstOrDefault();

            if (kiv == null)
            {
                return NotFound("Ninc ilyen id");
            }
            return Ok(kiv);
        }

        // POST api/<ProjectController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProjectController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProjectController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
