using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PaparaBootcampBitirmeProjesi.BLL.AutoMapper;
using PaparaBootcampBitirmeProjesi.BLL.EmailSender;
using PaparaBootcampBitirmeProjesi.BLL.Services.AdminService;
using PaparaBootcampBitirmeProjesi.BLL.Services.MessageService;
using PaparaBootcampBitirmeProjesi.Core.Entities;
using PaparaBootcampBitirmeProjesi.Core.IRepositories;
using PaparaBootcampBitirmeProjesi.DAL.Context;
using PaparaBootcampBitirmeProjesi.DAL.Repositories;

namespace PaparaBootcampBitirmeProjesi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<Startup>());

            //DbContext
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("ConStrings"));
            });

            //Identity
            services.AddIdentity<User, IdentityRole>(option =>
            {
                option.SignIn.RequireConfirmedEmail = false;
                option.SignIn.RequireConfirmedPhoneNumber = false;
                option.SignIn.RequireConfirmedAccount = false;
                option.User.RequireUniqueEmail = true;
                option.Password.RequireUppercase = false;
                option.Password.RequiredLength = 3;
                option.Password.RequireNonAlphanumeric = false;
                option.Password.RequireLowercase = false;
            }).AddEntityFrameworkStores<AppDbContext>();

            //repositories
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IApartmentRepository, ApartmentRepository>();
            services.AddTransient<IMessageRepository, MessageRepository>();

            //services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IMessageService, MessageService>();

            //Mapper
            services.AddAutoMapper(typeof(Mapping));


            //emailSender
            services.AddSingleton<IEmailSender, EmailSender>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            //app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Account}/{action=Login}/{id?}");
            });
        }
    }
}
