using Microsoft.EntityFrameworkCore;
using WebApiProject.Models;

namespace WebApiProject.Data;

public class FilmContext : DbContext
{
   
    public DbSet<Filme> Filmes { get; set; }
    public FilmContext(DbContextOptions<FilmContext> options) 
        : base(options)
    {
      
    } 
  

}
