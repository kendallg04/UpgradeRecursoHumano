using System;
using System.Data;
using SIGRH.Models;

namespace SIGRH.Utils.DBFactory;

public interface IDBFactory
{
    Task<IDbConnection> CreateConnection(PassUsuarioDB usuarioInfo, string pagina);
}
