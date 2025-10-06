using System;

namespace SIGRH.Models;

public class VacacionSaldo
{
    public int IdVacacionesSaldo { get; set; }
    public int IdPersonal { get; set; }
    public int SaldoCorte { get; set; }
    public DateTime FechaCorte { get; set; }
    public int DiaSaldo { get; set; }
    public bool Inactivo { get; set; }
}
