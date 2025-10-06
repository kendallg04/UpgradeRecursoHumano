using System;

namespace SIGRH.Models;

public class AprobacionBoletaEnfermedad : AprobacionBoleta
{
    public string IdBoletaEnfermedad { get; set; } = string.Empty;

    public List<MensajeAprobacionJefe> MensajesJefe { get; set; } = new();
}
