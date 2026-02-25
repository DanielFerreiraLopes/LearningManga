using CursoAPI2.DTO;
using CursoAPI2.Interfaces;
using CursoAPI2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CursoAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MangasController : ControllerBase
    {
        private readonly IMangaService _service;

        public MangasController(IMangaService service)
        {
            _service = service;
        }

        [HttpGet(Name = "GetAllMangas")]
        public IActionResult ListaMangas()
        {
            List<Manga> mangas = _service.GetMangas();
            return Ok(mangas);
        }

        [HttpPost(Name = "PostManga")]
        public IActionResult RegistraManga(MangaDTO mangaDTO)
        {
            bool resposta = _service.RegistraManga(mangaDTO);
            return Ok(resposta);
        }
    }
}
