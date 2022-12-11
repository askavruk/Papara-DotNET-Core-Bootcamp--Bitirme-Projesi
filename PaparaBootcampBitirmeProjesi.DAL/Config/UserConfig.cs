using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaparaBootcampBitirmeProjesi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.DAL.Config
{
    public class UserConfig : BaseEntityConfig<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasOne(a => a.Apartment).WithOne(a => a.User).HasForeignKey<Apartment>(c => c.Id);

            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.IdentityNumber).IsRequired();

            base.Configure(builder);
        }
    }
}
