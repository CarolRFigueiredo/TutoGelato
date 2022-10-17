using TutoGelato.Borders.Repositories;
using TutoGelato.Borders.UseCases;
using TutoGelato.Repositories;
using TutoGelato.UseCases;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICriarSorveteUseCase, CriarSorveteUseCase>();
builder.Services.AddScoped<IBuscarSorveteUseCase, BuscarSorveteUseCase>();
builder.Services.AddScoped<IListarSorvetesUseCase, ListarSorvetesUseCase>();

builder.Services.AddSingleton<ISorveteRepository, SorveteRepository>();

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
