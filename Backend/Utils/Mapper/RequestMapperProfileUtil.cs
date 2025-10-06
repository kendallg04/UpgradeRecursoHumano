using System;
using AutoMapper;
using SIGRH.Models.DTO;
using SIGRH.Models.DTO.Request;

namespace SIGRH.Utils.Mapper;

public class RequestMapperProfileUtil : Profile
{
    public RequestMapperProfileUtil()
    {
        CreateMap<UserLoginRequest, LoginDTO>()
        .ForMember(dest => dest.Cedula, opt => opt.MapFrom(src => src.Cedula));

        CreateMap<UserRegistroRequest, UserRegistroDTO>();
    }
}
