using System;

namespace SIGRH.Models;

public class ConsultaNotaAvanzadaJustifica
{
    public string IdNotaJustificaFalta { get; set; } = string.Empty;
    public string NumeroNota { get; set; } = string.Empty;
    public string FechaNota { get; set; } = string.Empty;
    public string Autoriza { get; set; } = string.Empty;
    public string FechaInicio { get; set; } = string.Empty;
    public string FechaFinal { get; set; } = string.Empty;
    public string Motivo { get; set; } = string.Empty;
    public string TipoBoleta { get; set; } = string.Empty;
    public string TipoFalta { get; set; } = string.Empty;
    public string Inactivo { get; set; } = string.Empty;
    public string UrlNota { get; set; } = string.Empty;
    public string IdTipoFalta { get; set; } = string.Empty;
    public string IdDocumentoTipo { get; set; } = string.Empty;
    public string IdPersonalAutoriza { get; set; } = string.Empty;
}
