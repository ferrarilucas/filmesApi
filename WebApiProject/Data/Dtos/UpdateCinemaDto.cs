using System.ComponentModel.DataAnnotations;

namespace WebApiProject.Data.Dtos;

public class UpdateCinemaDto
{
  [Required(ErrorMessage = "O campo de nome é obrigatório.")]
  public string Nome { get; set; }
}
