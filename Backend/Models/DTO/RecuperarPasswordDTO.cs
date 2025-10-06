using System;

namespace SIGRH.Models.DTO;

public class RecuperarPasswordDTO
{
    public string Cedula { get; set; } = string.Empty;

    public string Token { get; set; } = string.Empty;
}
