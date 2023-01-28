using Domain.Repositories;
using Infrastructure.Repositories;
using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
var sqlConBuilder = new SqlConnectionStringBuilder
{
    ConnectionString = builder.Configuration.GetConnectionString("SQLDbConnection"),
    UserID = builder.Configuration["UserId"], //getting UserId from dotnet secret
    Password = builder.Configuration["Password"] //getting Password from dotnet secret
};

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();
app.MapGet("/", () => "Welcome to Shirin Cafe API");
app.Run("http://localhost:2222");

