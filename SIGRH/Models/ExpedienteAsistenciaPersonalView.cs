using System;
using System.ComponentModel.DataAnnotations;

namespace SIGRH.Models;

public class ExpedienteAsistenciaPersonalView
{
    public int IdExpedienteAsistencia { get; set; }

    [Required(ErrorMessage = "Introduzca el colaborador")]
    [Range(1, int.MaxValue, ErrorMessage = "Introduzca el colaborador")]
    public int IdPersonal { get; set; }

    [Required(ErrorMessage = "Escoja la unidad del colaborador")]
    [Range(1, int.MaxValue, ErrorMessage = "Escoja la unidad del colaborador")]
    public int IdUnidad { get; set; }

    public int IdUnidad_nivel { get; set; }

    [Required(ErrorMessage = "Escoja el cargo del colaborador")]
    [Range(1, int.MaxValue, ErrorMessage = "Escoja el cargo del colaborador")]
    public int IdCargo { get; set; }

    [Required(ErrorMessage = "Escoja el estamento del colaborador")]
    [Range(1, int.MaxValue, ErrorMessage = "Escoja el estamento del colaborador")]
    public int IdEstamento { get; set; }

    [Required(ErrorMessage = "Escoja el estatus del colaborador")]
    [Range(1, int.MaxValue, ErrorMessage = "Escoja el estatus del colaborador")]
    public int IdEstatus { get; set; }

    public string Dedicacion { get; set; } = string.Empty;

    public string TipoExpediente { get; set; } = string.Empty;

    public bool AsistenciaPerfecta { get; set; }

    public int IdUnidadExp { get; set; }

    public string Nombre { get; set; } = string.Empty;
}
