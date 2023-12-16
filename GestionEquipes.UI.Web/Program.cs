using GestionEquipes.ApplicationCore.Interfaces;
using GestionEquipes.ApplicationCore.Services;
using GestionEquipes.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Injection de dépendance
builder.Services.AddDbContext<DbContext, GestionEquipesContext>();
builder.Services.AddScoped<IServiceEquipe, ServiceEquipe>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddSingleton<Type>(t => typeof(GenericRepository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();