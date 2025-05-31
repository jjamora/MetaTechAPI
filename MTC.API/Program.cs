using Microsoft.EntityFrameworkCore;
using MTC.Core.Repositories;
using MTC.Core.Services;
using MTC.Data;
using MTC.Data.Repositories;
using MTC.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
IConfiguration configuration = new ConfigurationManager();

var conString = builder.Configuration.GetConnectionString("Local") ??
     throw new InvalidOperationException("Connection string 'MTC Db' not found.");

builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(conString), ServiceLifetime.Transient);

builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped<IServiceManager, ServiceManager>();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => {
    options.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
    options.IgnoreObsoleteActions();
    options.IgnoreObsoleteProperties();
    options.CustomSchemaIds(type => type.FullName);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(options => { options.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod(); });
app.UseAuthorization();

app.MapControllers();

app.Run();
