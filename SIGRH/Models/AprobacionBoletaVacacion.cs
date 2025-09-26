using System;

namespace SIGRH.Models;

public class AprobacionBoletaVacacion : AprobacionBoleta
{
    public string IdBoletaVacacion { get; set; } = string.Empty;
    public List<MensajeAprobacionJefe> MensajesJefe { get; set; } = new();
}
