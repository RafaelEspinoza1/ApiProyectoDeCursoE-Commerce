using ApiProyectoDeCursoE_Commerce.Configuration;
using ApiProyectoDeCursoE_Commerce.DAO;
using ApiProyectoDeCursoE_Commerce.DAOs;
using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.Executor;
using ApiProyectoDeCursoE_Commerce.Extensions;
using ApiProyectoDeCursoE_Commerce.Repositories;
using ApiProyectoDeCursoE_Commerce.Services;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// ======= Contexto =======
builder.Services.AddSingleton(sp =>
{
    var configuration = sp.GetRequiredService<IConfiguration>();
    var connectionString = configuration.GetConnectionString("DefaultConnection")!;
    return new ECommerceContext(connectionString);
});

// ======= Executor =======
builder.Services.AddSingleton<SqlExecutor>();

// ======= DAOs =======
builder.Services.AddScoped<UsuarioDAO>();
builder.Services.AddScoped<AdminDAO>();
builder.Services.AddScoped<VendedorDAO>();
builder.Services.AddScoped<CompradorDAO>();
builder.Services.AddScoped<RefreshTokenDAO>();

// ======= Repositorios =======
builder.Services.AddScoped<AuthRepository>();

// ======= Servicios =======
builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));
builder.Services.AddSingleton(sp =>
{
    var settings = sp.GetRequiredService<IOptions<JwtSettings>>().Value;
    return new JwtService(settings);
});
builder.Services.AddScoped<AuthService>();

// ======= Autenticación JWT =======
builder.Services.AddJwtAuthentication(builder.Configuration);

// ======= Controladores =======
builder.Services.AddControllers();

// ======= Swagger/OpenAPI =======
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ======= Middleware =======
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();