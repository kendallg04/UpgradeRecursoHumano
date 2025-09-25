using System;
using System.ComponentModel.DataAnnotations;

namespace SIGRH.Models;

public class EjecutivaCorreo
{
    public int IdEjecutivaCorreo { get; set; }

    [Required]
    public int IdPersonal { get; set; }

    [Required]
    public bool Inactivo { get; set; }
}
