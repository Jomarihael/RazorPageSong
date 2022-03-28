using System.ComponentModel.DataAnnotations;

namespace RazorPageSong.Models
{
    public class Hael
    {
        public int ID { get; set; }
        public string Title { get; set; } = String.Empty;
        [DataType(DataType.Date)]

        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = string.Empty;
        public string Composedby { get; set; } = string.Empty;
        public string SongBy { get; set; } =string.Empty;
        public decimal Price { get; set; }  
    }
}
