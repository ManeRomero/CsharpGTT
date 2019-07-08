namespace myVideoGamesApi.Models
{
    public class VideoGame
    {
        public string id { get; set; }
        public string title { get; set; }
        public int releaseYear { get; set; }
        public int recommendedAge { get; set; }
        public string company {get; set; }
        public bool isEvaluated { get; set; }
        public double rating { get; set; }
        public string description { get; set; }
        public string[] characters { get; set; }
        public string error { get; set;}
    }

    public class VideoGamePatch
    {
        public string title { get; set; }
        public int releaseYear { get; set; }
        public int recommendedAge { get; set; }
        public string company {get; set; }
        public bool isEvaluated { get; set; }
        public double rating { get; set; }
        public string description { get; set; }
        public string[] characters { get; set; }        
    }
}