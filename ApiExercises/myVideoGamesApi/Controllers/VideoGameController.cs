using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using TodoApi.utils;

namespace myVideoGamesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {
        public VideoGameController() {
            Console.Write("Vamos a crear el videojuego.");
        }
        private Store store = Store.Instance;
        
        [HttpGet]

        public  GetVideoGames()
        {
            return this.store.todos;

        }
        
    }
}