using System;

namespace SIGRH.Models;

public class SolicitudAccionData
{
    public string IdSolicitudAccion { get; set; } = string.Empty;
    public string Numero { get; set; } = string.Empty;
    public string Fecha { get; set; } = string.Empty;
    public string UnidadNombre { get; set; } = string.Empty;
    public string Firmante { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public string DescripcionSolicitud { get; set; } = string.Empty;
    public string FechaAsignada { get; set; } = string.Empty;
    public string IdPrioridad { get; set; } = string.Empty;
    public string Confidencial { get; set; } = string.Empty;
    public string UrlSolicitud { get; set; } = string.Empty;
    public string Estatus { get; set; } = string.Empty;
    public string IdEstatus { get; set; } = string.Empty;
    public string FechaRegistro { get; set; } = string.Empty;
    public string UsuarioRegistra { get; set; } = string.Empty;
    public string DescripcionTipoEntrada { get; set; } = string.Empty;
    public string PeriodoAcademico { get; set; } = string.Empty;
}
