using System;
using SIGRH.Models.DTO.Request;
using SIGRH.Utils;
using SIGRH.Utils.Jwt;

namespace SIGRH.Services;

public class AuthService
{
    private readonly UserUtil _userUtil;

    private readonly JwtTokenServiceUtil _jwt;

    public AuthService(UserUtil userUtil, JwtTokenServiceUtil jwt)
    {
        _userUtil = userUtil;
        _jwt = jwt;
    }

    public async Task<string> Login(UserLoginRequest request)
    {
        await Task.Delay(500);

        // string passObject = request.Password;
        // string nombre_completo = "";
        // string username = "";
        // List<string> roles = new List<string>();
        // Modificar
        // request.PasswordEncrypted = Biblioteca.Biblioteca.Encriptar(request.Password);
        // var blnValidaUsuario = _userUtil.ValidarUsuario(request);

        // if (!blnValidaUsuario)
        //     throw new Exception("Usuario o contraseña incorrecta");

        // string[] nombreCompletoDivido = nombre_completo.Split(' ');
        // string nombre = nombreCompletoDivido[0] + "" + nombreCompletoDivido[2];
        // Dictionary<int, string> keyValuePairs = _userUtil.Roles(username);
        // if (keyValuePairs is null)
        // {
        //     throw new Exception("No se han asignado roles al usuario");
        // }
        // foreach (var item in keyValuePairs)
        // {
        //     roles.Add(item.Value);
        // }
        var rolesP = new List<string>
        {
            "Admin"
        };
        var token = _jwt.GenerateToken(request.UserName, rolesP);

        return token;
    }
}
