
using NCars.Classes;
using System;
using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers();
//builder.Services.Add(new ServiceDescriptor(typeof(ICar), Car, ServiceLifetime.Transient));
builder.Services.AddTransient<ICar, CarControl>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();
var car = app.Services.GetService<ICar>();

app.Map("/Cars", appM =>
    {
        appM.Run(async context =>
        {
            var tc = car.GetCarNameL();
            foreach (var c in tc)
                await context.Response.WriteAsync($"{c} \n");
        });
    });
app.Map("/Engine", appM =>
{
    appM.Run(async context =>
    {
        var tc = car.GetCarEngineL();
        foreach (var c in tc)
            await context.Response.WriteAsync($"{c} \n");
    });
});
app.Map("/CarsAges", appM =>
{
    appM.Run(async context =>
    {
        var tc = car.GetCarAgeL();
        foreach (var c in tc)
            await context.Response.WriteAsync($"{c} \n");
    });
});


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
