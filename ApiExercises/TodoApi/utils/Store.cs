using TodoApi.Models;
using System.Collections.Generic;

namespace TodoApi.utils
{
    public sealed class Store
    {
        private readonly static Store _instance = new Store();
        public List<TodoItem> todos = new List<TodoItem>();
        public Store()
        {
            
        }
        public static Store Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}