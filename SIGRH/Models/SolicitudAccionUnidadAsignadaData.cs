using System;

namespace SIGRH.Models;

public class SolicitudAccionUnidadAsignadaData : SolicitudAccionData
{
    public string IdSolicitudAccionUnidadAsignada { get; set; } = string.Empty;
    public string IdUnidadAsignada { get; set; } = string.Empty;
    public string IdPersonalAsignada { get; set; } = string.Empty;
    public string FechaAsignadaUnidad { get; set; } = string.Empty;
    public string Observacion { get; set; } = string.Empty;
    public string NombreUnidad { get; set; } = string.Empty;
    public string DescripcionEstatus { get; set; } = string.Empty;
}
