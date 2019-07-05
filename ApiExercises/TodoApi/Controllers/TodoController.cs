using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using TodoApi.utils;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    { 
        public TodoController() {
            Console.Write("CONSOLE DE TODA LA VIDA \n\n\n\n\n\nFIN####");
        }
        private Store store = Store.Instance;

        [HttpGet]
        public List<TodoItem> GetTodoItems()
        {
            return this.store.todos;
        }

        [HttpGet("{id}")]
        public TodoItem getTodoItem(long id) {
            return this.store.todos.Find(todo => todo.Id == id);
        }

        [HttpPost]
        public TodoItem PostTodo(TodoItem item)
        {
            item.Id = this.store.todos.Count;
            this.store.todos.Add(item);
            return item;
        }
    }
}