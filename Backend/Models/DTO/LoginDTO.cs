using System;

namespace SIGRH.Models.DTO;

public class LoginDTO
{
    public int IdUsuario { get; set; }

    public string Cedula { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public string? PasswordEncrypted { get; set; }
}
