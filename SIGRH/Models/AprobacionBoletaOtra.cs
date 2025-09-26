using System;

namespace SIGRH.Models;

public class AprobacionBoletaOtra : AprobacionBoleta
{
    public string IdBoletaOtra { get; set; } = string.Empty;
    public List<MensajeAprobacionJefe> MensajesJefe { get; set; } = new();
}
