using CursoAPI2.DTO;
using CursoAPI2.Models;

namespace CursoAPI2.Interfaces
{
    public interface IMangaService
    {
        public List<Manga> GetMangas();

        public bool RegistraManga(MangaDTO mangaDTO);
    }
}
