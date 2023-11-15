using Microsoft.EntityFrameworkCore;
using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;
using PaymentSystem.Infrastructure;
using PaymentSystem.Infrastructure.Interfaces;
using PaymentSystem.Services;
using PaymentSystem.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PaymentContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DatabaseConnection")));
builder.Services.AddScoped<IPaymentPersist, PaymentPersist>();
builder.Services.AddScoped<IPaymentService, PaymentService>();

//OpenTelemetry integration with Prometheus
builder.Services.AddOpenTelemetry()
    .ConfigureResource(resource => resource.AddService(serviceName: builder.Environment.ApplicationName))
    .WithMetrics(metrics => metrics.AddAspNetCoreInstrumentation()
    .AddMeter("Microsoft.AspNetCore.Hosting")
    .AddMeter("Microsoft.AspNetCore.Server.Kestrel")
    .AddPrometheusExporter());

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

app.MapPrometheusScrapingEndpoint();

app.Run();
