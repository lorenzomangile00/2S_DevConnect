using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CadastroAluno.Models;

[Table("aluno")]
public partial class Aluno
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string NomeAluno { get; set; } = null!;

    public int Idade { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Curso { get; set; } = null!;

    
    public int Turma { get; set; }
}
