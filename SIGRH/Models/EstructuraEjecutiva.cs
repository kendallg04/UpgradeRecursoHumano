using System;
using System.ComponentModel.DataAnnotations;

namespace SIGRH.Models;

public class EstructuraEjecutiva
{
    public int IdEstructuraEjecutiva { get; set; }

    [Required(ErrorMessage = "El número de la ejecutiva es requerido")]
    public string NumeroEjecutiva { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Required(ErrorMessage = "La fecha de la ejecutiva es requerida")]
    public DateTime FechaEjecutiva { get; set; }

    [Required(ErrorMessage = "El objeto de gasto es requerido")]
    public int IdObjetoGasto { get; set; }

    public int Codigo { get; set; }

    [Required(ErrorMessage = "El período es requerido")]
    public int Periodo { get; set; }

    [Required(ErrorMessage = "El estatus es requerido")]
    public int IdEstatus { get; set; }

    public string Estatus { get; set; } = string.Empty;

    public string Observacion { get; set; } = string.Empty;

    public string Url { get; set; } = string.Empty;

    // public HttpPostedFileBase ArchivoAdjunto { get; set; }
}
