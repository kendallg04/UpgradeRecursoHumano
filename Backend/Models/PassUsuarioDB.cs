using System;

namespace SIGRH.Models;

public class PassUsuarioDB
{
    public string usuarioDB { get; set; } = string.Empty;

    public string cedula { get; set; } = string.Empty;

    public string NombreCompleto { get; set; } = string.Empty;

    public string password { get; set; } = string.Empty;

    public int superusuario { get; set; }

    public string Nombre1 { get; set; } = string.Empty;

    public string Apellido1 { get; set; } = string.Empty;

    public string NombreTratamiento { get; set; } = string.Empty;

    public int IdPersonaUnica { get; set; }

    public string CorreoElectronico { get; set; } = string.Empty;

    public byte[]? Foto { get; set; }

    public int usuario_id { get; set; }
}
