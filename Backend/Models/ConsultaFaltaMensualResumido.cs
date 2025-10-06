using System;

namespace SIGRH.Models;

public class ConsultaFaltaMensualResumido
{
    public string TipoFalta { get; set; } = string.Empty;
    public string HoraInicial { get; set; } = string.Empty;
    public string HoraFinal { get; set; } = string.Empty;
    public string Intervalo { get; set; } = string.Empty;
    public string Horario { get; set; } = string.Empty;
    public string Dia { get; set; } = string.Empty;
    public string Mes { get; set; } = string.Empty;
    public string Anio { get; set; } = string.Empty;
    public string Observacion { get; set; } = string.Empty;
    public string Encabezado { get; set; } = string.Empty;
    public string UltimoDiaMesActual { get; set; } = string.Empty;
}
