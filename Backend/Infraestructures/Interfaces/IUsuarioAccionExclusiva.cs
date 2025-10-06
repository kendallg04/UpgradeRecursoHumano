using System;
using SIGRH.Models;
using SIGRH.Models.DTO;

namespace SIGRH.Infraestructures.Interfaces;

public interface IUsuarioAccionExclusiva
{
    Task<List<GrupoUsuarioDTO>?> ObtenerRolUsuarioAsync(LoginDTO request);

    Task<PassUsuarioDB?> ObtenerUsuarioAsync(LoginDTO request);

    Task<string> ObtenerCorreoDeUsuario(int idUser);
}
