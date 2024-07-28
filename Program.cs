using Microsoft.EntityFrameworkCore;
using SandwichApp.Context;
using SandwichApp.Repositories;
using SandwichApp.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var MySql = builder.Configuration.GetConnectionString("MySQLConnections");
builder.Services.AddDbContext<SandwichContext>(options => options.UseMySql(MySql, ServerVersion.AutoDetect(MySql)));
builder.Services.AddTransient<ISandwichRepository, SandwichRepository>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddMemoryCache();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddSession();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
