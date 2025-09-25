using System;

namespace SIGRH.Models;

public class ExpedienteAN
{
    public int? IdPersonal { get; set; }
    public string Cedula { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public string NombreB { get; set; } = string.Empty;
    public string Estatus { get; set; } = string.Empty;
    public int? IdEstatus { get; set; }
    public string Unidad { get; set; } = string.Empty;
    public int IdUnidad { get; set; }
    public string Cargo { get; set; } = string.Empty;
    public int IdCargo { get; set; }
    public string UnidadExp { get; set; } = string.Empty;
    public int IdUnidadExp { get; set; }
    public string Nivel { get; set; } = string.Empty;
    public int IdUnidadNivel { get; set; }
    public string Dedicacion { get; set; } = string.Empty;
    public int AsitenciaPerfecta { get; set; }
    public string Estamento { get; set; } = string.Empty;
    public int IdEstamento { get; set; }
    public string TipoExpediente { get; set; } = string.Empty;
    public int IdExpAsistencia { get; set; }
    //------------------------------------------------------------------------------------------------ UNIDAD NIVEL
    public int idunidaddl { get; set; }
    public int nombreddl { get; set; }
    //-------------------------------------TABLA DE NIVELES SECCION 2 
    public int Colaboradores { get; set; }
    public int Autoridades { get; set; }
    public int IdUnidadNivel2 { get; set; }
    public int IdNivel2 { get; set; }
    //--------------------------------------expediente tabla 
    public int IdPersonal2 { get; set; }
    public string Cedula2 { get; set; } = string.Empty;
    public string Nombre2 { get; set; } = string.Empty;
    public string Unidad2 { get; set; } = string.Empty;
    public string Nivel2 { get; set; } = string.Empty;
    public string Estatus2 { get; set; } = string.Empty;
    public string Cargo2 { get; set; } = string.Empty;
    public int? IdUnidad2 { get; set; }
    //public int IdUnidadNivel3 { get; set; }
    public int? IdEstatus2 { get; set; }
    public int IdCargo2 { get; set; }

    //--------------------------------------expediente tabla 
    public int IdPersonal3 { get; set; }
    public string Cedula3 { get; set; } = string.Empty;
    public string Nombre3 { get; set; } = string.Empty;
    public string Unidad3 { get; set; } = string.Empty;
    public string Nivel3 { get; set; } = string.Empty;
    public int? IdUnidad3 { get; set; }
    public int IdUnidadNivel3 { get; set; }
    public int IdAutoridadUnidad { get; set; }
    //------------------------------------------------------------------------------------------------ Autoridad Unidad
    //--------------------------------------Autoridad tabla 1
    public int IdPersonalA { get; set; }
    public string CedulaA { get; set; } = string.Empty;
    public string NombreA { get; set; } = string.Empty;
    public string UnidadA { get; set; } = string.Empty;
    public int IdUnidadA { get; set; }
    public string NivelA { get; set; } = string.Empty;
    public int? IdNivelA { get; set; }
    public string CodigoUnidadA { get; set; } = string.Empty;
    public int CodigoNivelA { get; set; }
    public int Inactivo { get; set; }
    public int IdAutoridadUnidadA { get; set; }
    public int? IdNivelAddl { get; set; }
    public string InactivoDescripcionA { get; set; } = string.Empty;
    public string TipoAutoridadDescripcionA { get; set; } = string.Empty;

    //--------------------------------------Autoridad tabla 2
    public int IdPersonalA2 { get; set; }
    public string CedulaA2 { get; set; } = string.Empty;
    public string NombreA2 { get; set; } = string.Empty;
    public string UnidadA2 { get; set; } = string.Empty;
    public string NivelA2 { get; set; } = string.Empty;
    public string EstatusA2 { get; set; } = string.Empty;
    public string CargoA2 { get; set; } = string.Empty;
    public string CodigoUnidadA2 { get; set; } = string.Empty;
    public int IdUnidadNivelA2 { get; set; }
    public int IdEstatusA2 { get; set; }
    public int CodigoNivelA2 { get; set; }
    public string CodigoCargoA2 { get; set; } = string.Empty;
    public string TipoAutoridad { get; set; } = string.Empty;
}
