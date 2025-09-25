using System;
using System.ComponentModel.DataAnnotations;

namespace SIGRH.Models;

public class PeriodoVacacionesDic
{
    public int IdPeriodoVacaciones { get; set; }

    [Required(ErrorMessage = "La fecha de inicio es requerido")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime FechaInicio { get; set; }

    [Required(ErrorMessage = "La fecha de fin es requerido")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime FechaFin { get; set; }

    [Required(ErrorMessage = "El año es requerido")]
    public int Anio { get; set; }

    public int Dias { get; set; }

    public string Nota { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    public DateTime FechaNota { get; set; } = DateTime.Now.Date;

    public int IdPersonaAutoriza { get; set; }
}
