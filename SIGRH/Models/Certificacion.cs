using System;
using System.ComponentModel.DataAnnotations;

namespace SIGRH.Models;

public class Certificacion
{
    public int IdCertificacion { get; set; }
    public int IdPersonal { get; set; }
    public int IdCargo { get; set; }
    public int IdUnidad { get; set; }

    [Display(Name = "Tipo")]
    [Range(1, int.MaxValue, ErrorMessage = "Debe de escoger el tipo de documento")]
    public int IdDocumentoTipo { get; set; }

    public int IdPersonalRegistra { get; set; }
    public int IdPersonalProceso { get; set; }

    [Display(Name = "Estatus")]
    public int IdEstatus { get; set; }

    public int IdCodigoHorario { get; set; }
    public DateTime FechaRegistra { get; set; } = DateTime.Now;
    public DateTime FechaEmision { get; set; }
    public string ObservacionColaborador { get; set; } = string.Empty;
    public DateTime FechaProcesada { get; set; }
    public string ObservacionTramitado { get; set; } = string.Empty;

    [Required(ErrorMessage = "Coloque a quien dirige")]
    [Display(Name = "Dirigida")]
    public string Dirigida { get; set; } = "A QUIEN CONCIERNE";

    public string Url { get; set; } = string.Empty;
}
