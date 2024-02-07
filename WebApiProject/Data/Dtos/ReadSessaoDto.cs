using WebApiProject.Models;

namespace WebApiProject.Data.Dtos;

public class ReadSessaoDto
{
    public int Id { get; set; }
    public ReadFilmeDto Filme { get; set; }
    public ReadCinemaDto Cinema { get; set; }
    
}