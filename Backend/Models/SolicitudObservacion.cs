using System;

namespace SIGRH.Models;

public class SolicitudObservacion
{
    public int Id { get; set; }
    public int IdSolicitud { get; set; }
    public string DescripcionObservacion { get; set; } = string.Empty;
    public DateTime Fecha { get; set; }
    public int IdPersonal { get; set; }
}
