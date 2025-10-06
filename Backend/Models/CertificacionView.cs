using System;
using System.ComponentModel.DataAnnotations;

namespace SIGRH.Models;

public class CertificacionView : Certificacion
{
    public string IdCertificacionesCol { get; set; } = string.Empty;
    public string IdEstatusCol { get; set; } = string.Empty;
    public string TipoServicio { get; set; } = string.Empty;
    public string Colaborador { get; set; } = string.Empty;
    public string Estatus { get; set; } = string.Empty;
    public string DirigidaCol { get; set; } = string.Empty;
    public string FechaRegistradaCol { get; set; } = string.Empty;
    public string FechaEmisionCol { get; set; } = string.Empty;
    public string FechaProcesadaCol { get; set; } = string.Empty;
    public string ObservacionColaboradorCol { get; set; } = string.Empty;
    public string ObservacionTramitadoCol { get; set; } = string.Empty;
    // public HttpPostedFile Archivo { get; set; }
    [Display(Name = "Unidad")]
    public int IdUnidadConsulta { get; set; }
    public int IdRol { get; set; }
    [Display(Name = "Colaborador")]
    public string NombreColaborador { get; set; } = string.Empty;
    [Display(Name = "Unidad")]
    public string NombreUnidad { get; set; } = string.Empty;
    [Display(Name = "Cargo")]
    public string NombreCargo { get; set; } = string.Empty;
    //[Display(Name = "Observación")]
    //public string observacion { get; set; }
    [Display(Name = "Estatus")]
    public int IdEstatusConsulta { get; set; }
    [Display(Name = "Colaborador")]
    public int IdPersonalConsulta { get; set; }
    public int IdUnidadNivel { get; set; }
    public string HorarioCol { get; set; } = string.Empty;
    public string EstatusCol { get; set; } = string.Empty;
    public string PersonaRegistra { get; set; } = string.Empty;
    public string PersonaProcesa { get; set; } = string.Empty;
}
