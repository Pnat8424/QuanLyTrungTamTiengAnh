using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Core_Quan_Ly_Trung_Tam_TA.Models;
using System.Net;
using Microsoft.Extensions.Options;

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase
{
    public class QLTTTAContext : DbContext
    {
        public QLTTTAContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            if (!optionbuilder.IsConfigured)
            {
                // string sqlConnetionSanbox = $"Data Source={SystemEnv.ServerSanboxAddress}; database={SystemEnv.SanboxDatabaseName}; User Id={SystemEnv.UserNameSanbox}; Password={SystemEnv.PasswordSanbox}; TrustServerCertificate=True";
                string sqlConnetionSanbox = $"Data Source=ADMIN-PC,1433; database=QL_TTTA; User Id=mannhu; Password=mannhu; TrustServerCertificate=True";
                optionbuilder.UseSqlServer(sqlConnetionSanbox);
            }
        }
        public DbSet<GiangVienModels> D_GiangVien { get; set; }
        public DbSet<HocVienModels> D_HocVien { get; set; }
        public DbSet<LopHocModels> D_LopHoc { get; set; }
        public DbSet<KhoaHocModels> D_KhoaHoc { get; set; }
        public DbSet<GhiDanhModels> D_GhiDanh { get; set; }
        public DbSet<BaoCaoHocVienModels> D_BaoCaoHocVien { get; set; }


    }

}
    

