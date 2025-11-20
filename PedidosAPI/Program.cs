using Microsoft.EntityFrameworkCore;
using PedidosAPI.Core.Aplicacion.Interfaces;
using PedidosAPI.Infeaestructura.Repositorios;
using PedidosAPI.Core.Aplicacion.CasosDeUso;
using PedidosAPI.Configuracion;

var builder = WebApplication.CreateBuilder(args);

// Configuración de PostgreSQL
builder.Services.AddDbContext<PedidosDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registrar Repositorio y Casos de Uso
builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();
builder.Services.AddScoped<CrearPedidoUseCase>();
builder.Services.AddScoped<ObtenerPedidoUseCase>();
builder.Services.AddScoped<ObtenerPedidosUseCase>();
builder.Services.AddScoped<ActualizarPedidoUseCase>();
builder.Services.AddScoped<EliminarPedidoUseCase>();

// Registrar controladores
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization(); 
app.MapControllers();

app.Run();
