using System;
using System.ComponentModel.DataAnnotations;

namespace SIGRH.Models;

public class Vacacion
{
    public int IdVacacionesBoleta { get; set; }

    [Required]
    public int IdPersonal { get; set; }
    public int IdUnidad { get; set; }
    public int IdDocumentoTipo { get; set; }
    public int IdPersonalRegistra { get; set; }
    public int IdPersonalAutoriza { get; set; }
    public int IdEstatus { get; set; }
    public int IdSolicitudAccionDetalle { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime FechaEmision { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Required(ErrorMessage = "La fecha de inicio es requerida")]
    public DateTime FechaInicio { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Required(ErrorMessage = "La fecha final es requerida")]
    public DateTime FechaFin { get; set; }
    public int TotalDias { get; set; }

    [Required]
    public string Observacion { get; set; } = string.Empty;
    public DateTime FechaAprobacion { get; set; }
    public string ObservacionJefe { get; set; } = string.Empty;
    public int SaldoCorte { get; set; }
    public int SaldoDia { get; set; }

    [Range(minimum: 1, maximum: int.MaxValue, ErrorMessage = "Introduzca el total de días a reponer")]
    public int TotalDiaATomar { get; set; }
}
