using System;

namespace SIGRH.Models;

public class TiempoSaldo
{
    public int IdTiempoSaldo { get; set; }
    public int IdPersonal { get; set; }
    public int SaldoCorteMin { get; set; }
    public int SaldoMin { get; set; }
    public DateTime Jornada { get; set; }
    public DateTime FechaCorte { get; set; }
    public bool Inactivo { get; set; }
    public int JornadaHora { get; set; }
}
