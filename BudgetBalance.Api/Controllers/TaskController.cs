using BudgetBalance.Domain;
using BudgetBalance.Api.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AppContext = BudgetBalance.Api.Data.AppContext;

namespace BudgetBalance.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly AppContext _context;
        private readonly ILogger<TaskController> _logger;

        public TaskController(ILogger<TaskController> logger, AppContext context)
        {
            _logger = logger;
            _context = context;
        }


        [HttpGet]
        [Route("/Task/")]
        public List<TaskModel> Get()
        {
            return _context.Tasks.ToList();
        }

        [HttpPost]
        [Route("/Task/Add")]
        public TaskModel Add(TaskModel task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
            return task;
        }

        [HttpDelete]
        [Route("/Task/{id}")]
        public int Remove(int id)
        {
            var task = _context.Tasks.First(c => c.Id == id);
            _context.Tasks.Remove(task);
            _context.SaveChanges();

            return task.Id;
        }
    }
}
