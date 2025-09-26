using System;

namespace SIGRH.Models;

public class ConsultaMarcacionPersonal
{
    public string CodigoReloj { get; set; } = string.Empty;
    public string IdPersonal { get; set; } = string.Empty;
    public string IdHorario { get; set; } = string.Empty;
    public string IdUnidad { get; set; } = string.Empty;
    public string HrEntrada { get; set; } = string.Empty;
    public string HrSalida { get; set; } = string.Empty;
    public string Ndia { get; set; } = string.Empty;
    public string Fecha { get; set; } = string.Empty;
}
