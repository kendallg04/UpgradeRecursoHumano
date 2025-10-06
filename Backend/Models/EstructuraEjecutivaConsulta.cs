using System;

namespace SIGRH.Models;

public class EstructuraEjecutivaConsulta
{
    public string IdEstructuraEjecutiva { get; set; } = string.Empty;
    public string NumeroEjecutiva { get; set; } = string.Empty;
    public string FechaEjecutiva { get; set; } = string.Empty;
    public string Codigo { get; set; } = string.Empty;
    public string IdObjetoGasto { get; set; } = string.Empty;
    public string Periodo { get; set; } = string.Empty;
    public string IdEstatus { get; set; } = string.Empty;
    public string Estatus { get; set; } = string.Empty;
    public string Observacion { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}
