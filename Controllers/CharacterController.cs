using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dotnet.Models;
using Dotnet.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet.Controllers
{
    // pozwala nam na łączenie z Api ?
    [ApiController]
    // Daje nam routa na Character (poniewa to co w [] jest odcinane z klasy kontrolera)
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {

        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;

        }

        //by móc uywać Swaggera potrzebujemy HttpGet
        [HttpGet]
        // Route po Character/ w tym wyhpadku wszystkiePostacie  - dotyczy tylko tego ActionResulta który jest bezpośrednio po nim
        [Route("wszystkiePostacie")]
        public async Task<ActionResult<List<Character>>> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]

        // id daje nam opcje szukania po tych Ajdikach które mamy w postaciach
        public async Task<ActionResult<Character>> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }


        [HttpPost]

        public async Task<ActionResult<List<Character>>> AddCharacter(Character newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }
    }
}