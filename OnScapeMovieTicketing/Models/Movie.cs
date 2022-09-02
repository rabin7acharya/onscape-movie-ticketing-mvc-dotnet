using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnScapeMovieTicketing.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
        public DateTime ShowStartDate { get; set; }
        public DateTime ShowEndDate { get; set; }
        public int Duration { get; set; }
        public string Synopsis { get; set; }
        public string Casts { get; set; }
        public string Director { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<Genre> Genres { get; set; }
        public Movie()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

    }
}
