using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SIGRH.Models;

public class Procesamiento
{
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFinal { get; set; }
    public string CodigoReloj { get; set; } = string.Empty;
    public string CodigoUnidad { get; set; } = string.Empty;
    public int CodigoUbica { get; set; }
    public string Cedula { get; set; } = string.Empty;
    public int IdPersonal { get; set; }
    public string IdPersonalFiltro { get; set; } = string.Empty;
    public int CodigoUnidadFiltro { get; set; }
    public List<SelectListItem> Instalacion { get; set; } = new();
    public List<SelectListItem> Unidad { get; set; } = new();
    public List<SelectListItem> Colaborador { get; set; } = new();
}
