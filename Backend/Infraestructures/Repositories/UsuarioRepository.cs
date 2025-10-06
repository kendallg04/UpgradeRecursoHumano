using System.Data;
using Dapper;
using Microsoft.Extensions.Options;
using SIGRH.Infraestructures.Interfaces;
using SIGRH.Models;
using SIGRH.Models.DTO;
using SIGRH.Services;

namespace SIGRH.Data;

public class UsuarioRepository : IUsuario
{

    private readonly InfoSqlOptionsDTO _info;

    private readonly IDbConnection _db;

    private readonly UsuarioExclusivoService _accionExclusiva;

    public UsuarioRepository(IOptions<InfoSqlOptionsDTO> info, IDbConnection db, UsuarioExclusivoService accionExclusiva)
    {
        _info = info.Value;
        _db = db;
        _accionExclusiva = accionExclusiva;
    }

    public async Task CrearUsuarioAsync(UserRegistroDTO request, string pagina)
    {
        // BD 0 adm, 1 bd_sipaf
        // using var connection = await _accionExclusiva.CrearConexionPorUsuarioAsync(request, pagina);
        var storedProcedureName = "pas_CrearUsuarioRH";
        var values = new
        {
            idUsuario = request.IdPersonal,
            usuarioDB = request.Cedula,
            password = request.Password,
            idEstamento = request.IdEstamento,
            vigente = 1,
            CambiarContrasena = 1,
            db = _info.Databases[1],
            aplicacion_id = 18,
            tipousuario = 0,
            superusuario = 0,
            observacion = "",
            NoCrear = 0,
            Encry = 2
        };
        await _db.QueryAsync(storedProcedureName, values, commandType: CommandType.StoredProcedure);
    }
}
