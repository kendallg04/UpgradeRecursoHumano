using System;
using System.ComponentModel.DataAnnotations;

namespace SIGRH.Models;

public class NotaJustificaFalta
{
    public int IdNotaJustificaFalta { get; set; }

    [Required(ErrorMessage = "El número de nota es requerido")]
    public string NumeroNota { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Required(ErrorMessage = "La fecha de la nota es requerida")]
    public DateTime FechaNota { get; set; }

    [Required]
    public int IdPersonalAutoriza { get; set; }

    [Required]
    public string Motivo { get; set; } = string.Empty;

    //[DataType(DataType.Date)]
    //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    //[Required(ErrorMessage = "La fecha de inicio es requerida")]
    //public DateTime fecha_inicio { get; set; }
    //[DataType(DataType.Date)]
    //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    //[Required(ErrorMessage = "La fecha final es requerida")]
    //public DateTime fecha_final { get; set; }
    //public string hora_inicio { get; set; }
    //public string hora_final { get; set; }
    public string UrlNotaJf { get; set; } = string.Empty;

    [Required]
    public int IdDocumentoTipo { get; set; }

    public int IdTipoFalta { get; set; }

    public bool Inactivo { get; set; }

    public string Autoriza { get; set; } = string.Empty;

    public string TipoBoleta { get; set; } = string.Empty;

    public string TipoFalta { get; set; } = string.Empty;

    // public List<NotaJustificaFaltaDeta> notaJustificaFaltaDetas { get; set; }
    // public HttpPostedFileBase image_file { get; set; }
}
