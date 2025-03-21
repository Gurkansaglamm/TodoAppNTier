
using TodoAppNTier.Business.DependencyResolvers.Microsoft;



var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDependencies();


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
