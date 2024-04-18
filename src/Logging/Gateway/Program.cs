using Microsoft.AspNetCore;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Serilog;

var builder = WebHost.CreateDefaultBuilder();
builder
    .UseKestrel()
    .UseContentRoot(Directory.GetCurrentDirectory())
    .ConfigureAppConfiguration(conf =>
    {
        conf
            .AddJsonFile("appsettings.json")
            .AddJsonFile("ocelot.json");

        Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(conf.Build())
            .CreateLogger();
    })
    .ConfigureServices(c =>
    {
        c.AddSerilog();
        c.AddOcelot();
    })
    .Configure(app =>
    {
        app.UseSerilogRequestLogging();
        app.UseOcelot().Wait();
    });

var app = builder.Build();

app.Run();