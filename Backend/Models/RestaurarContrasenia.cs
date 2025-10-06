using System;
using System.ComponentModel.DataAnnotations;

namespace SIGRH.Models;

public class RestaurarContrasenia
{
    public string UserName { get; set; } = string.Empty;

    [Required(ErrorMessage = "La contraseña es requerida")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;

    [Required(ErrorMessage = "Confirme la contraseña")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; } = string.Empty;
    public string PasswordEncriptada { get; set; } = string.Empty;
}
