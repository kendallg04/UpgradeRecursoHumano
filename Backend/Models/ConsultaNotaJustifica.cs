using System;

namespace SIGRH.Models;

public class ConsultaNotaJustifica
{
    public string NumeroNota { get; set; } = string.Empty;
    public string FechaNota { get; set; } = string.Empty;
    public string Motivo { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public List<string> Fechas { get; set; } = new List<string>();
    public List<string> InstalacionesResidencia { get; set; } = new List<string>();
}
