using System;

namespace SIGRH.Models;

public class ExpedienteANS2
{
    public int IdPersonal { get; set; }
    public string Cedula { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public string Unidad { get; set; } = string.Empty;
    public string Nivel { get; set; } = string.Empty;
    public string TipoAcceso { get; set; } = string.Empty;
    public string CodigoUnidad { get; set; } = string.Empty;
    public int IdUnidadNivel { get; set; }
    public int CodigoAutoridad { get; set; }
    public int? IdUnidad { get; set; }
}
