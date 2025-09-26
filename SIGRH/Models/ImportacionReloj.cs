using System;

namespace SIGRH.Models;

public class ImportacionReloj
{
    public string CodigoReloj { get; set; } = string.Empty;
    public string FechaMarca { get; set; } = string.Empty;
    public string Sitio { get; set; } = string.Empty;
    public string Reloj { get; set; } = string.Empty;
    public string TotalRegistros { get; set; } = string.Empty;
    public string RegistrosInsert { get; set; } = string.Empty;
    public string RegistrosExistente { get; set; } = string.Empty;
    public string RegistroAdmInv { get; set; } = string.Empty;
    public string RegistrosPendiente { get; set; } = string.Empty;
}
