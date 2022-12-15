using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaparaBootcampBitirmeProjesi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.DAL.Config
{
    public class MessageConfig : BaseEntityConfig<Message>
    {
        public override void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.Property(x => x.MessageContent).IsRequired();
            builder.Property(x => x.SenderMail).IsRequired();
            builder.Property(x => x.RecevierMail).IsRequired();

            base.Configure(builder);
        }
    }
}
