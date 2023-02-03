using eTickets.Data;
using eTickets.Data.Seeders;
using eTickets.Data.Services.Implementations;
using eTickets.Data.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Added by Desy : DbContext configuration.
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Services onfigurations : Permettre � AutorsController d'acc�der
// � l'implementation "ActorsService" de l'interface "IActorsService".
builder.Services.AddScoped<IActorsService, ActorsService>();
// End Added by Desy : DbContext configuration.

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


// Seeders
DatabaseSeeder.Seed(app);

app.Run();
