using AutoMapper;
using SIGRH.Data;
using SIGRH.Data.Repositories;
using SIGRH.Infraestructures.Interfaces;
using SIGRH.Models.DTO;
using SIGRH.Models.DTO.Response;
using SIGRH.Utils.Captcha;
using SIGRH.Utils.Jwt;

namespace SIGRH.Services;

public class AuthService
{
    private readonly JwtTokenServiceUtil _jwt;

    private readonly IUsuario _usuarioRepository;

    private readonly IUsuarioAccionExclusiva _usuarioExcl;

    private readonly IMapper _mapper;

    private readonly CaptChaUtil _captchaUtil;

    public AuthService(JwtTokenServiceUtil jwt, IUsuario usuarioRepository, IMapper mapper, IUsuarioAccionExclusiva usuarioExclusivoService, CaptChaUtil captchaUtil)
    {
        _jwt = jwt;
        _usuarioRepository = usuarioRepository;
        _mapper = mapper;
        _usuarioExcl = usuarioExclusivoService;
        _captchaUtil = captchaUtil;
    }

    public async Task<LoginResponse> LoginAsync(LoginDTO request)
    {
        request.PasswordEncrypted = (string)BibliotecaCore.BibliotecaCore.Encriptar(request.Password);

        var user = await _usuarioExcl.ObtenerUsuarioAsync(request);

        if (user is null)
            throw new ArgumentException("No se encontro el usuario");

        request.IdUsuario = user.usuario_id;

        var roles = await _usuarioExcl.ObtenerRolUsuarioAsync(request);

        if (roles is null)
            throw new ArgumentException("No se encontro los Roles");

        var rolesp = _mapper.Map<List<string>>(roles);

        var tokenDto = _jwt.GenerateToken(request.Cedula, rolesp, user.usuario_id);

        var tokenResponse = _mapper.Map<TokenResponse>(tokenDto);
        var userResponse = _mapper.Map<UserResponse>(user);

        var loginResponse = new LoginResponse
        {
            InfoToken = tokenResponse,
            Usuario = userResponse
        };

        return loginResponse;
    }

    public async Task RecuperarContrasenia(RecuperarPasswordDTO request)
    {
        var result = await _captchaUtil.ValidarCaptchaASync(request.Token);

        if (!result)
            throw new ArgumentException("Captcha inválido");


    }

    public async Task RegistroAsync(UserRegistroDTO request, string nombrePagina)
    {
        await _usuarioRepository.CrearUsuarioAsync(request, nombrePagina);
    }
}
