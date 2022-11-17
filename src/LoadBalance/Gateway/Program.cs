using Microsoft.AspNetCore;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebHost.CreateDefaultBuilder();
builder
    .UseKestrel()
    .UseContentRoot(Directory.GetCurrentDirectory())
    .ConfigureAppConfiguration(conf =>
    {
        conf
            .AddJsonFile("appsettings.json")
            .AddJsonFile("ocelot.json");
    })
    .ConfigureServices(c =>
    {
        c.AddOcelot();
    })
    .Configure(app =>
    {
        app.UseOcelot().Wait();
    });

var app = builder.Build();

app.Run();