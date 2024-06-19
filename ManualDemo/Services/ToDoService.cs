using ManualDemo.Models;
using Microsoft.EntityFrameworkCore;
using SuperComUserTasks_.Models;

namespace ManualDemo.Services
{
    public class ToDoService
    {
        private readonly AppDbContext _context;

        public ToDoService(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<ToDo>> GetToDosAsync()
        {
            return await _context.Todos.ToListAsync();
        }
    }
}
