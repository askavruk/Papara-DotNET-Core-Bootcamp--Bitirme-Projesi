using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PaparaBootcampBitirmeProjesi.Core.Entities;
using PaparaBootcampBitirmeProjesi.DAL.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.DAL.Context
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> db) : base(db)
        {

        }

        DbSet<Apartment> Apartments { get; set; }
        DbSet<Vehicle> Vehicles { get; set; }
        DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ApartmentConfig());
            builder.ApplyConfiguration(new UserConfig());
            builder.ApplyConfiguration(new VehicleConfig());

            base.OnModelCreating(builder);  
        }

    }
}
