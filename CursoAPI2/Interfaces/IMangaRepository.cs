using CursoAPI2.Models;

namespace CursoAPI2.Interfaces
{
    public interface IMangaRepository
    {
        public bool Save();

        public List<Manga> ListAll();
    }
}
