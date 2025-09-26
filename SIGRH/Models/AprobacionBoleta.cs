using System;

namespace SIGRH.Models;

public class AprobacionBoleta
{
    public string IdBoleta { get; set; } = string.Empty;
    public string NombreCompleto { get; set; } = string.Empty;
    public string Boleta { get; set; } = string.Empty;
    public string FechaEmision { get; set; } = string.Empty;
    public string FechaInicio { get; set; } = string.Empty;
    public string FechaFinal { get; set; } = string.Empty;
    public string DiaTomado { get; set; } = string.Empty;
    public string HoraTomada { get; set; } = string.Empty;
    public string MinutoTomado { get; set; } = string.Empty;
    public string DiaFavor { get; set; } = string.Empty;
    public string HoraFavor { get; set; } = string.Empty;
    public string MinutoFavor { get; set; } = string.Empty;
    public string Observacion { get; set; } = string.Empty;
    public string ObservacionJefe { get; set; } = string.Empty;
    public string FechaRegistro { get; set; } = string.Empty;
    public string UrlArchivo { get; set; } = string.Empty;
    public string Foto { get; set; } = string.Empty;
}
