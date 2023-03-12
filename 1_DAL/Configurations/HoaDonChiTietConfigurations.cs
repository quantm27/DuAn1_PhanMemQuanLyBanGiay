﻿using _1_DAL.DomainMolder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Configurations
{
    public class HoaDonChiTietConfigurations : IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.ToTable("HoaDonChiTiet");
            builder.HasKey(x => x.ID);

            builder.Property(x => x.Ma);
            builder.Property(x => x.SoLuong).IsRequired();
            builder.Property(x => x.DonGia).IsRequired();
           
            builder.Property(x => x.TrangThai);
            builder.HasOne(c => c.hoadon).WithMany(b => b.hoadonchitiet).HasForeignKey(c => c.IDHD);
            builder.HasOne(c => c.sanphamchitiet).WithMany(b => b.hoadonchitiet).HasForeignKey(c => c.IDSPCT);

        }
    }
}
