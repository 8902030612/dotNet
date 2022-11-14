using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirstApproachDemo.Models;

public partial class StudentDbContext : DbContext
{
    public StudentDbContext()
    {
    }

    public StudentDbContext(DbContextOptions<StudentDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<StudentTbl> StudentTbls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-KU4EUIB\\SQLEXPRESS;Database=StudentDB;Integrated Security=True;Encrypt = False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudentTbl>(entity =>
        {
            entity.HasKey(e => e.StdId);

            entity.ToTable("StudentTbl");

            entity.Property(e => e.StdId).HasColumnName("Std_id");
            entity.Property(e => e.Course)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
