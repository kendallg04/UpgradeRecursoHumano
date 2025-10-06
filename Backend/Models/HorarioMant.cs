using System;
using System.ComponentModel.DataAnnotations;

namespace SIGRH.Models;

public class HorarioMant
{
    public int? Idhorario { get; set; }
    [Required(ErrorMessage = "Introduzca la descripción")]
    public string Descripcion { get; set; } = string.Empty;
    [Required(ErrorMessage = "Escoja el tipo de horario")]
    public string TipoHorario { get; set; } = string.Empty;
    public string NumeroDia { get; set; } = string.Empty;
    public string Turno { get; set; } = string.Empty;

    [Required(ErrorMessage = "Introduzca la flexibilidad")]
    [RegularExpression(@"^[0-1][0-9]:[0-5][0-9]$", ErrorMessage = "Introduzca una hora de flexibilidad correcta")]
    public string Flexibilidad { get; set; } = string.Empty;

    [RegularExpression(@"^[0-1][0-9]:[0-5][0-9]$", ErrorMessage = "Introduzca una hora de tardanza minima correcta")]
    [Required(ErrorMessage = "Introduzca la tardanza minima")]
    public string TardanzaMinima { get; set; } = string.Empty;

    [Required(ErrorMessage = "Introduzca la tardanza maxima")]
    [RegularExpression(@"^[0-1][0-9]:[0-5][0-9]$", ErrorMessage = "Introduzca una hora de tardanza maxima correcta")]
    public string TardanzaMaxima { get; set; } = string.Empty;

    [Required(ErrorMessage = "Introduzca la hora")]
    [RegularExpression(@"^[0-1][0-9]:[0-5][0-9]$", ErrorMessage = "Introduzca una hora correcta")]
    public string NumeroHora { get; set; } = string.Empty;

    [Required(ErrorMessage = "Introduzca la hora de asuencia")]
    [RegularExpression(@"^[0-1][0-9]:[0-5][0-9]$", ErrorMessage = "Introduzca una hora de asucencia correcta")]
    public string HoraAusencia { get; set; } = string.Empty;

    [Required(ErrorMessage = "Introduzca la hora de entrada")]
    public string HoraEntrada1 { get; set; } = string.Empty;

    [Required(ErrorMessage = "Introduzca la hora de salida")]
    public string HoraSalida1 { get; set; } = string.Empty;
    public short Periodo { get; set; }
    //public int Idestatus { get; set; }
    public string Estatus { get; set; } = string.Empty;
    public int CodigoHorarioAnterior { get; set; }

    [Required(ErrorMessage = "Introduzca la hora de comida de entrada")]
    [RegularExpression(@"^[0-1][0-9]:[0-5][0-9]$", ErrorMessage = "Introduzca una hora de comida de entrada correcta")]
    public string HoraComidaEntrada { get; set; } = string.Empty;

    [Required(ErrorMessage = "Introduzca la hora de comida de salida")]
    [RegularExpression(@"^[0-1][0-9]:[0-5][0-9]$", ErrorMessage = "Introduzca una hora de comida de salida correcta")]
    public string HoraComidaSalida { get; set; } = string.Empty;

    [Range(1, 7, ErrorMessage = "Escoja el día")]
    public int? IDNumero_dia { get; set; }

    [Required(ErrorMessage = "Escoja el turno")]
    public string IDTurno { get; set; } = string.Empty;

    [Range(4, 5, ErrorMessage = "Escoja el estatus")]
    public int? IDEstatus { get; set; }
}
