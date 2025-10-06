using System;

namespace SIGRH.Models;

public class AprobacionBoletaTiempo : AprobacionBoleta
{
    public string IdBoletaTiempo { get; set; } = string.Empty;
    public List<MensajeAprobacionJefe> MensajesJefe { get; set; } = new();
}
