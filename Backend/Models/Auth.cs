using System;

namespace SIGRH.Models;

public class Auth
{
    public int Version { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public DateTime FechaEmitida { get; set; }
    public DateTime FechaExpiracion { get; set; }
    public bool EsPersistente { get; set; }
    public string UsuarioData { get; set; } = string.Empty;
    public string CookiePath { get; set; } = string.Empty;
}
