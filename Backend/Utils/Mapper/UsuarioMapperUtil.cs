using System;
using AutoMapper;
using SIGRH.Models;
using SIGRH.Models.DTO;
using SIGRH.Models.DTO.Response;

namespace SIGRH.Utils.Mapper;

public class UsuarioMapperUtil : Profile
{
    public UsuarioMapperUtil()
    {
        CreateMap<GrupoUsuarioDTO, string>().ConvertUsing(src => src.Grupo);

        CreateMap<PassUsuarioDB, UserResponse>()
        .ForMember(dest => dest.Correo, opt => opt.MapFrom(src => src.CorreoElectronico))
        .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre1))
        .ForMember(dest => dest.Apellido, opt => opt.MapFrom(src => src.Apellido1));

        CreateMap<TokenDTO, TokenResponse>()
        .ForMember(dest => dest.Token, opt => opt.MapFrom(src => src.Token))
        .ForMember(dest => dest.ExpiraInSegundos, opt => opt.MapFrom(src => src.ExpiraInSegundos));
    }
}
