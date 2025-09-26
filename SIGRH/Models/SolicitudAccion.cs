using System;
using System.ComponentModel.DataAnnotations;

namespace SIGRH.Models;

public class SolicitudAccion
{
    [Required]
    public int IdSolicitudAccion { get; set; }
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Escoja el tipo de entrada")]
    public int IdTipoEntrada { get; set; }
    public int IdPersonalSubDirectorAsignado { get; set; }
    public int? IdPrioridad { get; set; }
    public int? IdSolicitudAccionOrigen { get; set; }
    public int IdPersonaAutoriza { get; set; }
    public int IdPersonaRegistra { get; set; }
    public int IdEstatus { get; set; }
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Escoja el tipo de solicitud")]
    public int IdTipoSolicitud { get; set; }
    public int IdPersonalDirectorAsignado { get; set; }
    public int IdPersonalAsistenteEjecutivoAsignado { get; set; }
    public int IdUnidad { get; set; }
    public string Numero { get; set; } = string.Empty;

    [Required(ErrorMessage = "Introduzca la fecha del documento")]
    public DateTime? Fecha { get; set; }
    public string Observacion { get; set; } = string.Empty;
    public DateTime FechaRegistro { get; set; }
    public string UrlSolicitud { get; set; } = string.Empty;
    public string NumeroValija { get; set; } = string.Empty;
    public DateTime? FechaValija { get; set; }
    public string UnidadNombre { get; set; } = string.Empty;
    public string Firmante { get; set; } = string.Empty;
    [Required(ErrorMessage = "La descripción del documento es obligatoria")]
    public string DescripcionSolicitud { get; set; } = string.Empty;
    public string IndicacionesIniciales { get; set; } = string.Empty;
    [Display(Name = "Llegó nota física")]
    public bool NotaFisica { get; set; }
    public DateTime? FechaRecibidaNotaFisica { get; set; }
    public bool Confidencial { get; set; }
    public DateTime? FechaAsignadoDirector { get; set; }
    public DateTime? FechaAsignadoAsistenteEjecutivo { get; set; }
    public DateTime? FechaAsignadoSubDirector { get; set; }
    public string NombrePersonalDirectorAsignado { get; set; } = string.Empty;
    public string NombrePersonalSubDirectorAsignado { get; set; } = string.Empty;
    public string NombrePersonalAsistenteEjecutivoAsignado { get; set; } = string.Empty;
    public int? IdPeriodoAcademico { get; set; }
    public int? IdSemestre { get; set; }
    // public HttpPostedFileBase documento { get; set; }
}
