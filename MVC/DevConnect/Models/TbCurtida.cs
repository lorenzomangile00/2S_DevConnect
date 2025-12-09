using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[PrimaryKey("IdUsuario", "IdPostagem")]
[Table("tb_curtida")]
[Index("IdUsuario", "IdPostagem", Name = "UQ__tb_curti__D3BA5D9AC2DBD4FF", IsUnique = true)]
public partial class TbCurtida
{
    [Key]
    [Column("id_usuario")]
    public int IdUsuario { get; set; }

    [Key]
    [Column("id_postagem")]
    public int IdPostagem { get; set; }
}
