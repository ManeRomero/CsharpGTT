using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using TodoApi.utils;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    { 
        public TodoController() {
            Console.Write("CONSOLE DE TODA LA VIDA \n-\n-\n-\n-\n-\nFIN####");
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

        
        [HttpGet("search/{search_word}")]
        public List<TodoItem> getTodoItembyWord(string search_word) {
            return this.store.todos.FindAll(todo => todo.Name.Contains(search_word));
        }

        [HttpGet("done")]
        public List<TodoItem> getTodoItemDone() {
            return this.store.todos.FindAll(todo => todo.IsComplete);
        }

        [HttpPatch("done/{id}")]
        public TodoItem patchTodoItem(long id) {
            TodoItem todo = this.store.todos.Find(todo => todo.Id == id);
            todo.IsComplete = true;
            return todo;
        }

        [HttpDelete("{id}")]
        public StatusCodeResult deleteTodoItem(long id) {
            // TodoItem todo = this.store.todos.Remove(todo => todo.Id == id);
            return StatusCode(202);
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