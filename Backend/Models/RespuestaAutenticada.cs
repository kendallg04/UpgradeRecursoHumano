using System;
using SIGRH.Models.DTO.Request;

namespace SIGRH.Models;

public class RespuestaAutenticada
{
    public UserLoginRequest Usuario { get; set; } = new UserLoginRequest();
    public string Token { get; set; } = string.Empty;
    public string RefreshToken { get; set; } = string.Empty;
}
