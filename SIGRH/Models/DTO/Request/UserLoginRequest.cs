using System;
using System.ComponentModel.DataAnnotations;

namespace SIGRH.Models.DTO.Request;

public class UserLoginRequest
{
    [Required(ErrorMessage = "La cédula es requerida")]
    [RegularExpression(@"^[1-9_A-Z]{1,2}-\d{1,4}-\d{1,6}$", ErrorMessage = "Ingrese una cédula valida")]
    public string UserName { get; set; } = string.Empty;

    [Required(ErrorMessage = "La contraseña es requerida")]
    public string Password { get; set; } = string.Empty;

    public string? PasswordEncrypted { get; set; }
}
