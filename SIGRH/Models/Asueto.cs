using System;

namespace SIGRH.Models;

public class Asueto
{
    //busqueda
    public int? Anio { get; set; }
    public int Mes { get; set; }
    public int Dia { get; set; }
    //ddlTipo asueto
    public int? IdTipoAsueto { get; set; }
    //ddlTipo Motivo
    public int? IdMotivoAsueto { get; set; }
    public int IdSede { get; set; }
    //ddlTipo Horario
    public int? IdH1 { get; set; }
    public int? IdH2 { get; set; }
    public int? IdH3 { get; set; }
    public int? IdH4 { get; set; }
    public int? IdH5 { get; set; }
    //Tabla 1
    public int IdDiaAsueto { get; set; }
    public string TipoAsueto { get; set; } = string.Empty;
    public string MotivoAsueto { get; set; } = string.Empty;
    public string FechaHrInicio { get; set; } = string.Empty;
    public string FechaHrFinal { get; set; } = string.Empty;
    public int Parcial { get; set; }
    public string Instalacion { get; set; } = string.Empty;
    public string TipoHorario1 { get; set; } = string.Empty;
    public string TipoHorario2 { get; set; } = string.Empty;
    public string TipoHorario3 { get; set; } = string.Empty;
    public string TipoHorario4 { get; set; } = string.Empty;
    public string TipoHorario5 { get; set; } = string.Empty;
    public string Estatus { get; set; } = string.Empty;
    public int? IdTipoAsueto2 { get; set; }
    public int? IdMotivoAsueto2 { get; set; }
    public int idestatus { get; set; }
    public int IdSede2 { get; set; }
    //---------------tabla motivos
    public string Descripcion { get; set; } = string.Empty;
    public int? Inactivo { get; set; }
    public int? IdMotivoAsueto3 { get; set; }
    public string Descripcion_TM { get; set; } = string.Empty;
    public int? IdTipoMotivo { get; set; }
    public int? IdCargo { get; set; }
    //---------------tabla cargos
    public int? IdMotivoAsuetoC { get; set; }
    public int? IdCargoC { get; set; }
    public string DescripcionC { get; set; } = string.Empty;
    public int? InactivoC { get; set; }
    public int? IdMotivoCargo { get; set; }
}
