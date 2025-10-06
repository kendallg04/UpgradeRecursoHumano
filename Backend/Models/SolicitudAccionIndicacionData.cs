using System;

namespace SIGRH.Models;

public class SolicitudAccionIndicacionData : SolicitudAccionData
{
    public string UnidadNombreUsuario { get; set; } = string.Empty;
    public string IdSolicitudAccionIndicaciones { get; set; } = string.Empty;
    public string Usuario { get; set; } = string.Empty;
    public string DescripcionIndicaciones { get; set; } = string.Empty;
    public string FechaIndicaciones { get; set; } = string.Empty;
    public string IdUnidad { get; set; } = string.Empty;
    public string IdPersonal { get; set; } = string.Empty;
    public string UnidadUsuario { get; set; } = string.Empty;
}
