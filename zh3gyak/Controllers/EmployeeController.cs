using Microsoft.AspNetCore.Mvc;
using zh3gyak.ProjectModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zh3gyak.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        ProjectManagementContext context = new();
        // GET: api/<EmployeeController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(context.Employees.ToList()); 
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var kiv = (from x in context.Employees
                      where id == x.EmployeeId
                      select x).FirstOrDefault();

            if (kiv == null)
            {
                return NotFound("Ninc ilyen id");
            }
            return Ok(kiv);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            context.Employees.Add(employee);    
            context.SaveChanges();  
            return Ok("Siker");

        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Employee ujEmployeee)
        {
            var modosit = (from x in context.Employees
                       where id == x.EmployeeId
                       select x).FirstOrDefault();
            if (modosit == null)
            {
                return NotFound("Nincs ilyen id");
            }
            modosit.Name = ujEmployeee.Name;
            modosit.Position = ujEmployeee.Position;
            modosit.Email = ujEmployeee.Email;
            modosit.Phone = ujEmployeee.Phone;
            
            context.SaveChanges();
            return Ok("Sikeres");
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var torol = (from x in context.Employees
                       where id == x.EmployeeId
                       select x).FirstOrDefault();
            context.Employees.Remove(torol);
            context.SaveChanges();
            return Ok("Sikeres torles");

        }
    }
}
