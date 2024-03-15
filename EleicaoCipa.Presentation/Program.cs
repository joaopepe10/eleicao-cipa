using EleicaoCipa.Infrastructure.Data;
using EleicaoCipa.Infreastruture.CrossCutting.IOC;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<EleicaoContext>();

builder.Services.RegisteModule();

var connectionString = builder.Configuration.GetConnectionString("EleicaoConnection");
builder.Services.AddDbContext<EleicaoContext>(opts =>
                                              opts
                                              .UseLazyLoadingProxies()
                                              .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.
    AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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