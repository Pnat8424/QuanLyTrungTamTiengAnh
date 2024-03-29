﻿// <auto-generated />
using System;
using MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.Migrations
{
    [DbContext(typeof(QLContext))]
    [Migration("20240124062327_update2")]
    partial class update2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase.BaoCaoHv", b =>
                {
                    b.Property<int>("MaBc")
                        .HasColumnType("int")
                        .HasColumnName("MaBC");

                    b.Property<int?>("MaHv")
                        .HasColumnType("int")
                        .HasColumnName("MaHV");

                    b.Property<int?>("MaKh")
                        .HasColumnType("int")
                        .HasColumnName("MaKH");

                    b.Property<string>("TenHv")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("TenHV");

                    b.Property<string>("TinhtrangHp")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("TinhtrangHP")
                        .IsFixedLength();

                    b.HasKey("MaBc");

                    b.HasIndex("MaKh");

                    b.ToTable("BaoCaoHV", (string)null);
                });

            modelBuilder.Entity("MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase.DGiangVien", b =>
                {
                    b.Property<int>("MaGv")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MaGV");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaGv"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("Created_at");

                    b.Property<string>("Diachi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gioitinh")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<int?>("MaLh")
                        .HasColumnType("int")
                        .HasColumnName("MaLH");

                    b.Property<DateTime?>("Ngaysinh")
                        .HasColumnType("date");

                    b.Property<string>("Sdt")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TenGv")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TenGV");

                    b.Property<string>("Trinhdo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("Updated_at");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int")
                        .HasColumnName("Updated_by");

                    b.HasKey("MaGv");

                    b.ToTable("D_GiangVien", (string)null);
                });

            modelBuilder.Entity("MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase.GhiDanh", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Gioitinh")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<int?>("MaHv")
                        .HasColumnType("int")
                        .HasColumnName("MaHV");

                    b.Property<DateTime?>("Ngaysinh")
                        .HasColumnType("datetime");

                    b.Property<string>("Sdt")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TenHv")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("TenHV");

                    b.Property<string>("Trinhdo")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.HasIndex("MaHv");

                    b.ToTable("GhiDanh", (string)null);
                });

            modelBuilder.Entity("MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase.HocVien", b =>
                {
                    b.Property<int>("MaHv")
                        .HasColumnType("int")
                        .HasColumnName("MaHV");

                    b.Property<string>("Diachi")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Gioitinh")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<int?>("MaLh")
                        .HasColumnType("int")
                        .HasColumnName("MaLH");

                    b.Property<DateTime?>("Ngaysinh")
                        .HasColumnType("datetime");

                    b.Property<string>("TenHv")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("TenHV");

                    b.HasKey("MaHv");

                    b.HasIndex("MaLh");

                    b.ToTable("HocVien", (string)null);
                });

            modelBuilder.Entity("MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase.KhoaHoc", b =>
                {
                    b.Property<int>("MaKh")
                        .HasColumnType("int")
                        .HasColumnName("MaKH");

                    b.Property<decimal?>("HocPhi")
                        .HasColumnType("money");

                    b.Property<int?>("MaGv")
                        .HasColumnType("int")
                        .HasColumnName("MaGV");

                    b.Property<DateTime?>("NgayBd")
                        .HasColumnType("datetime")
                        .HasColumnName("NgayBD");

                    b.Property<DateTime?>("NgayKt")
                        .HasColumnType("datetime")
                        .HasColumnName("NgayKT");

                    b.Property<string>("TenKh")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("TenKH");

                    b.HasKey("MaKh");

                    b.ToTable("KhoaHoc", (string)null);
                });

            modelBuilder.Entity("MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase.LopHoc", b =>
                {
                    b.Property<int>("MaLh")
                        .HasColumnType("int")
                        .HasColumnName("MaLH");

                    b.Property<int?>("MaGv")
                        .HasColumnType("int")
                        .HasColumnName("MaGV");

                    b.Property<int?>("MaHv")
                        .HasColumnType("int")
                        .HasColumnName("MaHV");

                    b.Property<int?>("MaKh")
                        .HasColumnType("int")
                        .HasColumnName("MaKH");

                    b.Property<string>("TenLh")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("TenLH");

                    b.HasKey("MaLh");

                    b.HasIndex("MaKh");

                    b.ToTable("LopHoc", (string)null);
                });

            modelBuilder.Entity("MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase.BaoCaoHv", b =>
                {
                    b.HasOne("MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase.KhoaHoc", "MaKhNavigation")
                        .WithMany("BaoCaoHvs")
                        .HasForeignKey("MaKh")
                        .HasConstraintName("FK_BaoCaoHV_KhoaHoc");

                    b.Navigation("MaKhNavigation");
                });

            modelBuilder.Entity("MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase.GhiDanh", b =>
                {
                    b.HasOne("MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase.HocVien", "MaHvNavigation")
                        .WithMany("GhiDanhs")
                        .HasForeignKey("MaHv")
                        .HasConstraintName("FK_GhiDanh_HocVien");

                    b.Navigation("MaHvNavigation");
                });

            modelBuilder.Entity("MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase.HocVien", b =>
                {
                    b.HasOne("MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase.LopHoc", "MaLhNavigation")
                        .WithMany("HocViens")
                        .HasForeignKey("MaLh")
                        .HasConstraintName("FK_HocVien_LopHoc");

                    b.Navigation("MaLhNavigation");
                });

            modelBuilder.Entity("MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase.LopHoc", b =>
                {
                    b.HasOne("MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase.KhoaHoc", "MaKhNavigation")
                        .WithMany("LopHocs")
                        .HasForeignKey("MaKh")
                        .HasConstraintName("FK_LopHoc_KhoaHoc");

                    b.Navigation("MaKhNavigation");
                });

            modelBuilder.Entity("MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase.HocVien", b =>
                {
                    b.Navigation("GhiDanhs");
                });

            modelBuilder.Entity("MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase.KhoaHoc", b =>
                {
                    b.Navigation("BaoCaoHvs");

                    b.Navigation("LopHocs");
                });

            modelBuilder.Entity("MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase.LopHoc", b =>
                {
                    b.Navigation("HocViens");
                });
#pragma warning restore 612, 618
        }
    }
}
