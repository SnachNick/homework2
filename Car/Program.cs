using Microsoft.AspNetCore.Http;
using NewCars;
public void ConfigureServices(IServiceCollection services) => services.Add(new ServiceDescriptor(typeof(ICar), Cars))


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
//builder.Services.AddTransient<ICar, Cars>();
builder.Services.Add(new ServiceDescriptor(typeof(ICar), Cars));//Transient<ICar, Car>();
var app = builder.Build();
app.Run(async context =>
{
    var name = app.Services.GetService<ICar>();
    await context.Response.WriteAsync(name.GetCarName());
}

    );

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
var _cars = new Cars("Rivian", "R1T", "Electric", "Automatic Transmission", "2023/01");
/*
private static readonly Cars car2 = new Cars("Tesla", "Model Y", "Electric", "Automatic Transmission", "2021/12");
private static readonly Cars car3 = new Cars("VW", "Taureg", "Disel", "Automatic Transmission", "2019/01");
private static readonly Cars car4 = new Cars("Pontiac", "Solstice", "Gas", "Automatic Transmission", "2008/03");
private static readonly Cars car5 = new Cars("ZAZ", "Tavria", "Gas", "Manual Transmission", "2005/01");
private static readonly Cars car6 = new Cars("Toyota", "Camry", "Gas", "Automatic Transmission", "2017/04");
private static readonly Cars car7 = new Cars("Ford", "Shelby GT-H", "Gas", "Automatic Transmission", "2007/05");
private static readonly Cars car8 = new Cars("Nissan", "GT-R", "Gas", "Automatic Transmission", "2008/08");
*/
