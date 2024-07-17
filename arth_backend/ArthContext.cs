using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace arth_backend;

public partial class ArthContext : DbContext
{
    public ArthContext()
    {
    }

    public ArthContext(DbContextOptions<ArthContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<GeneralCategory> GeneralCategories { get; set; }

    public virtual DbSet<Tool> Tools { get; set; }

    public virtual DbSet<ToolPhoto> ToolPhotos { get; set; }

    public virtual DbSet<ToolTemplate> ToolTemplates { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-9RTLIH5;Initial Catalog=arth;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__categori__3213E83FD1ED977D");

            entity.ToTable("categories");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.GeneralCategoryId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("general_category_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");

            entity.HasOne(d => d.GeneralCategory).WithMany(p => p.Categories)
                .HasForeignKey(d => d.GeneralCategoryId)
                .HasConstraintName("FK__categorie__gener__5EBF139D");
        });

        modelBuilder.Entity<GeneralCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__general___3213E83F0B8D62FC");

            entity.ToTable("general_categories");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Tool>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tools__3213E83FF21DDEEB");

            entity.ToTable("tools");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.CategoryId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("category_id");
            entity.Property(e => e.Discription)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("discription");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.PricePerDay).HasColumnName("price_per_day");
            entity.Property(e => e.PricePerMonth).HasColumnName("price_per_month");
            entity.Property(e => e.PricePerWeek).HasColumnName("price_per_week");
            entity.Property(e => e.State).HasColumnName("state");

            entity.HasOne(d => d.Category).WithMany(p => p.Tools)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__tools__address__6477ECF3");
        });

        modelBuilder.Entity<ToolPhoto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tool_pho__3213E83FC18607EF");

            entity.ToTable("tool_photos");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.PhotoUrl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("photo_url");
            entity.Property(e => e.ToolId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tool_id");

            entity.HasOne(d => d.Tool).WithMany(p => p.ToolPhotos)
                .HasForeignKey(d => d.ToolId)
                .HasConstraintName("FK__tool_phot__photo__6754599E");
        });

        modelBuilder.Entity<ToolTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tool_tem__3213E83F48F3927C");

            entity.ToTable("tool_templates");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.CategoryId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("category_id");
            entity.Property(e => e.Discription)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("discription");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");

            entity.HasOne(d => d.Category).WithMany(p => p.ToolTemplates)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__tool_temp__discr__619B8048");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__users__3213E83FD45B18CF");

            entity.ToTable("users");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.CreateAt).HasColumnName("create_at");
            entity.Property(e => e.DateOfBirthday).HasColumnName("date_of_birthday");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("login");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.ProfilePictureUrl)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("profile_picture_url");
            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("surname");
            entity.Property(e => e.UpdateAt).HasColumnName("update_at");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
