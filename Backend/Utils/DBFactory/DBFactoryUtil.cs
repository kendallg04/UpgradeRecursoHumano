using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using SIGRH.Models;
using SIGRH.Models.DTO;

namespace SIGRH.Utils.DBFactory;

public class DBFactoryUtil : IDBFactory
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    private readonly InfoSqlOptionsDTO _options;

    public DBFactoryUtil(IHttpContextAccessor httpContextAccessor, IOptions<InfoSqlOptionsDTO> options)
    {
        _httpContextAccessor = httpContextAccessor;
        _options = options.Value;
    }

    public Task<IDbConnection> CreateConnection(PassUsuarioDB usuarioInfo, string pagina)
    {
        var ip = ObtainIP();
        var connectionString = $"Data source={_options.Servers[0]};Initial Catalog={_options.Databases[0]};User Id={usuarioInfo.usuarioDB};Password={usuarioInfo.password};Connect Timeout=1000;Workstation ID={usuarioInfo.Nombre1} {usuarioInfo.Apellido1}//{ip};Application Name={pagina};TrustServerCertificate=True;";

        IDbConnection connection = new SqlConnection(connectionString);
        connection.Open();
        return Task.FromResult(connection);
    }

    private string ObtainIP()
    {
        var ip = _httpContextAccessor.HttpContext?.Request.Headers["X-Forwarded-For"].FirstOrDefault() ?? _httpContextAccessor.HttpContext?.Connection.RemoteIpAddress?.ToString();
        return ip ?? throw new ArgumentException("No se encontro la IP del usuario.");
    }
}
