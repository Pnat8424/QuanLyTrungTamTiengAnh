using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "D_GiangVien",
                columns: table => new
                {
                    MaGV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenGV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sdt = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Diachi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gioitinh = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Ngaysinh = table.Column<DateTime>(type: "date", nullable: true),
                    Trinhdo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaLH = table.Column<int>(type: "int", nullable: true),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_by = table.Column<int>(type: "int", nullable: true),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_GiangVien", x => x.MaGV);
                });

            migrationBuilder.CreateTable(
                name: "KhoaHoc",
                columns: table => new
                {
                    MaKH = table.Column<int>(type: "int", nullable: false),
                    NgayBD = table.Column<DateTime>(type: "datetime", nullable: true),
                    NgayKT = table.Column<DateTime>(type: "datetime", nullable: true),
                    TenKH = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MaGV = table.Column<int>(type: "int", nullable: true),
                    HocPhi = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoaHoc", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "BaoCaoHV",
                columns: table => new
                {
                    MaBC = table.Column<int>(type: "int", nullable: false),
                    MaHV = table.Column<int>(type: "int", nullable: true),
                    TenHV = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TinhtrangHP = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    MaKH = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaoCaoHV", x => x.MaBC);
                    table.ForeignKey(
                        name: "FK_BaoCaoHV_KhoaHoc",
                        column: x => x.MaKH,
                        principalTable: "KhoaHoc",
                        principalColumn: "MaKH");
                });

            migrationBuilder.CreateTable(
                name: "LopHoc",
                columns: table => new
                {
                    MaLH = table.Column<int>(type: "int", nullable: false),
                    TenLH = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MaHV = table.Column<int>(type: "int", nullable: true),
                    MaGV = table.Column<int>(type: "int", nullable: true),
                    MaKH = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHoc", x => x.MaLH);
                    table.ForeignKey(
                        name: "FK_LopHoc_KhoaHoc",
                        column: x => x.MaKH,
                        principalTable: "KhoaHoc",
                        principalColumn: "MaKH");
                });

            migrationBuilder.CreateTable(
                name: "HocVien",
                columns: table => new
                {
                    MaHV = table.Column<int>(type: "int", nullable: false),
                    TenHV = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Gioitinh = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Ngaysinh = table.Column<DateTime>(type: "datetime", nullable: true),
                    Diachi = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MaLH = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocVien", x => x.MaHV);
                    table.ForeignKey(
                        name: "FK_HocVien_LopHoc",
                        column: x => x.MaLH,
                        principalTable: "LopHoc",
                        principalColumn: "MaLH");
                });

            migrationBuilder.CreateTable(
                name: "GhiDanh",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    MaHV = table.Column<int>(type: "int", nullable: true),
                    TenHV = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Sdt = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ngaysinh = table.Column<DateTime>(type: "datetime", nullable: true),
                    Trinhdo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Gioitinh = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GhiDanh", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GhiDanh_HocVien",
                        column: x => x.MaHV,
                        principalTable: "HocVien",
                        principalColumn: "MaHV");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaoCaoHV_MaKH",
                table: "BaoCaoHV",
                column: "MaKH");

            migrationBuilder.CreateIndex(
                name: "IX_GhiDanh_MaHV",
                table: "GhiDanh",
                column: "MaHV");

            migrationBuilder.CreateIndex(
                name: "IX_HocVien_MaLH",
                table: "HocVien",
                column: "MaLH");

            migrationBuilder.CreateIndex(
                name: "IX_LopHoc_MaKH",
                table: "LopHoc",
                column: "MaKH");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaoCaoHV");

            migrationBuilder.DropTable(
                name: "D_GiangVien");

            migrationBuilder.DropTable(
                name: "GhiDanh");

            migrationBuilder.DropTable(
                name: "HocVien");

            migrationBuilder.DropTable(
                name: "LopHoc");

            migrationBuilder.DropTable(
                name: "KhoaHoc");
        }
    }
}
