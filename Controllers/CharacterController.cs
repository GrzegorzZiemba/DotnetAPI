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
        private static Character paladin = new Character();

        //by móc uywać Swaggera potrzebujemy HttpGet
        [HttpGet]
        public ActionResult<Character> Get()
        {
            return Ok(paladin);
        }
    }
}