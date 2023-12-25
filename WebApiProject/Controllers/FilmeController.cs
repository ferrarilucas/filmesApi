using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using WebApiProject.Data;
using WebApiProject.Data.Dtos;
using WebApiProject.Models;

namespace WebApiProject.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
  private FilmContext _context;
  private IMapper _mapper;
  public FilmeController(FilmContext context, IMapper mapper) {
    _context = context;
    _mapper = mapper;
  }
  /// <summary>
  ///   Adiciona um filme ao banco de dados
  /// </summary>
  /// <param name="filmeDto">Objeto com os campos necessário para criação de um FILME</param>
  /// <returns code="201">
  ///   Caso a inserção tenha sido feita com sucesso
  /// </returns>
  [HttpPost]
  public IActionResult adicionaFilme([FromBody] CreateFilmeDto filmeDto) {
   
    Filme filme = _mapper.Map<Filme>(filmeDto);
    _context.Filmes.Add(filme);
    _context.SaveChanges();
     return CreatedAtAction(nameof(recuperaFilmePorId), new { Id = filme.Id }, filme);
  }

  [HttpGet]
  public IEnumerable<ReadFilmeDto> recuperaFilmes([FromQuery]int skip = 0, [FromQuery]int take = 50) {
    return _mapper.Map<List<ReadFilmeDto>>(_context.Filmes.Skip(skip).Take(take));
  }

  [HttpGet("{id}")]
  public IActionResult recuperaFilmePorId(int id) {
    var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
     if(filme == null) {
        return NotFound();
     }
     var filmeDto = _mapper.Map<ReadFilmeDto>(filme);
     return Ok(filmeDto);
     
  }

  [HttpPut("{id}")]
  public IActionResult atualizaFilme(int id, [FromBody] UpdateFilmeDto filmeDto) {
    var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
     if(filme == null) {
        return NotFound();
     }
     _mapper.Map(filmeDto, filme);
     _context.SaveChanges();
     return NoContent();
  }

  [HttpPatch("{id}")]
   public IActionResult atualizaFilmeParcial(int id, JsonPatchDocument<UpdateFilmeDto> patch) {
    var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
     if(filme == null) {
        return NotFound();
     }

     var filmePraAtualizar = _mapper.Map<UpdateFilmeDto>(filme);
      patch.ApplyTo(filmePraAtualizar, ModelState);

      if(!TryValidateModel(filmePraAtualizar)) {
        return ValidationProblem(ModelState);
      }

     _mapper.Map(filmePraAtualizar, filme);
     _context.SaveChanges();
     return NoContent();
  }                                                                 

  [HttpDelete("{id}")]
  public IActionResult deletaFilme(int id) {
    var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
     if(filme == null) {
        return NotFound();
     }
     _context.Remove(filme);
     _context.SaveChanges();
     return NoContent();
  }
}
