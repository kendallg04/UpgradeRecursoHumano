using System;

namespace SIGRH.Models;

public class RegistroUsuario
{
    public int IdPersonal { get; set; }
    public string UserNameDB { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public int IdEstamento { get; set; }
}
