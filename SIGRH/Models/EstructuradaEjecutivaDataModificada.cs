using System;

namespace SIGRH.Models;

public class EstructuradaEjecutivaDataModificada
{
    public int IdEstructuraEjecutivaDetaModifica { get; set; }
    public int CodigoDet { get; set; }
    public int Accion { get; set; }
    public int Anio { get; set; }
    public string ObjetoGasto { get; set; } = string.Empty;
    public int Posicion { get; set; }
    public string Partida { get; set; } = string.Empty;
    public decimal Sueldo1 { get; set; }
    public int Mes1 { get; set; }
    public decimal Sueldo2 { get; set; }
    public int Mes2 { get; set; }
    public decimal Sueldo3 { get; set; }
    public int Mes3 { get; set; }
    public decimal Sueldo4 { get; set; }
    public int Mes4 { get; set; }
    public string Cargo { get; set; } = string.Empty;
    public string CodigoUnidad { get; set; } = string.Empty;
    public string CodigoCargoInterno { get; set; } = string.Empty;
    public int IdEstructuraUso { get; set; }
}
