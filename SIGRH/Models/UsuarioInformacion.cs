using System;

namespace SIGRH.Models;

public class UsuarioInformacion
{
    public string IdPersonal { get; set; } = string.Empty;
    public string CodigoUnidad { get; set; } = string.Empty;
    public string IdUnidad { get; set; } = string.Empty;
    public string IdCargo { get; set; } = string.Empty;
    public string Cargo { get; set; } = string.Empty;
    public string IdEstamento { get; set; } = string.Empty;
    public string Estamento { get; set; } = string.Empty;
    public string Dedicacion { get; set; } = string.Empty;
    public string TipoExpediente { get; set; } = string.Empty;
    public string Unidad { get; set; } = string.Empty;
    public string NombreBdSugerido { get; set; } = string.Empty;
}
