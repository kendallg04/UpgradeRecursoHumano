using System;

namespace SIGRH.Models.DTO;

public class UserRegistroDTO
{
    public int IdPersonal { get; set; }

    public string Cedula { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public int IdEstamento { get; set; }
}
