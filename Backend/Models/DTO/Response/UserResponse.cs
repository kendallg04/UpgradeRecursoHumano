using System;

namespace SIGRH.Models.DTO;

public class UserResponse
{
    public string Nombre { get; set; } = string.Empty;

    public string Apellido { get; set; } = string.Empty;

    public string Correo { get; set; } = string.Empty;
}
