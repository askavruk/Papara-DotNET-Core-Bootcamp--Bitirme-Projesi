using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PaparaBootcampBitirmeProjesi.Core.Entities;
using PaparaBootcampBitirmeProjesi.Core.Enums;
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

            //Admin
            User user = new User();
            user.Id = "9a0d3776-5392-456c-8f81-42a1811d5129";
            user.UserName = "admin";
            user.FirstName = "Asena";
            user.LastName = "Kavruk";
            user.SecondName = "Sevnur";
            user.IdentityNumber = "12341231257";
            user.PhoneNumber = "5555555555";
            user.Apartment.ApartmentNo = 0;
            user.CreationDate = DateTime.Now;
            user.Status = Status.Active;
            user.UpdateDate = null;
            user.Email = "asenasulun@gmail.com";
            user.NormalizedEmail = "ASENASULUN@GMAIL.COM";
            user.PhoneNumberConfirmed = false;
            user.EmailConfirmed = false;
            user.NormalizedUserName = "ADMIN";
            user.TwoFactorEnabled = false;
            user.LockoutEnabled = true;
            user.AccessFailedCount = 0;

            
            builder.Entity<User>().HasData(user);
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "8da8ad13-b14a-458b-9b29-b07015c3b3d0", Name = "Admin", NormalizedName = "ADMIN" });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "User", NormalizedName = "USER" });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "8da8ad13-b14a-458b-9b29-b07015c3b3d0",
                    UserId = "9a0d3776-5392-456c-8f81-42a1811d5129"
                }
            );

            base.OnModelCreating(builder);  
        }

    }
}
