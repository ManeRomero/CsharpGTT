using TodoApi.Models;
using System.Collections.Generic;

namespace myVideoGamesApi.Controllers
{
    public sealed class Store
    {
        private readonly static Store _instance = new Store();
        public List<VideoGame> todos = new List<VideoGame>();
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