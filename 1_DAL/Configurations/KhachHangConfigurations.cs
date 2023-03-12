using _1_DAL.DomainMolder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Configurations
{
    public class KhachHangConfigurations : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.ToTable("KhachHang");
            builder.HasKey(x => x.ID);
           
           
            builder.Property(x=>x.Ho).IsRequired().HasMaxLength(20);
            builder.Property(x => x.TenDem).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Ten).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Poin);
            builder.Property(x=>x.SDT).IsRequired().HasMaxLength(10);
            builder.Property(x => x.GioiTinh).IsRequired();
            builder.Property(x=>x.TrangThai).IsRequired();
            builder.Property(x => x.NgaySinh);
            builder.Property(x => x.DiaChi);
            builder.Property(x => x.ThanhPho);
            builder.Property(x => x.QuocGia);

        }
    }
}
