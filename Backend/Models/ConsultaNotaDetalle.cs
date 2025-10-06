using System;

namespace SIGRH.Models;

public class ConsultaNotaDetalle
{
    public string Instalacion { get; set; } = string.Empty;
    public string InstalacionSub { get; set; } = string.Empty;
    public string Provincia { get; set; } = string.Empty;
    public string Distrito { get; set; } = string.Empty;
    public string Corregimiento { get; set; } = string.Empty;
    public string IdInstalacion { get; set; } = string.Empty;
    public string IdInstalacionSub { get; set; } = string.Empty;
    public string IdProvincia { get; set; } = string.Empty;
    public string IdDistrito { get; set; } = string.Empty;
    public string IdCorregimiento { get; set; } = string.Empty;
    public string IdNotaJustificaFaltaDeta { get; set; } = string.Empty;
    public string FechaInicio { get; set; } = string.Empty;
    public string FechaFinal { get; set; } = string.Empty;
}
