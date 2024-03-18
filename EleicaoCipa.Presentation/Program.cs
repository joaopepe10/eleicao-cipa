using EleicaoCipa.Infraestrutura.Data;
using Microsoft.EntityFrameworkCore;
using EleicaoCipa.Infraestrutura.CrossCutting.IOC;
using EleicaoCipa.Infraestrutura.CrossCutting.Adapter.Map.Profiles;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(map => map.AddMaps(typeof(CandidatoProfile)));

builder.Services.RegisteModule();

var connectionString = builder.Configuration.GetConnectionString("EleicaoConnection");
builder.Services.AddDbContext<EleicaoContext>(opts =>
                                              opts
                                              .UseLazyLoadingProxies()
                                              .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));


// Add services to the container.
builder.Services.AddControllers().AddNewtonsoftJson();

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