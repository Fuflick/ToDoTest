using Microsoft.AspNetCore.Connections;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ToDoTest;
using ToDoTest.DAL;
using ToDoTest.DAL.Interfaces;
using ToDoTest.DAL.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ITaskRepository, Taskrepository>();


// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>((options) => options.UseSqlServer("Server=KRAIBEN;Database=ToDoTest;Trusted_Connection=True;Encrypt=False"));

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
    

