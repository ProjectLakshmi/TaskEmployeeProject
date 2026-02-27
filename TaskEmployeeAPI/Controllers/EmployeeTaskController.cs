using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskEmployeeAPI.DTO;
using TaskEmployeeAPI.Modals;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskEmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeTaskController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public EmployeeTaskController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<EmployeeTaskController>
        [HttpGet]
        public async Task<IActionResult> GetTasks(string employeeId)
        {
            var user = await _context.Tasks.Where(t => t.EmployeeId == employeeId).ToListAsync();
            return Ok(user);
        }

        // GET api/<EmployeeTaskController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTaskId(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if(task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }

        // POST api/<EmployeeTaskController>
        [HttpPost]
        public async Task<IActionResult> AddTask([FromBody] Modals.Task task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
            return Ok(task);    
        }

        // PUT api/<EmployeeTaskController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> editTask(int id, [FromBody] UpdatedTaskDto user)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null)
            {
                return NotFound();
            }
            task.TaskDiscrption = user.TaskDiscrption;
            task.TaskStatus = user.TaskStatus;
            await _context.SaveChangesAsync();
            return Ok(task);
        }
       // [HttpGet("toggle-status")]
       // public async Task<IActionResult> ToggleStatus(string employeeId,string status)
       // {
       //     var query = _context.Tasks
       //.Where(t => t.EmployeeId == employeeId);

       //     if (!status.Equals("All", StringComparison.OrdinalIgnoreCase))
       //     {
       //         bool filterStatus = status.Equals("Completed",
       //             StringComparison.OrdinalIgnoreCase);

       //         query = query.Where(t => t.TaskStatus == filterStatus);
       //     }

       //     var tasks = await query.ToListAsync();

       //     if (!tasks.Any())
       //         return NotFound("No tasks found");

       //     return Ok(tasks);
       // }
        // DELETE api/<EmployeeTaskController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null)
            {
                return NotFound();
            }
            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();
            return Ok("Task-Deleted");
        }
    }
}
