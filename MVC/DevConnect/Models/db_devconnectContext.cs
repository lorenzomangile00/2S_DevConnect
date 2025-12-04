using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

public partial class db_devconnectContext : DbContext
{

    
    public db_devconnectContext()
    {
    }

    public db_devconnectContext(DbContextOptions<db_devconnectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbComentario> TbComentarios { get; set; }

    public virtual DbSet<TbCurtidum> TbCurtida { get; set; }

    public virtual DbSet<TbPostagem> TbPostagems { get; set; }

    public virtual DbSet<TbSeguidor> TbSeguidors { get; set; }

    public virtual DbSet<TbUsuario> TbUsuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=NOTE05-S21\\SQLEXPRESS;User Id=sa; Password=senai@134; Database=db_devconnect;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbComentario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_comen__3213E83FDDB432A8");

            entity.HasOne(d => d.IdPostagemNavigation).WithMany(p => p.TbComentarios).HasConstraintName("FK__tb_coment__id_po__52593CB8");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbComentarios).HasConstraintName("FK__tb_coment__id_us__5165187F");
        });

        modelBuilder.Entity<TbCurtidum>(entity =>
        {
            entity.HasKey(e => new { e.IdUsuario, e.IdPostagem }).HasName("PK__tb_curti__D3BA5D9B8DDBFCAD");
        });

        modelBuilder.Entity<TbPostagem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_posta__3213E83FB63C273B");
        });

        modelBuilder.Entity<TbSeguidor>(entity =>
        {
            entity.HasKey(e => new { e.IdUsuarioSeguir, e.IdUsuarioSeguido }).HasName("PK__tb_segui__EFA87AC12886B522");
        });

        modelBuilder.Entity<TbUsuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_usuar__3213E83FAB0AA864");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
