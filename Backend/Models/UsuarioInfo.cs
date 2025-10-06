using System;

namespace SIGRH.Models;

public class UsuarioInfo
{
    public string NombreCompleto { get; set; } = string.Empty;
    public string Cedula { get; set; } = string.Empty;
    public string SeguroSocial { get; set; } = string.Empty;
    public string FechaIngreso { get; set; } = string.Empty;
    public string Tratamiento { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public string TiempoTrabajo { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public string CorreoInstitucional { get; set; } = string.Empty;
    public string FechaActualLetra { get; set; } = string.Empty;
    public string NombreAutoridad { get; set; } = string.Empty;
    public string CargoAutoridad { get; set; } = string.Empty;
    public List<UsuarioInfoHorario> UsuarioInformacion { get; set; } = new List<UsuarioInfoHorario>();
}
