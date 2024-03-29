using BLL.Services;
using DAL.Interfaces;
using DAL.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Recettes_Sardaigne.Tools;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRecetteRepository, RecetteRepository>(sp =>
new RecetteRepository(builder.Configuration.GetConnectionString("Recettes_sardes_DB")));
builder.Services.AddScoped<RecetteService>();

builder.Services.AddScoped<ITempsRepository, TempsRepository>(sp =>
new TempsRepository(builder.Configuration.GetConnectionString("Recettes_sardes_DB")));
builder.Services.AddScoped<TempsService>();

builder.Services.AddScoped<IRecetteTempsRepository, RecetteTempsRepository>(sp =>
new RecetteTempsRepository(builder.Configuration.GetConnectionString("Recettes_sardes_DB")));
builder.Services.AddScoped<RecetteTempsService>();

builder.Services.AddScoped<IEtapesRepository, EtapesRepository>(sp =>
new EtapesRepository(builder.Configuration.GetConnectionString("Recettes_sardes_DB")));
builder.Services.AddScoped<EtapesService>();

builder.Services.AddScoped<IEtapesRecetteRepository, EtapesRecetteRepository>(sp =>
new EtapesRecetteRepository(builder.Configuration.GetConnectionString("Recettes_sardes_DB")));
builder.Services.AddScoped<EtapesRecetteService>();

builder.Services.AddScoped<ICategorieRepository, CategorieRepository>(sp =>
new CategorieRepository(builder.Configuration.GetConnectionString("Recettes_sardes_DB")));
builder.Services.AddScoped<CategorieService>();

builder.Services.AddScoped<IUsersRepository, UsersRepository>(sp =>
new UsersRepository(builder.Configuration.GetConnectionString("Recettes_sardes_DB")));
builder.Services.AddScoped<UsersService>();


builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(
    options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(TokenManager.key)),
            ValidateLifetime = true,
            ValidateIssuer = false,
            ValidateAudience = false
        };
    }
    );

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

app.Run();
