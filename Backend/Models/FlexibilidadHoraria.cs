using System;
using System.ComponentModel.DataAnnotations;

namespace SIGRH.Models;

public class FlexibilidadHoraria
{
    //-------------------------------------Drop consulta Instalaciones 
    public int? IdI { get; set; }
    public string DescripcionI { get; set; } = string.Empty;
    //-------------------------------------Drop consulta Horarios
    public int? IdH { get; set; }
    public string DescripcionH { get; set; } = string.Empty;
    //-------------------------------------Grid de consulta instalaciones con flexibilidad en horario
    public int? IdHorarioInstalacionFlexibilidad { get; set; }
    public int? IdInstalacion { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public int? IdHorario { get; set; }
    public string Descripcion { get; set; } = string.Empty;
    public int? Estado { get; set; }
    public string Estatus { get; set; } = string.Empty;
    public string FechaInicio { get; set; } = string.Empty;
    public string FechaFinal { get; set; } = string.Empty;
    public string Flexibilidad { get; set; } = string.Empty;
    //-------------------------------------Drop Nuevo/Editar Instalaciones 
    public int? IdIN { get; set; }
    public string DescripcionIN { get; set; } = string.Empty;
    //-------------------------------------Drop Nuevo/Editar Horarios
    public int? ID_hN { get; set; }
    public string DescripcionHN { get; set; } = string.Empty;
    //-------------------------------------Grid de consulta instalaciones con flexibilidad en horario
    public int? IdHIF_Aeditar { get; set; }
    //-------------------------------------Campos Fecha Nuevo/Editar Horarios
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    //[Required]
    public DateTime fecha_inicio { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    // [Required]
    public DateTime FechaFin { get; set; }
}
