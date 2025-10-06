using System.Data;
using SIGRH.Data.Repositories;
using SIGRH.Infraestructures.Interfaces;
using SIGRH.Models.DTO;
using SIGRH.Utils.DBFactory;

namespace SIGRH.Services;

public class UsuarioExclusivoService
{
    private readonly IUsuarioAccionExclusiva _usuarioExcl;

    private readonly IDBFactory _connectionFactory;

    public UsuarioExclusivoService(IUsuarioAccionExclusiva usuarioExcRepository, IDBFactory connectionFactory)
    {
        _usuarioExcl = usuarioExcRepository;
        _connectionFactory = connectionFactory;
    }

    public async Task<IDbConnection> CrearConexionPorUsuarioAsync(LoginDTO infoUser, string pagina)
    {
        var usuario = await _usuarioExcl.ObtenerUsuarioAsync(infoUser);

        if (usuario is null)
            throw new ArgumentException("No se encontro informacion de conexion para el usuario");

        return await _connectionFactory.CreateConnection(usuario, pagina);
    }
}
