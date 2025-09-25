using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIGRH.Models.DTO.Request;
using SIGRH.Services;
using SIGRH.Utils.Jwt;

namespace SIGRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;

        private readonly JwtTokenServiceUtil _jwt;

        private readonly AuthService _authService;

        public AuthController(ILogger<AuthController> logger, JwtTokenServiceUtil jwt, AuthService authService)
        {
            _logger = logger;
            _jwt = jwt;
            _authService = authService;
        }

        [HttpGet("ObtenerRegistro")]
        public IActionResult Registro() => Ok("Cualquiera puede ver esto ✅");

        [HttpGet("ContraseniaNueva")]
        public IActionResult Publico() => Ok("Cualquiera puede ver esto ✅");

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] UserLoginRequest request)
        {
            try
            {
                var respuesta = await _authService.Login(request);

                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("RecuperarContrasenia")]
        public IActionResult RecoverPassword() => Ok("Cualquiera puede ver esto ✅");

        [HttpPost("EnviarEnlaceRegistro")]
        public IActionResult EnviarEnlaceRegistro() => Ok("Cualquiera puede ver esto ✅");

        [HttpPost("RegistroUsuario")]
        public IActionResult RegostroUsuario() => Ok("Cualquiera puede ver esto ✅");

        [HttpPost("ValidarToken")]
        public IActionResult ValidarToken() => Ok("Cualquiera puede ver esto ✅");
    }
}


/** * 
    var items = new List<SelectListItem>();    
    
    var storedProdecureName = "parh_ConsultarColaborador_Rol";
    
    var values = new {IdPersonal = idPersonal, IdRol = idrol, IdUnidad = idunidad, IdUnidadNivel = idunidad_nivel };
    
    var results = _connection.Query(storedProdecureName, values, commandType: CommandType.StoredProcedure).ToList();
    
    results.ForEach(r =>{
         items.Add(new SelectListItem
            {
                Value = r.IdPersonal.ToString(),
                Text = r.Nombre
            });
    });
 */

/** * 
   var storedProdecureName = "parh_ConsultarColaborador_Rol";
   
   var parameters = new
   {
       IdPersonal = idPersonal,
       IdRol = idrol,
       IdUnidad = idunidad,
       IdUnidadNivel = idunidad_nivel
   };
   
var items = connection.Query<SelectListItem>(
    storedProcedureName,
    parameters,
    commandType: CommandType.StoredProcedure
).ToList();
*/

