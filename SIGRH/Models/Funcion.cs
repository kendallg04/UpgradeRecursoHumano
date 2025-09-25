using System;

namespace SIGRH.Models;

public class Funcion
{
    public int IdFuncion { get; set; }
    public int Orden { get; set; }
    public string DescripcionFuncion { get; set; } = string.Empty;
    public string CodigoFuncion { get; set; } = string.Empty;
}
