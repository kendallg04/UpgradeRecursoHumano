using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SIGRH.Models;

public class VacacionView : Vacacion
{
    public List<SelectListItem> Colaborador { get; set; } = new();
    public List<SelectListItem> Unidad { get; set; } = new();
    public List<SelectListItem> Estatus { get; set; } = new();
    public int Periodo => DateTime.Now.Year;
    public int IdUnidadSel { get; set; }
    public List<ConsultaVacacion> BoletasVacacionesData { get; set; } = new();
    public int IdRol { get; set; }
    public string NombreCompleto { get; set; } = string.Empty;
    public string NombreUnidad { get; set; } = string.Empty;
    public int IdPersonalConsulta { get; set; }
    public List<SelectListItem> ColaboradorConsulta { get; set; } = new();
    public int IdEstatusConsulta { get; set; }
    public List<SelectListItem> EstatusConsulta { get; set; } = new();
    public string TipoExpediente { get; set; } = string.Empty;
    public int TieneNivel { get; set; }
    public List<SelectListItem> UnidadNivel { get; set; } = new();
    public int IdUnidadNivel { get; set; }
    public bool EnviarCorreo { get; set; }
    public string RutaImagen { get; set; } = string.Empty;
    // public HttpPostedFileBase image_file { get; set; }
    public string Accion { get; set; } = string.Empty;
    public List<SelectListItem> ItemsAnio { get; set; } = new();
    public List<SelectListItem> DocumentoTipo { get; set; } = new();
}
