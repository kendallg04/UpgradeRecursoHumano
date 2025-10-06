using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SIGRH.Models;

public class Otras
{
    public int IdBoletaOtra { get; set; }
    [Required]
    public int IdPersonal { get; set; }
    public int IdUnidad { get; set; }
    [Required]
    public int IdDocumentoTipo { get; set; }
    public int IdPersonalRegistra { get; set; }
    public int IdPersonalAutoriza { get; set; }
    public int Idestatus { get; set; }
    public int IdHorario { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Required]
    public DateTime FechaEmision { get; set; }
    //[Required]
    public string Jornada { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Required]
    public DateTime FechaInicio { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Required]
    public DateTime FechaFin { get; set; }
    [Required]
    public string Observacion { get; set; } = string.Empty;
    public DateTime FechaRegistro { get; set; }
    public DateTime FechaAprobacion { get; set; }
    public DateTime JornadaTrabajo { get; set; }
    public string ObservacionJefe { get; set; } = string.Empty;
    public int IdRol { get; set; }
    public int TotalOtrasMin { get; set; }
    public int TotalDia { get; set; }
    public int TotalHora { get; set; }
    public int TotalMin { get; set; }
    public int TotalEnfermedadMinSaldoInicial { get; set; }
    public int Periodo => DateTime.Now.Year;
    public int IdUnidadSel { get; set; }
    public int SaldoTotalMin { get; set; }
    public int SaldoDia { get; set; }
    public int SaldoHora { get; set; }
    public int SaldoMinuto { get; set; }
    public int SaldoCorteMinuto { get; set; }
    public string NombreUnidad { get; set; } = string.Empty;
    public int IdPersonalConsulta { get; set; }
    public int IdEstatusConsulta { get; set; }
    public string TipoExpediente { get; set; } = string.Empty;
    public int TieneNivel { get; set; }
    public int IdUnidadNivel { get; set; }
    public int IdSolicitudAccionDetalle { get; set; }
    public int IdParentesco { get; set; }
    public bool EnviarCorreo { get; set; }
    public string RutaImagen { get; set; } = string.Empty;
    public string HoraInicio { get; set; } = string.Empty;
    public string HoraFinal { get; set; } = string.Empty;
    public string Accion { get; set; } = string.Empty;
    public bool TieneDiasFriado { get; set; }
    public bool TieneDiasPago { get; set; }
    // public HttpPostedFileBase image_file { get; set; }
    public List<SelectListItem> UnidadNivel { get; set; } = new();
    public List<SelectListItem> EstatusConsulta { get; set; } = new();
    public List<SelectListItem> Colaborador { get; set; } = new();
    public List<SelectListItem> Unidad { get; set; } = new();
    public List<SelectListItem> Estatus { get; set; } = new();
    public List<SelectListItem> ColaboradorConsulta { get; set; } = new();
    public List<ConsultaOtra> BoletasOtrasData { get; set; } = new();
    public List<SelectListItem> DocumentoTipo { get; set; } = new();
    public List<ConsultaMarcacionPersonal> MarcacionPersonal { get; set; } = new();
    public List<ConsultaHorarioPersonal> HorarioPersonal { get; set; } = new();
    public List<ConsultaDiaLibrePersonal> DiasLibresPersonal { get; set; } = new();
    public List<SelectListItem> Parentesco { get; set; } = new();
    public List<SelectListItem> ItemsAnio { get; set; } = new();
}
