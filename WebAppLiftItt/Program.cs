using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using WebAppLiftItt.Data;
using WebAppLiftItt.Models;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();

// Retrieve the connection string named "default" from the configuration
var connectionString = builder.Configuration.GetConnectionString("default");


// Add the AppDbContext to the services with the specified SQL Server connection string
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer(connectionString));

// Configure Identity with custom password policies
builder.Services.AddIdentity<AppUser, IdentityRole>(
    options =>
    {// Set password requirements
        options.Password.RequiredUniqueChars = 0;
        options.Password.RequireUppercase = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireLowercase = false;
    })
    // Use AppDbContext as the storage for Identity
    .AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

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
