using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[PrimaryKey("IdUsuarioSeguir", "IdUsuarioSeguido")]
[Table("tb_seguidor")]
public partial class TbSeguidor
{
    [Key]
    [Column("id_usuario_seguir")]
    public int IdUsuarioSeguir { get; set; }

    [Key]
    [Column("id_usuario_seguido")]
    public int IdUsuarioSeguido { get; set; }
}
