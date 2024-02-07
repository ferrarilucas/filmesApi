using System.ComponentModel.DataAnnotations;

namespace WebApiProject.Models;

public class Endereco
{

  [Key]
  [Required]
  public int Id { get; set; }
  [Required(ErrorMessage = "O campo de logradouro é obrigatório.")]
  public string Logradouro { get; set; }
  public int Numero { get; set; }
  public string Complemento { get; set; }

  [Required(ErrorMessage = "O campo de bairro é obrigatório.")]
  public string Bairro { get; set; }

  [Required(ErrorMessage = "O campo de cidade é obrigatório.")]
  public string Cidade { get; set; }

  [Required(ErrorMessage = "O campo de estado é obrigatório.")]
  public string Estado { get; set; }

  [Required(ErrorMessage = "O campo de CEP é obrigatório.")]
  public int Cep { get; set; }
  public virtual Cinema Cinema { get; set; }

}
