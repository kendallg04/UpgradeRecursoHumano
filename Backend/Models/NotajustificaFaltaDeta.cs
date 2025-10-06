using System;

namespace SIGRH.Models;

public class NotajustificaFaltaDeta : NotaJustificaFalta
{
    public int IdNotaJustificaFaltaDeta { get; set; }
    public int IdInstalacion { get; set; }
    public int IdInstalacionSub { get; set; }
    public int IdProvincia { get; set; }
    public int IdDistrito { get; set; }
    public int IdCorregimiento { get; set; }
    public string Instalacion { get; set; } = string.Empty;
    public string InstalacionSub { get; set; } = string.Empty;
    public string Provincia { get; set; } = string.Empty;
    public string Distrito { get; set; } = string.Empty;
    public string Corregimiento { get; set; } = string.Empty;
    public DateTime FechaInicioDet { get; set; }
    public DateTime FechaFinalDet { get; set; }
    public string HoraInicioDet { get; set; } = string.Empty;
    public string HoraFinalDet { get; set; } = string.Empty;
}
