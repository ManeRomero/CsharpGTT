namespace myVideoGamesApi.Models
{
    public class VideoGame
    {
        public short Id { get; set; }
        public string Title { get; set; }
        public int releaseYear {get; set;}
        public int minimumAge {get; set;}
        public string company {get; set;}
        public bool IsComplete { get; set; }
    }
}