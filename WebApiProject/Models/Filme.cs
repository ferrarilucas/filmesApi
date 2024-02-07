﻿using System.ComponentModel.DataAnnotations;

namespace WebApiProject.Models;

public class Filme
{
    [Required]
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage ="O titulo do filme é obrigatório")]
    public string Titulo { get; set; }
    
    [Required(ErrorMessage ="O Genero do filme é obrigatório")]
    [MaxLength(50, ErrorMessage ="O tamanho do genero não pode exceder 50 Caracteres")]
    public string Genero { get; set; }
    
    [Required(ErrorMessage ="A duração do filme é obrigatório")]
    [Range(70, 600, ErrorMessage =" A duração deve ter entre 70 e 600 minutos")]
    public int Duracao { get; set; }
    
    public virtual ICollection<Sessao> Sessoes { get; set; }
}
