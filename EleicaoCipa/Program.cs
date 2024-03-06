using EleicaoCipa.ApplicationService;
using EleicaoCipa.Data;
using EleicaoCipa.Data.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<EleicaoContext>();

// REPOSITORIES
builder.Services.AddScoped<EleicaoRepository>();
builder.Services.AddScoped<CandidatoRepository>();
builder.Services.AddScoped<UsuarioRepository>();

// SERVICES
builder.Services.AddScoped<ApplicationServiceEleicao>();
builder.Services.AddScoped<ApplicationServiceCandidato>();
builder.Services.AddScoped<ApplicationServiceUsuario>();

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
