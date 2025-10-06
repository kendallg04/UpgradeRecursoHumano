using System.Data;
using Dapper;
using Microsoft.Extensions.Options;
using SIGRH.Infraestructures.Interfaces;
using SIGRH.Models;
using SIGRH.Models.DTO;

namespace SIGRH.Data.Repositories;

public class UsuarioAccionExclusivaRepository : IUsuarioAccionExclusiva
{

    private readonly InfoSqlOptionsDTO _info;

    private readonly IDbConnection _db;

    public UsuarioAccionExclusivaRepository(IOptions<InfoSqlOptionsDTO> info, IDbConnection db)
    {
        _info = info.Value;
        _db = db;
    }

    public async Task<PassUsuarioDB?> ObtenerUsuarioAsync(LoginDTO request)
    {
        var values = new
        {
            idUsuario = 0,
            Cedula = request.Cedula,
            psPass = request.PasswordEncrypted,
            tipo = 0,
            db = _info.Databases[1],
            EvEnCr = 1
        };
        var storedProcedureName = "pas_UsuarioDB";
        var results = await _db.QueryFirstOrDefaultAsync<PassUsuarioDB>(storedProcedureName, values, commandType: CommandType.StoredProcedure);

        return results;
    }

    public async Task<List<GrupoUsuarioDTO>?> ObtenerRolUsuarioAsync(LoginDTO request)
    {
        var storedProcedureName = "pas_ListaGruposUsuario";
        var values = new
        {
            usuario_id = request.IdUsuario
        };
        var results = await _db.QueryAsync<GrupoUsuarioDTO>(storedProcedureName, values, commandType: CommandType.StoredProcedure);

        return results.ToList();
    }

    // public Task<string> ObtenerCorreoDeUsuario(int idUser)
    // {

    // }
}
