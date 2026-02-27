using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Threading.Tasks;
using TaskEmployeeAPI.DTO;
using TaskEmployeeAPI.Modals;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskEmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<IActionResult> GetEmployee()
        {
            var result = await _context.Employees.Where(e=>e.Role!="admin").ToListAsync();
            return Ok(result);
        }

        // GET api/<EmployeeController>/5
        [HttpGet("exist/{id}")]
        public async Task<IActionResult> isEmployee(string id)
        {
            bool user=await _context.Employees.AnyAsync(u => u.EmployeeId == id);
            return Ok(user);
        }

        // POST api/<EmployeeController>
        [HttpPost("add-user")]
        public async Task<IActionResult> AddUser([FromBody] Employee user)
        {
            _context.Employees.Add(user);
            await _context.SaveChangesAsync();
            return Ok(user);
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto user)
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(u => u.EmployeeId == user.EmployeeId && u.Password == user.Password && u.Role==user.Role);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("toggle-status")]
        public async Task<IActionResult> ToggleStatus(string employee_id, string status)
        {
            var user = await _context.Tasks.FirstOrDefaultAsync(u => u.EmployeeId == employee_id);
            user.TaskStatus = status.Equals("Completed", StringComparison.OrdinalIgnoreCase);
            await _context.SaveChangesAsync();
            return Ok(user);
            
        }
        [HttpPut("update-password")]
        public async Task<IActionResult> UpdatePassword(string employee_id, string newPassword)
        {
            var user = await _context.Employees.FirstOrDefaultAsync(u => u.EmployeeId == employee_id);
            if (user == null)
            {
                return NotFound();
            }
            user.Password = newPassword;
            await _context.SaveChangesAsync();
            return Ok(user);

        }

        // DELETE api/<EmployeeController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
