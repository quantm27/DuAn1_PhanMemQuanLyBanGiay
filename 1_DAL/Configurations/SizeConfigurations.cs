using _1_DAL.DomainMolder;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Configurations
{
    public class SizeConfigurations : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.ToTable("Size");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Ma);
            builder.Property(x => x.Ten).HasMaxLength(200);
            builder.Property(x => x.TrangThai);
            builder.Property(x => x.GhiChu);
        }
    }
}
