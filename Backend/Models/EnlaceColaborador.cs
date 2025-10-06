using System;
using System.ComponentModel.DataAnnotations;

namespace SIGRH.Models;

public class EnlaceColaborador
{
    [Required(ErrorMessage = "La cédula es requerida")]
    [RegularExpression(@"^[1-9_A-Z]{1,2}-\d{1,4}-\d{1,6}$", ErrorMessage = "Ingrese una cédula valida")]
    public string Cedula { get; set; } = string.Empty;
    public string CedulaValidacion { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string ConfirmPassword { get; set; } = string.Empty;
}
