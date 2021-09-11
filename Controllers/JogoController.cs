using CriandoWebApi.Model;
using CriandoWebApi.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace CriandoWebApi.Controller
{
    [ApiController]
    [Route("/api/[controller]")]
    public class JogoController : ControllerBase
    {
        private readonly IJogoRepository _jogoRepository;
        public JogoController(IJogoRepository jogoRepository)
        {
            _jogoRepository = jogoRepository;
        }
        [HttpGet]
        [Produces(typeof(Jogo))]
        public IActionResult Get()
        {
            var jogos = _jogoRepository.GetAll();
            if (jogos.Count() == 0)
                return NoContent();
            return Ok(jogos);
        }
    }
}