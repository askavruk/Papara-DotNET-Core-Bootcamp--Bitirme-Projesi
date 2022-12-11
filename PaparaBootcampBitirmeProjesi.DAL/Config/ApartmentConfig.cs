using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaparaBootcampBitirmeProjesi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.DAL.Config
{
    public class ApartmentConfig : BaseEntityConfig<Apartment>
    {
        public override void Configure(EntityTypeBuilder<Apartment> builder)
        {
            builder.Property(x=>x.Resident).IsRequired();
            builder.Property(x=>x.ApartmentNo).IsRequired();
            builder.Property(x=>x.IsFull).IsRequired();
            builder.Property(x=>x.Type).IsRequired();
            builder.Property(x=>x.Block).IsRequired();
            base.Configure(builder);
        }
    }
}
