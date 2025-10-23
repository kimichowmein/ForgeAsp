using Forge.Application;
using Forge.Web;

var builder = WebApplication.CreateBuilder(args);

builder.AddApplication();
builder.AddWeb();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();