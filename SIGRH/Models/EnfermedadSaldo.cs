using System;

namespace SIGRH.Models;

public class EnfermedadSaldo
{
    public int IdEnfermdadSaldo { get; set; }
    public int IdPersonal { get; set; }
    public int SaldoCorteMin { get; set; }
    public int SaldoMin { get; set; }
    public DateTime Jornada { get; set; }
    public DateTime FechaCorte { get; set; }
    public int Periodo { get; set; }
    public bool Inactivo { get; set; }
    public DateTime FechaVencimiento { get; set; }
    public int SaldoAdicionalMin { get; set; }
    public int JornadaHora { get; set; }
}
