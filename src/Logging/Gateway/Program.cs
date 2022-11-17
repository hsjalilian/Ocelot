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
    })
    .ConfigureServices(c =>
    {
        c.AddOcelot();
    })
    .UseSerilog((ctx, lc) => lc
        .ReadFrom.Configuration(ctx.Configuration)
     )
    .Configure(app =>
    {
        app.UseSerilogRequestLogging();
        app.UseOcelot().Wait();
    });

var app = builder.Build();

app.Run();