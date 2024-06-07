using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Notes.Application;
using Notes.Application.Common.Mappings;
using Notes.Application.Interfaces;
using Notes.Persistence;
using Notes.Persistence.EntityTypeConfigurations;
using Notes.WebAPI.Middleware;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);



builder.Configuration.AddJsonFile("appsettings.json");

builder.Services.AddDbContext<NotesDbContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAutoMapper(config=>
{
config.AddProfile(new AssemblyMappingProfile(Assembly.GetExecutingAssembly()));
config.AddProfile(new AssemblyMappingProfile(typeof(INotesDbContext).Assembly));
});

builder.Services.AddApplication();
builder.Services.AddControllers();
builder.Services.AddPersistence(builder.Configuration);


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
        policy.AllowAnyOrigin();
    });
});

var app = builder.Build();

app.UseCustomExceptionHandler();
app.UseRouting();
app.UseHttpsRedirection();
app.UseCors("AllowAll");


app.UseEndpoints(endpoints=>
{
    endpoints.MapControllers();
});

app.Run();
