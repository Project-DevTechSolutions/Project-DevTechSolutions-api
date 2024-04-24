using Dev.Tech.Solutions.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.Extensions.Options;


var builder = WebApplication.CreateBuilder(args);

string authority = builder.Configuration["Auth0.Authority"] ??
    throw new ArgumentNullException("Auth0:Authority");

string audience = builder.Configuration["Auth0.Audience"] ??
    throw new ArgumentNullException("Auth0:Audience");

string storeConnectionString = builder.Configuration.GetConnectionString("StoreConnection") ??
    throw new ArgumentNullException("ConnectionString:StoreConnection");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddDbContext<StoreContext>(options => 
    options.UseSqlServer(storeConnectionString,
    b => b.MigrationsAssembly("Dev.Tech.Solutions.Api"))
);




builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

