using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using System.Text;

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
        config.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(o =>
        {
            o.TokenValidationParameters = new TokenValidationParameters
            {
                ValidIssuer = hostingContext.Configuration.GetSection("Jwt:Issuer").Value,
                ValidAudience = hostingContext.Configuration.GetSection("Jwt:Audience").Value,
                IssuerSigningKey = new SymmetricSecurityKey
                (Encoding.UTF8.GetBytes(hostingContext.Configuration.GetSection("Jwt:Key").Value)),
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = false,
                ValidateIssuerSigningKey = true
            };
        });
        config.AddOcelot();
    })
    .Configure(app =>
    {
        app.UseAuthentication();
        app.UseAuthorization();
        app.UseOcelot().Wait();
    });

var app = builder.Build();

app.Run();