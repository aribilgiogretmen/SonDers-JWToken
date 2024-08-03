using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SonDers_JWToken.Business.Interfaces;
using SonDers_JWToken.Entities;

namespace SonDers_JWToken.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Car>>>GetCars()
        {
            return Ok(await _carService.GetCars());
        }
    }
}
