using myVideoGamesApi.Models;
using System.Collections.Generic;
using System;

namespace myVideoGamesApi.utils
{
    public sealed class Store
    {
        private readonly static Store _instance = new Store();
        public List<VideoGame> list = new List<VideoGame>();
        public List<VideoGame> searchList = new List<VideoGame>();

        public Store()
        {
            System.Console.WriteLine("ESTOFUNCIONA \n\n\n\n\n YEAH!");
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