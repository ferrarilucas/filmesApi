using AutoMapper;
using WebApiProject.Data.Dtos;
using WebApiProject.Models;

namespace WebApiProject.Profiles;

public class EnderecoProfile : Profile
{
  public EnderecoProfile() {
    CreateMap<UpdateEnderecoDto, Endereco>();
    CreateMap<CreateEnderecoDto, Endereco>();
    CreateMap<Endereco, ReadEnderecoDto>();
  }
}
