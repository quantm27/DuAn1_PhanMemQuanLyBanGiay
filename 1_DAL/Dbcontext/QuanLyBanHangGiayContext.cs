﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Configurations;
using _1_DAL.DomainMolder;
using Microsoft.EntityFrameworkCore;
namespace _1_DAL.Dbcontext
{
    public class QuanLyBanHangGiayContext : DbContext
    {
        public QuanLyBanHangGiayContext()
        {
            
        }
        public QuanLyBanHangGiayContext(DbContextOptions<QuanLyBanHangGiayContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NhanVienConfigurations());
            modelBuilder.ApplyConfiguration(new ChucVuConfigurations());
            modelBuilder.ApplyConfiguration(new LoaiSanPhamConfigurations());
            modelBuilder.ApplyConfiguration(new NCCConfigurations());
            modelBuilder.ApplyConfiguration(new HinhThucThanhToanConfigurations());
            modelBuilder.ApplyConfiguration(new HoaDonConfigurations());
            modelBuilder.ApplyConfiguration(new HoaDonChiTietConfigurations());
            modelBuilder.ApplyConfiguration(new KhuyenMaiConfigurations());
            modelBuilder.ApplyConfiguration(new MauSacConfigurations());
            modelBuilder.ApplyConfiguration(new NSXConfigurations());
            modelBuilder.ApplyConfiguration(new SizeConfigurations());
            modelBuilder.ApplyConfiguration(new SanPhamConfigurations());
            modelBuilder.ApplyConfiguration(new SanPhamChiTietConfigurations());
            modelBuilder.ApplyConfiguration(new KhachHangConfigurations());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Data Source=DESKTOP-A9URI7S\SQLEXPRESS;Initial Catalog=DuAn1;Persist Security Info=True; User ID =sa; Password =123456");
        }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set;}
        public virtual DbSet<MauSac> MauSacs { get; set; }
        public virtual DbSet<HinhThucThanhToan> HinhThucThanhToans { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiet { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<SanPhamChiTiet> SanPhamChiTiets { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public virtual DbSet<NSX> NSXs { get; set; }


    }
}
