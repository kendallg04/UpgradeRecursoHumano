using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SIGRH.Models;

public class Enfermedad
{
    public int IdBoletaEnfermedad { get; set; }
    [Required]
    public int IdPersonal { get; set; }
    public int IdUnidad { get; set; }
    [Required]
    public int IdDocumentoTipo { get; set; }
    public int IdPersonalRegistra { get; set; }
    public int IdPersonalAutoriza { get; set; }
    public int IdEstatus { get; set; }
    public int IdHorario { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Required]
    public DateTime FechaEmision { get; set; }

    [Required]
    public string Jornada { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Required(ErrorMessage = "La fecha de inicio es requerida")]
    public DateTime FechaInicio { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Required(ErrorMessage = "La fecha final es requerida")]
    public DateTime FechaFin { get; set; }

    [Required]
    public string Observacion { get; set; } = string.Empty;

    public DateTime FechaRegistro { get; set; }
    public DateTime FechaAprobacion { get; set; }
    public DateTime JornadaTrabajo { get; set; }
    public string ObservacionJefe { get; set; } = string.Empty;
    public int IdRol { get; set; }
    public int TotalEnfermedadMin { get; set; }
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
    public bool EnviarCorreo { get; set; }
    public string RutaImagen { get; set; } = string.Empty;
    public string HoraInicio { get; set; } = string.Empty;
    public string HoraFinal { get; set; } = string.Empty;
    public bool TieneDiasFriado { get; set; }
    public bool TieneDiasPago { get; set; }
    public string numero_certificado { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime FechaCertificado { get; set; }

    public string CentroMedico { get; set; } = string.Empty;

    // public HttpPostedFileBase image_file { get; set; }
    public List<SelectListItem> UnidadNiveles { get; set; } = new List<SelectListItem>();
    public List<SelectListItem> EstatusConsultas { get; set; } = new List<SelectListItem>();
    public List<SelectListItem> Colaboradores { get; set; } = new List<SelectListItem>();
    public List<SelectListItem> Unidades { get; set; } = new List<SelectListItem>();
    public List<SelectListItem> Estatus { get; set; } = new List<SelectListItem>();
    public List<SelectListItem> ColaboradorConsultas { get; set; } = new List<SelectListItem>();
    public List<ConsultaEnfermedad> BoletasEnfermedadData { get; set; } = new List<ConsultaEnfermedad>();
    public List<SelectListItem> DocumentoTipo { get; set; } = new List<SelectListItem>();
    public List<ConsultaMarcacionPersonal> MarcacionPersonal { get; set; } = new List<ConsultaMarcacionPersonal>();
    public List<ConsultaHorarioPersonal> HorarioPersonal { get; set; } = new List<ConsultaHorarioPersonal>();
    public List<ConsultaDiaLibrePersonal> DiasLibresPersonal { get; set; } = new List<ConsultaDiaLibrePersonal>();
    public string Accion { get; set; } = string.Empty;
    public List<SelectListItem> ItemsAnio { get; set; } = new List<SelectListItem>();
    public int PeriodoSaldo { get; set; }
}
