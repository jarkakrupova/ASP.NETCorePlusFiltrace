using ASP.NET_Core_11_23.Models;
using ASP.NET_Core_11_23.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_11_23 {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolDbConnection")));
            //builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("AspifyDbConnection")));
            //builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SomeeDbConnection")));
            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MonsterAspDbConnection")));
            //builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("AzureExperimentalExternalMonsterAspConnection")));

            builder.Services.AddScoped<StudentService>();
            builder.Services.AddScoped<SubjectService>();
            builder.Services.AddScoped<GradesService>();
            builder.Services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
            builder.Services.Configure<IdentityOptions>(opts => {
                opts.Password.RequiredLength = 8;
                opts.Password.RequireLowercase = true;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireDigit = false;
            });
            builder.Services.ConfigureApplicationCookie(options => {
                options.Cookie.Name = ".AspNetCore.Identity.Application";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
                options.SlidingExpiration = true;
            });
            //povoleni CORS
            var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
            builder.Services.AddCors(options => {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  policy => {
                                      policy
                                      .AllowAnyOrigin()
                                      .AllowAnyMethod()
                                      .AllowAnyHeader();
                                  });
            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment()) {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseDeveloperExceptionPage();
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            //kvuli CORS
            app.UseCors(MyAllowSpecificOrigins);

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}