using AutoMapper;
using WebApiProject.Data.Dtos;
using WebApiProject.Models;

namespace WebApiProject.Profiles;

public class CinemaProfile : Profile
{
  public CinemaProfile() {
    CreateMap<CreateCinemaDto, Cinema>();
    CreateMap<Cinema, ReadCinemaDto>().ForMember(cinemaDto => cinemaDto.Endereco,
      opt=>opt.MapFrom(cinema => cinema.Endereco ));
    CreateMap<UpdateCinemaDto, Cinema>();
  }
}