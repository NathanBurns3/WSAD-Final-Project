using Microsoft.EntityFrameworkCore;
using WSAD_Final_Project.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Configuration.AddJsonFile("appsettings.Secrets.json", optional: true);

builder.Services.AddDbContext<HobbyContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HobbyContext")));
builder.Services.AddDbContext<CarsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CarsContext")));
builder.Services.AddDbContext<GamesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GamesContext")));

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

app.Run();
