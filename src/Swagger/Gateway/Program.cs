using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.OpenApi.Models;
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
    .ConfigureServices((hostingContext, config) =>
    {
        config.AddOcelot();
        config.AddSwaggerForOcelot(hostingContext.Configuration);
        config.AddMvc();
        config.AddSwaggerGen();
    })
    .Configure(app =>
    {
        app.UseRouting();
        app.UseSwaggerForOcelotUI(opt =>
        {
            opt.PathToSwaggerGenerator = "/swagger/docs";
        }).UseOcelot().Wait(); 
        app.UseSwagger();
        app.UseSwaggerUI();
    });

var app = builder.Build();

app.Run();