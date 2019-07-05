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
        public Store GetTodoItems()
        {
            return this.store;
        }

        [HttpPost]
        public TodoItem PostTodo(TodoItem item)
        {
            this.store.todos.Add(item);
            return item;
        }
    }
}