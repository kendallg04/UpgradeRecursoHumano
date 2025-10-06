using System;

namespace SIGRH.Models;

public class SolicitudAccionIndicacion : SolicitudAccion
{
    public int IdSolicitudAccionIndicaciones { get; set; }
    public string Descripcion { get; set; } = string.Empty;
    public DateTime FechaAccInd { get; set; }
    public int IdPersonal { get; set; }
}
