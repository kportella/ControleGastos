using Infraestrutura.Data;
using Infraestrutura.Implementacoes;
using Infraestrutura.Interfaces;
using Microsoft.EntityFrameworkCore;
using Servicos;
using Servicos.Implementacoes;
using Servicos.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ControleGastosDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ControleGastosConnectionString")));
builder.Services.AddAutoMapper(typeof(Mapeamentos));
builder.Services.AddScoped<ITransacaoServico, TransacaoServico>();
builder.Services.AddScoped<ITransacaoRepositorio, TransacaoRepositorio>();
builder.Services.AddScoped<ICategoriaServico, CategoriaServico>();
builder.Services.AddScoped<ICategoriaRepositorio, CategoriaRepositorio>();

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
