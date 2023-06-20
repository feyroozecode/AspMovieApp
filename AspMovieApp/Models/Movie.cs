namespace AspMovieApp.Models
{
    public class Movie
    {
        public int id  ;
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string PostUrl { get; set; }
    }
}
