using Microsoft.EntityFrameworkCore;
using ProjectHotel.Data;

var builder = WebApplication.CreateBuilder(args);

string mySqlConnection = builder.Configuration.GetConnectionString("ProjectHotelDbContext");

builder.Services.AddDbContext<ProjectHotelDbContext>(options =>
options.UseMySql(mySqlConnection, ServerVersion.Parse("10.4.28 - MariaDB")));

builder.Services.AddControllersWithViews();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
