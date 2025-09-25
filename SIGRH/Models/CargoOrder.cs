using System;

namespace SIGRH.Models;

public class CargoOrder
{
    public int Id { get; set; }
    public string Descripcion { get; set; } = string.Empty;
    public int IdCargo { get; set; }
    public string CodigoCargo { get; set; } = string.Empty;
}
