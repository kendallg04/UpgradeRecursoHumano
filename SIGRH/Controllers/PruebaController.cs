using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIGRH.Utils.Jwt;

namespace SIGRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruebaController : ControllerBase
    {
        private readonly ILogger<PruebaController> _logger;

        private readonly JwtTokenServiceUtil _jwt;

        public PruebaController(ILogger<PruebaController> logger, JwtTokenServiceUtil jwt)
        {
            _logger = logger;
            _jwt = jwt;
        }

        [HttpGet("GetPrueba")]
        public async Task<IActionResult> PruebaASync()
        {
            try
            {
                await Task.Delay(500);
                return Ok("Hola");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("publico")]
        public IActionResult Publico() => Ok("Cualquiera puede ver esto ✅");

        [Authorize]
        [HttpGet("privado")]
        public IActionResult Privado() => Ok("Solo usuarios con JWT válido 🔑");

        [HttpGet("admin")]
        [Authorize(Roles = "Admin")]
        public IActionResult SoloAdmin() => Ok("Solo Admin tiene acceso 👑");

        [HttpPost("login")]
        public IActionResult Login([FromQuery] string requestUsername, string requestPassword)
        {
            // ⚠️ Aquí deberías validar el usuario contra tu base de datos
            if (requestUsername == "admin" && requestPassword == "123")
            {
                List<string> rol = new[] { "Admin", "Cont" }.ToList();
                var token = _jwt.GenerateToken(requestUsername, rol);
                return Ok(new { token });
            }

            return Unauthorized();
        }
    }
}
