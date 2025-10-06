using System;

namespace SIGRH.Models;

public class SaldoDerechoVacacion
{
    public int IdDerechoVacaciones { get; set; }
    public int IdPersonal { get; set; }
    public int IdDocumentoTipo { get; set; }
    public string NumeroDocumento { get; set; } = string.Empty;
    public DateTime FechaDocumento { get; set; }
    public int DiasReferencia { get; set; }
    public int DiasSaldo { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFinal { get; set; }
    public DateTime FechaApartir { get; set; }
    public int IdCargo { get; set; }
    public int IdUnidad { get; set; }
    public string UrlDerecho { get; set; } = string.Empty;
    public int IdEstatus { get; set; }
    public string Observacion { get; set; } = string.Empty;
    public bool AplicadoSaldo { get; set; }
}
