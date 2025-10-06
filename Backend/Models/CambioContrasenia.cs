using System;
using System.ComponentModel.DataAnnotations;

namespace SIGRH.Models;

public class CambioContrasenia
{
    [Required]
    [DataType(DataType.Password)]
    public string ClaveActual { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Password)]
    public string ClaveNueva { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Password)]
    public string ClaveNuevaRepetir { get; set; } = string.Empty;

    public string ClaveActualEncriptar { get; set; } = string.Empty;

    public string ClaveNuevaEncriptar { get; set; } = string.Empty;
}
