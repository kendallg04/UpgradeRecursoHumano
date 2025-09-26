using System;

namespace SIGRH.Models;

public class SolicitudAccionUnidadAsignada : SolicitudAccion
{

    public int IdSolicitudAccionUnidadAsignada { get; set; }
    public int IdUnidadAsignada { get; set; }
    public int IdPersonalAsignado { get; set; }
    public int IdEstatusAccUnidadAsig { get; set; }
    public DateTime FechaAsignada { get; set; }
    public string ObservacionAccUnidadAsig { get; set; } = string.Empty;

}
