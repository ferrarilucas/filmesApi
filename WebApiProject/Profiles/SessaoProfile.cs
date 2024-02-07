using AutoMapper;
using WebApiProject.Data.Dtos;
using WebApiProject.Models;

namespace WebApiProject.Profiles;

public class SessaoProfile: Profile
{
    public SessaoProfile()
    {
        CreateMap<CreateSessaoDto, Sessao>();
        CreateMap<Sessao, ReadSessaoDto>().ForMember(Sessao => Sessao.Filme,
            op => op.MapFrom(sessao => sessao.Filme))
            .ForMember(Sessao => Sessao.Cinema,
                op => op.MapFrom(sessao => sessao.Cinema));
        
    }
}