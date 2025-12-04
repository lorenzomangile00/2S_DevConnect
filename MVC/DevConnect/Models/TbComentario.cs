using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[Table("tb_comentario")]
public partial class TbComentario
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("texto")]
    [StringLength(255)]
    public string Texto { get; set; } = null!;

    [Column("data_comentario")]
    public DateOnly DataComentario { get; set; }

    [Column("id_usuario")]
    public int? IdUsuario { get; set; }

    [Column("id_postagem")]
    public int? IdPostagem { get; set; }

    [ForeignKey("IdPostagem")]
    [InverseProperty("TbComentarios")]
    public virtual TbPostagem? IdPostagemNavigation { get; set; }

    [ForeignKey("IdUsuario")]
    [InverseProperty("TbComentarios")]
    public virtual TbUsuario? IdUsuarioNavigation { get; set; }
}
