using APIAssesment.MappingClasses;
using APIAssesment.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.EndPointDefinitions(typeof (IEndpointDefinition));
var app = builder.Build();
app.UseEndpointDefinitions();
app.Run();





