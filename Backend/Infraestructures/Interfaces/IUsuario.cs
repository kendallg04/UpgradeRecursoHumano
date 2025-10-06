using System;
using SIGRH.Models.DTO;

namespace SIGRH.Infraestructures.Interfaces;

public interface IUsuario
{
    Task CrearUsuarioAsync(UserRegistroDTO request, string pagina);
}
