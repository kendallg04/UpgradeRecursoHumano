using System;

namespace SIGRH.Models;

public class ConsultaHorarioPersonal
{
    public string HoraEntrada { get; set; } = string.Empty;
    public string HoraSalida { get; set; } = string.Empty;
    public string Jornada { get; set; } = string.Empty;
    public string IdHorario { get; set; } = string.Empty;
    public string NumeroDia { get; set; } = string.Empty;
    public string CodigoReloj { get; set; } = string.Empty;
    public string IdUnidad { get; set; } = string.Empty;
    public string IdPersonal { get; set; } = string.Empty;
    public string FechaActivar { get; set; } = string.Empty;
    public string FechaInactivar { get; set; } = string.Empty;
    public string TipoHorario { get; set; } = string.Empty;
    public string JornadaMin { get; set; } = string.Empty;
}
