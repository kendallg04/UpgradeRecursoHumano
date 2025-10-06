using System;

namespace SIGRH.Models.DTO;

public class InfoUserDTO
{
    public int usuario_id { get; set; }

    public string usuarioDB { get; set; } = string.Empty;

    public byte[] contrasenia { get; set; } = Array.Empty<byte>();
}
