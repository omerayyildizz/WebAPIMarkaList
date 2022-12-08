using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebAPIMarkaList.Models;

public partial class WebApimarkaListContext : DbContext
{
    public WebApimarkaListContext()
    {
    }

    public WebApimarkaListContext(DbContextOptions<WebApimarkaListContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Model> Models { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WebAPIMarkaList;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>(entity =>
        {
            entity.ToTable("Model");

            entity.Property(e => e.BrandCode).IsUnicode(false);
            entity.Property(e => e.BrandName).IsUnicode(false);
            entity.Property(e => e.BrandType).IsUnicode(false);
            entity.Property(e => e.ModelYear)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Price).IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
