using System;
using System.ComponentModel.DataAnnotations;

namespace SIGRH.Models.DTO.Request;

public class UserRegistroRequest
{
    public int IdPersonal { get; set; }

    [Required(ErrorMessage = "La cédula es requerida")]
    [RegularExpression(@"^[1-9_A-Z]{1,2}-\d{1,4}-\d{1,6}$", ErrorMessage = "Ingrese una cédula valida")]
    public string Cedula { get; set; } = string.Empty;

    [Required(ErrorMessage = "La Contraseña es requerida")]
    [StringLength(16, MinimumLength = 6, ErrorMessage = "La contraseña debe tener entre 6 y 16 caracteres")]
    public string Password { get; set; } = string.Empty;

    public int IdEstamento { get; set; }
}
