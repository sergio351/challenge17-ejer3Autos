using Challenge17_Ejer3.Data;
using Challenge17_Ejer3.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
//ConexionSql
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSQL"));
});
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "MiApi", Version = "v1" });
    var xmlfile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlpath = Path.Combine(AppContext.BaseDirectory, xmlfile);
    options.IncludeXmlComments(xmlpath);
});
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
