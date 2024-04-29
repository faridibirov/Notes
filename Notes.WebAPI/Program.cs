using Notes.Application.Common.Mappings;
using Notes.Application.Interfaces;
using Notes.Persistence;
using Notes.Persistence.EntityTypeConfigurations;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;

    try
    {
        var context = serviceProvider.GetRequiredService<NotesDbContext>();
        DbInitializer.Initialize(context);
    }
    catch(Exception ex) 
    {
    }

}

builder.Services.AddAutoMapper(config=>
{
config.AddProfile(new AssemblyMappingProfile(Assembly.GetExecutingAssembly()));
config.AddProfile(new AssemblyMappingProfile(typeof(INotesDbContext).Assembly));
});


builder.Services.AddApplication();
builder.Services.AddPersistence();

app.MapGet("/", () => "Hello World!");

app.Run();
