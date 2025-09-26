using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SIGRH.Models;

public class DerechoVacacion
{
    public string Cedula { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public string FechaInicial { get; set; } = string.Empty;
    public string FechaFinal { get; set; } = string.Empty;
    public string Efectiva { get; set; } = string.Empty;
    public string NumeroDoc { get; set; } = string.Empty;
    public string FechaDoc { get; set; } = string.Empty;
    public string TipoDocumento { get; set; } = string.Empty;
    public string Dedicacion { get; set; } = string.Empty;
    public string Estamento { get; set; } = string.Empty;
    public string Cargo { get; set; } = string.Empty;
    public string Unidad { get; set; } = string.Empty;
    public string IdPersonal { get; set; } = string.Empty;
    public string IdDerechoVacacion { get; set; } = string.Empty;
    public string CodigoUnidad { get; set; } = string.Empty;
    public string IdCargo { get; set; } = string.Empty;
    public string IdUnidad { get; set; } = string.Empty;
    public string IdEstatusCons { get; set; } = string.Empty;
    public string Observacion { get; set; } = string.Empty;
    public string Estatus { get; set; } = string.Empty;
    public string Correo { get; set; } = string.Empty;
    public int IdEstatus { get; set; }
    public List<SelectListItem> ListaEstatus { get; set; } = new List<SelectListItem>();
}
