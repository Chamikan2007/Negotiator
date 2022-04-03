using Negotiator.Extensions;
using Negotiator.TestWebAPI.Contracts;
using Negotiator.TestWebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddNegotiator();

builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>()
    .AddScoped<IWeatherForecastService_GetForecasts_GetSummaryStates_Request, WeatherForecastService_GetForecasts_GetSummaryStates_Request> ();

builder.Services.AddScoped<IWeatherStatesService, WeatherStatesService>();

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
