using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Fall2025_Project3_crthompson10.Data;
using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var configConnectionString = builder.Configuration.GetConnectionString("AzureSqlServerConnection") ?? throw new InvalidOperationException("Connection string 'AzureSqlServerConnection' not found.");
var conStrBuilder = new SqlConnectionStringBuilder(configConnectionString)
{
    Password = builder.Configuration["Db:Password"]
};
string connectionString = conStrBuilder.ConnectionString;

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapRazorPages()
    .WithStaticAssets();

app.Run();