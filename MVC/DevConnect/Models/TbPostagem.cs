using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[Table("tb_postagem")]
public partial class TbPostagem
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("descricao")]
    [StringLength(255)]
    public string Descricao { get; set; } = null!;

    [Column("imagem_url")]
    [StringLength(150)]
    public string? ImagemUrl { get; set; }

    [Column("data_postagem")]
    public DateOnly DataPostagem { get; set; }

    [Column("id_usuario")]
    public int IdUsuario { get; set; }

    [InverseProperty("IdPostagemNavigation")]
    public virtual ICollection<TbComentario> TbComentarios { get; set; } = new List<TbComentario>();
}
