using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private List<TodoItem> todos = new List<TodoItem>();

        [HttpGet]
        public List <TodoItem> GetTodoItems()
        {
            return this.todos;
        }

        [HttpPost]

        public TodoItem PostTodo(TodoItem item)
        {
            this.todos.Add(item);
            return item;
        }
    }
}