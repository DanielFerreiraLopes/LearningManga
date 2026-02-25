namespace CursoAPI2.Models
{
    public class Manga
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Publisher { get; set; }

        public string Gender { get; set; }

        public string? Cover { get; set; }

        public DateTime Realease_Date { get; set; }
    }
}
