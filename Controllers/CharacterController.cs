using System.Collections.Generic;
using System.Linq;
using Dotnet.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet.Controllers
{
    // pozwala nam na łączenie z Api ?
    [ApiController]
    // Daje nam routa na Character (poniewa to co w [] jest odcinane z klasy kontrolera)
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character{Id = 1 , Name="Sam"}
        };

        //by móc uywać Swaggera potrzebujemy HttpGet
        [HttpGet]
        // Route po Character/ w tym wyhpadku wszystkiePostacie  - dotyczy tylko tego ActionResulta który jest bezpośrednio po nim
        [Route("wszystkiePostacie")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }

        [HttpGet("{id}")]

        // id daje nam opcje szukania po tych Ajdikach które mamy w postaciach
        public ActionResult<Character> GetSingle(int id)
        {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }
    }
}