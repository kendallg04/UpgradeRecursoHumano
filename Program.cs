using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.OpenApi.Models;
using NLog;
using NLog.Web;
using SIGRH.Data;
using SIGRH.Data.Repositories;
using SIGRH.Infraestructures.Interfaces;
using SIGRH.Models.DTO;
using SIGRH.Services;
using SIGRH.Utils;
using SIGRH.Utils.DBFactory;
using SIGRH.Utils.Jwt;
using SIGRH.Utils.Mapper;

var logger = LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
logger.Debug("init main");

try
{
    logger.Info("Iniciando aplicación...");
    var builder = WebApplication.CreateBuilder(args);
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    var infoSQL = builder.Configuration.GetSection("InfoSQL");

    builder.Services.AddJwtAuthentication(builder.Configuration);
    builder.Services.AddAuthorization();
    builder.Services.AddRazorPages();
    builder.Services.AddControllers();

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(options =>
    {
        options.SwaggerDoc("v1", new OpenApiInfo
        {
            Version = "v1",
            Title = "RECURSO HUMANO - SIGRH",
            Description = "ASP.NET Core Web API para SIGRH",
            TermsOfService = new Uri("https://example.com/terms"),
            Contact = new OpenApiContact
            {
                Name = "Example Contact",
                Url = new Uri("https://example.com/contact")
            },
            License = new OpenApiLicense
            {
                Name = "Example License",
                Url = new Uri("https://example.com/license")
            }
        });

        options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            Name = "Authorization",
            Type = SecuritySchemeType.Http,
            Scheme = "bearer",
            BearerFormat = "JWT",
            In = ParameterLocation.Header,
            Description = "Ingrese el token JWT en el formato 'Bearer {token}'"
        });

        options.AddSecurityRequirement(new OpenApiSecurityRequirement
        {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                },
                Array.Empty<string>()
            }
        });
    });

    // Contexto
    builder.Services.AddHttpContextAccessor();

    // AutoMapper
    builder.Services.AddAutoMapper(cfg =>
    {
        cfg.AddProfile(new RequestMapperProfileUtil());
        cfg.AddProfile(new ResponseMapperProfileUtil());
        cfg.AddProfile(new UsuarioMapperUtil());
    });

    // SQL
    builder.Services.Configure<InfoSqlOptionsDTO>(infoSQL);
    // DB FIja
    builder.Services.AddScoped<IDbConnection>(sp => new SqlConnection(connectionString));
    // DB Dinamica
    builder.Services.AddScoped<IDBFactory, DBFactoryUtil>();
    builder.Services.AddScoped<IUsuario, UsuarioRepository>();
    builder.Services.AddScoped<IUsuarioAccionExclusiva, UsuarioAccionExclusivaRepository>();

    //NLOG
    builder.Logging.ClearProviders();
    builder.Host.UseNLog();

    builder.Services.AddCors(options =>
    {
        options.AddPolicy("Abierto", policy =>
        {
            policy.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
        });
    });

    // SERVICES
    builder.Services.AddScoped<AuthService>();
    builder.Services.AddScoped<UsuarioExclusivoService>();

    // UTILS
    builder.Services.AddScoped<JwtTokenServiceUtil>();

    var app = builder.Build();

    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseRouting();

    app.UseCors("Abierto");

    app.UseAuthentication();
    app.UseAuthorization();

    app.MapControllers();
    app.MapRazorPages()
       .WithStaticAssets();
    app.MapStaticAssets();

    app.Run();
}
catch (Exception ex)
{
    logger.Error(ex, "La aplicación falló al iniciar");
    throw;
}
finally
{
    LogManager.Shutdown();
}