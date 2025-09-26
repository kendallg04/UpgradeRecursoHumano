using System;

namespace SIGRH.Models;

public class ConsultaTiempoSaldo
{
    public string IdTiempoSaldo { get; set; } = string.Empty;
    public string Cedula { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public string SaldoReferencia { get; set; } = string.Empty;
    public string Saldo { get; set; } = string.Empty;
    public string Jornada { get; set; } = string.Empty;
    public string IdPersonal { get; set; } = string.Empty;
    public string FechaCorte { get; set; } = string.Empty;
    public string Inactivo { get; set; } = string.Empty;
}
