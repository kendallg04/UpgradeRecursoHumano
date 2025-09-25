using System;
using System.ComponentModel.DataAnnotations;

namespace SIGRH.Models;

public class DetalleMarcacion
{
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Required]
    public DateTime FechaInicio { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Required]
    public DateTime FechaFin { get; set; }

    public int IdRol { get; set; }
    public string Unidad { get; set; } = string.Empty;
    public int IdUnidad { get; set; }
    public int IdUnidadNivel { get; set; }
    public int IdPersonal { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string idUnidaddl { get; set; } = string.Empty;
    public string idPersonalddl { get; set; } = string.Empty;
    public int IdUnidadExp { get; set; }

}
