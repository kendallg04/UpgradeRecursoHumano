using System;

namespace SIGRH.Models;

public class TardanzaAusencia
{
    public string IdTardanzaAusencia { get; set; } = string.Empty;
    public string CodigoReloj { get; set; } = string.Empty;
    public string Tipo { get; set; } = string.Empty;
    public string HoraInicio { get; set; } = string.Empty;
    public string Fecha { get; set; } = string.Empty;
    public string HoraFinal { get; set; } = string.Empty;
    public string Intervalo { get; set; } = string.Empty;
}
