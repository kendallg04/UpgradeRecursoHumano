using System;

namespace SIGRH.Models;

public class Menu
{
    public int AplicacionId { get; set; }
    public string NombreApp { get; set; } = string.Empty;
    public int OpcionId { get; set; }
    public string NombreOpcion { get; set; } = string.Empty;
    public bool AccesoSn { get; set; }
    public int IdOpcionPadre { get; set; }
    public int TipoOpcDoc { get; set; }
    public int Prederterminado { get; set; }
    public string Url { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public int Orden { get; set; }
}
