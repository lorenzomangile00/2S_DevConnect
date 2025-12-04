using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CadastroAluno.Models;

public partial class CadastroAlunoContext : DbContext
{
    public CadastroAlunoContext()
    {
    }

    public CadastroAlunoContext(DbContextOptions<CadastroAlunoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aluno> Alunos { get; set; }

    public virtual DbSet<Frutum> Fruta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=NOTE05-S21\\SQLEXPRESS;User Id=sa; Password=senai@134; Database=CadastroAluno;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aluno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__aluno__3213E83FE970082B");
        });

        modelBuilder.Entity<Frutum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__fruta__3213E83F6A9C9037");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
