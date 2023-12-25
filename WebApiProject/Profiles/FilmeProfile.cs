using AutoMapper;
using WebApiProject.Data.Dtos;
using WebApiProject.Models;

namespace WebApiProject.Profiles;

public class FilmeProfile : Profile
{
  public FilmeProfile()
  {
    CreateMap<CreateFilmeDto, Filme>();
    CreateMap<UpdateFilmeDto, Filme>();
    CreateMap<Filme, UpdateFilmeDto>();
    CreateMap<Filme, ReadFilmeDto>();
  }
}
