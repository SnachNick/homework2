
using Microsoft.AspNetCore.Builder;
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
//--builder.Services.AddSwaggerGen();


var app = builder.Build();
var car = app.Services.GetService<ICar>();



var ta = car.GetCarAgeL();
var tc = car.GetCarNameL();
var te = car.GetCarEngineL();

app.Map("/Cars", appM =>
    {
        appM.Run(async context =>
        {
            foreach (var c in tc)
            await context.Response.WriteAsync($"{c} \n");
        });
    });
app.Map("/Engine", appM =>
{
    appM.Run(async context =>
    {
        foreach (var c in te)
            await context.Response.WriteAsync($"{c} \n");
    });
});
app.Map("/CarsAges", appM =>
{
    appM.Run(async context =>
    {
        
        foreach (var c in ta)
            await context.Response.WriteAsync($"{c} \n");
    });
});

/*
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
*/
app.UseHttpsRedirection();

app.UseAuthorization();

//app.MapControllers();


app.Run(async (context) =>
{

    foreach (var c in ta)
        await context.Response.WriteAsync($"{c} \n");
    foreach (var c in tc)
        await context.Response.WriteAsync($"{c} \n");
    foreach (var c in te)
        await context.Response.WriteAsync($"{c} \n");
}
);

app.Run();
