using Domain.Entities;
using Domain.Usecases.Dogs;
using Microsoft.AspNetCore.Mvc;

namespace Dogs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DogController : ControllerBase
    {
        public DogController(IGetDog getDog) => _getDog = getDog;

        readonly private IGetDog _getDog;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dog>>> GetAllDogs()
        {
            var result = await _getDog.GetAllDogs();

            if(result == null || result?.Count() == 0)
            {
                return NoContent();
            }

            return Ok(result);

        } 

    }
}
