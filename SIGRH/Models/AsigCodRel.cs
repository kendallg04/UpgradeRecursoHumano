using System;

namespace SIGRH.Models;

public class AsigCodRel
{
    public int? CodigoReloj { get; set; }
    public string Cedula { get; set; } = string.Empty;
    public int? IdPersonal { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Estamento { get; set; } = string.Empty;
    public string Estatus { get; set; } = string.Empty;
    public string Unidad { get; set; } = string.Empty;
    public int IdUnidadP { get; set; }
    public int? IdRelojPersonal { get; set; }
    public int IdEstamento { get; set; }
    public int IdEstatus { get; set; }
    public int CodUnidad { get; set; }
    public int? Nivel { get; set; }

    //public int CodUni { get; set; }
    //public List<SelectListItem> ConsultaCodR_data { get; set; }
    public int? IdHorario { get; set; }
    //public DateTime Activacion { get; set; }
    //public DateTime Inactivacion { get; set; }
    public string Activacion { get; set; } = string.Empty;
    public string HActivacion { get; set; } = string.Empty;
    public string Inactivacion { get; set; } = string.Empty;
    public string HInactivacion { get; set; } = string.Empty;
    public int IdRelojPersonalDet { get; set; }
    public int IdUnidad { get; set; }
}
