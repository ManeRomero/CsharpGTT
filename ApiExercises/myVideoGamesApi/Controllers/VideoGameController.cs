using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myVideoGamesApi.Models;
using myVideoGamesApi.utils;

namespace myVideoGamesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase {

        public VideoGameController() {
            Console.Write("CONSOLE DE TODA LA VIDA \n\n\n\n\n\nFIN####");
        }
        private Store store = Store.Instance;

        [HttpGet]
        public List<VideoGame> GetVideoGames() {
            return this.store.list;
        }

        [HttpGet("{id}")]
        public VideoGame VideoGameByID(string id) {
            return this.store.list.Find(game => game.id == id);
        }

        [HttpGet("search/{searchTerm}")]
        public List<VideoGame> SearchVideoGame(string searchTerm) {
            foreach (VideoGame game in this.store.list) {
                if (game.title.ToLower().Contains(searchTerm.ToLower())) {
                    this.store.searchList.Add(game);
                }
            }
            return this.store.searchList;
        }

        [HttpPost]
        public VideoGame PostVideoGame(VideoGame gameBody) {
            gameBody.id = generateID(this.store.list.Count);
            this.store.list.Add(gameBody);
            return gameBody;
        }

        [HttpPatch("{id}")]
        public VideoGame PatchVideoGame(string id, VideoGame gameBody) {
            VideoGame gameToPatch = new VideoGame();
            int index = this.store.list.FindIndex(game => game.id == id);

            if (gameToPatch != null) {

                gameToPatch.title = gameBody.title;
                gameToPatch.releaseYear = gameBody.releaseYear;
                gameToPatch.recommendedAge = gameBody.recommendedAge;
                gameToPatch.company = gameBody.company;
                gameToPatch.isEvaluated = gameBody.isEvaluated;
                gameToPatch.rating = gameBody.rating;
                gameToPatch.description = gameBody.description;
                gameToPatch.characters = gameBody.characters;

                this.store.list[index] = gameToPatch;

            } else {
                gameToPatch.error = "ERROR!! DATOS NO INSERTADOS";
            }
            return gameToPatch;
        }

        [HttpDelete("{id}")]
        public string borrarElemento(string id){
            int index = this.store.list.FindIndex(game => game.id == id);
            this.store.list.RemoveAt(index);

            return "ELEMENTO ELIMINADO DE LA TABLA";
        }

        private string generateID(int id) {
            Random randomizer = new Random();
            string possible = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int codeLength = 6;
            string result = id + "-";

            for (int i = 0; i < codeLength; i++)
            {
                int randomPosition = randomizer.Next(0, possible.Length);
                result += possible[randomPosition];
            }

            return result;
        }
    }
}