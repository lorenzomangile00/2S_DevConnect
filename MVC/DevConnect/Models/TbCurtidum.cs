using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[PrimaryKey("IdUsuario", "IdPostagem")]
[Table("tb_curtida")]
public partial class TbCurtidum
{
    [Key]
    [Column("id_usuario")]
    public int IdUsuario { get; set; }

    [Key]
    [Column("id_postagem")]
    public int IdPostagem { get; set; }
}
