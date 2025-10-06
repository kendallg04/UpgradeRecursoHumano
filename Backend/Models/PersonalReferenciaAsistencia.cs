using System;

namespace SIGRH.Models;

public class PersonalReferenciaAsistencia
{
    public int IdPersonalReferencia { get; set; }
    public int IdPersonal { get; set; }
    public int IdEstamento { get; set; }
    public DateTime FechaVacacion { get; set; }
    public DateTime FechaIngreso { get; set; }
    public string Dedicacion { get; set; } = string.Empty;
    public int IdEstatus { get; set; }
}
