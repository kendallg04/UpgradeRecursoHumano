using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIGRH.Models;
using SIGRH.Models.DTO;
using SIGRH.Models.DTO.Request;
using SIGRH.Models.DTO.Response;
using SIGRH.Services;
using SIGRH.Utils.Jwt;

namespace SIGRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;

        private readonly AuthService _authService;

        private readonly IMapper _mapper;

        public AuthController(ILogger<AuthController> logger, AuthService authService, IMapper mapper)
        {
            _logger = logger;
            _authService = authService;
            _mapper = mapper;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LoginAsync([FromBody] UserLoginRequest request)
        {
            try
            {
                var mapRequest = _mapper.Map<LoginDTO>(request);

                var respuesta = await _authService.LoginAsync(mapRequest);

                var response = new GeneralResponse<LoginResponse>(respuesta);

                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }

        // [HttpPost("Registro")]
        // public async Task<IActionResult> RegistroAsync([FromBody] UserRegistroRequest request, [FromHeader] string nombrePagina)
        // {
        //     try
        //     {
        //         var mapRequest = _mapper.Map<UserRegistroDTO>(request);

        //         await _authService.RegistroAsync(mapRequest, nombrePagina);

        //         return Ok();
        //     }
        //     catch (Exception ex)
        //     {
        //         _logger.LogError(ex, ex.Message);
        //         return BadRequest(ex.Message);
        //     }
        // }

        [HttpPost("RecuperarContrasenia")]
        public async Task<IActionResult> RecuperarContrasenia(RecuperarContraseniaRequest request)
        {
            try
            {
                var mapRequest = _mapper.Map<RecuperarPasswordDTO>(request);

                await _authService.RecuperarContrasenia(mapRequest);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}