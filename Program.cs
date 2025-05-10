using SupermarketWEB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity; 
namespace SupermarketWEB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            // 1. Agregar el contexto de la base de datos para Identity (usando la conexión existente)
            builder.Services.AddDbContext<SupermarketContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("SupermarketDB"))
            );

            // 2. Agregar los servicios de Identity
            object value = builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false) // Cambié a false para simplificar por ahora
                .AddEntityFrameworkStores<SupermarketContext>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication(); // Habilita la autenticación
            app.UseAuthorization(); // Habilita la autorización

            app.MapRazorPages();

            app.Run();
        }
    }
}
