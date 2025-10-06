using System;

namespace SIGRH.Models;

public class PeriodoVacDicConsulta
{
    public string IdPeriodoVacaciones { get; set; } = string.Empty;

    public string FechaInicio { get; set; } = string.Empty;

    public string FechaFin { get; set; } = string.Empty;

    public string Anio { get; set; } = string.Empty;

    public string Dias { get; set; } = string.Empty;

    public string Nota { get; set; } = string.Empty;

    public string FechaNota { get; set; } = string.Empty;

    public string NombreCompleto { get; set; } = string.Empty;

    public string IdPersonaAutoriza { get; set; } = string.Empty;
}
