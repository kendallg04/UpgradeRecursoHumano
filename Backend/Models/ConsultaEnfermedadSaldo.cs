using System;

namespace SIGRH.Models;

public class ConsultaEnfermedadSaldo
{
    public string IdEnfermedadSaldo { get; set; } = string.Empty;
    public string Cedula { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public string Periodo { get; set; } = string.Empty;
    public string SaldoReferencia { get; set; } = string.Empty;
    public string Saldo { get; set; } = string.Empty;
    public string Jornada { get; set; } = string.Empty;
    public string Id_personal { get; set; } = string.Empty;
    public string FechaCorte { get; set; } = string.Empty;
    public string Inactivo { get; set; } = string.Empty;
    public string SaldoAdicionalMin { get; set; } = string.Empty;
    public string FechaVencimiento { get; set; } = string.Empty;
}
