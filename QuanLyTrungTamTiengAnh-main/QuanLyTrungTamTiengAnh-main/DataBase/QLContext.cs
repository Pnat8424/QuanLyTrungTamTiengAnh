using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase;

public partial class QLContext : DbContext
{
    public QLContext()
    {
    }

    public QLContext(DbContextOptions<QLContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BaoCaoHv> BaoCaoHvs { get; set; }

    public virtual DbSet<DGiangVien> DGiangViens { get; set; }

    public virtual DbSet<GhiDanh> GhiDanhs { get; set; }

    public virtual DbSet<HocVien> HocViens { get; set; }

    public virtual DbSet<KhoaHoc> KhoaHocs { get; set; }

    public virtual DbSet<LopHoc> LopHocs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=ADMIN-PC,1433; database=QL_TTTA; user=mannhu; password=mannhu; Trusted_Connection=True; TrustServerCertificate=True ");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BaoCaoHv>(entity =>
        {
            entity.HasKey(e => e.MaBc);

            entity.ToTable("BaoCaoHV");

            entity.Property(e => e.MaBc)
                .ValueGeneratedNever()
                .HasColumnName("MaBC");
            entity.Property(e => e.MaHv).HasColumnName("MaHV");
            entity.Property(e => e.MaKh).HasColumnName("MaKH");
            entity.Property(e => e.TenHv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TenHV");
            entity.Property(e => e.TinhtrangHp)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("TinhtrangHP");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.BaoCaoHvs)
                .HasForeignKey(d => d.MaKh)
                .HasConstraintName("FK_BaoCaoHV_KhoaHoc");
        });

        modelBuilder.Entity<DGiangVien>(entity =>
        {
            entity.HasKey(e => e.MaGv);

            entity.ToTable("D_GiangVien");

            entity.Property(e => e.MaGv).HasColumnName("MaGV");
            entity.Property(e => e.CreatedAt).HasColumnName("Created_at");
            entity.Property(e => e.Gioitinh)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MaLh).HasColumnName("MaLH");
            entity.Property(e => e.Ngaysinh).HasColumnType("date");
            entity.Property(e => e.Sdt)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TenGv).HasColumnName("TenGV");
            entity.Property(e => e.UpdatedAt).HasColumnName("Updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_by");
        });

        modelBuilder.Entity<GhiDanh>(entity =>
        {
            entity.ToTable("GhiDanh");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Gioitinh)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MaHv).HasColumnName("MaHV");
            entity.Property(e => e.Ngaysinh).HasColumnType("datetime");
            entity.Property(e => e.Sdt)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TenHv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TenHV");
            entity.Property(e => e.Trinhdo)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.MaHvNavigation).WithMany(p => p.GhiDanhs)
                .HasForeignKey(d => d.MaHv)
                .HasConstraintName("FK_GhiDanh_HocVien");
        });

        modelBuilder.Entity<HocVien>(entity =>
        {
            entity.HasKey(e => e.MaHv);

            entity.ToTable("HocVien");

            entity.Property(e => e.MaHv)
                .ValueGeneratedNever()
                .HasColumnName("MaHV");
            entity.Property(e => e.Diachi)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gioitinh)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MaLh).HasColumnName("MaLH");
            entity.Property(e => e.Ngaysinh).HasColumnType("datetime");
            entity.Property(e => e.TenHv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TenHV");

            entity.HasOne(d => d.MaLhNavigation).WithMany(p => p.HocViens)
                .HasForeignKey(d => d.MaLh)
                .HasConstraintName("FK_HocVien_LopHoc");
        });

        modelBuilder.Entity<KhoaHoc>(entity =>
        {
            entity.HasKey(e => e.MaKh);

            entity.ToTable("KhoaHoc");

            entity.Property(e => e.MaKh)
                .ValueGeneratedNever()
                .HasColumnName("MaKH");
            entity.Property(e => e.HocPhi).HasColumnType("money");
            entity.Property(e => e.MaGv).HasColumnName("MaGV");
            entity.Property(e => e.NgayBd)
                .HasColumnType("datetime")
                .HasColumnName("NgayBD");
            entity.Property(e => e.NgayKt)
                .HasColumnType("datetime")
                .HasColumnName("NgayKT");
            entity.Property(e => e.TenKh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TenKH");
        });

        modelBuilder.Entity<LopHoc>(entity =>
        {
            entity.HasKey(e => e.MaLh);

            entity.ToTable("LopHoc");

            entity.Property(e => e.MaLh)
                .ValueGeneratedNever()
                .HasColumnName("MaLH");
            entity.Property(e => e.MaGv).HasColumnName("MaGV");
            entity.Property(e => e.MaHv).HasColumnName("MaHV");
            entity.Property(e => e.MaKh).HasColumnName("MaKH");
            entity.Property(e => e.TenLh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TenLH");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.LopHocs)
                .HasForeignKey(d => d.MaKh)
                .HasConstraintName("FK_LopHoc_KhoaHoc");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
