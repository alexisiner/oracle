using APIORACLE.Entities;
using APIORACLE.Intefaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIORACLE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IAlumnoRepository _repository;

        public WeatherForecastController(IAlumnoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var alumnos =  _repository.ObtenerAlumnos(2);
                return Ok(alumnos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }

        [HttpGet("GetAlumnos")]
        public async Task<IActionResult> GetAlumnos()
        {
            try
            {
                return Ok(_repository.ObtenerAlumnosfull());
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }
    }
}
