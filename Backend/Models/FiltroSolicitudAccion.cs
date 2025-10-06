using System;

namespace SIGRH.Models;

public class FiltroSolicitudAccion
{
    public string Fecha { get; set; } = string.Empty;
    public string Numero { get; set; } = string.Empty;
    public int IdUnidad { get; set; }
    public string DescripcionSolicitud { get; set; } = string.Empty;
    public string Firmante { get; set; } = string.Empty;
    public int IdEstatus { get; set; }
    public int IdTipoSolicitud { get; set; }
    public int IdSemestre { get; set; }
}
