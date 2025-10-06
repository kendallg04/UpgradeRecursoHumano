using System;

namespace SIGRH.Models;

public class CargoResumen
{
    public string Resumen { get; set; } = string.Empty;
    public string Observacion { get; set; } = string.Empty;
    public string FechaRevision { get; set; } = string.Empty;

    public string CodigoCargo { get; set; } = string.Empty;

    public string Descripcion { get; set; } = string.Empty;
}
