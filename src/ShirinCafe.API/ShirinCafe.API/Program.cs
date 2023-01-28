using System.Collections;
using Application.DataTransferObjects;
using AutoMapper;
using Domain.Models;
using Domain.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
var sqlConBuilder = new SqlConnectionStringBuilder
{
    ConnectionString = builder.Configuration.GetConnectionString("SQLDbConnection"),
    UserID = builder.Configuration["UserId"], //getting UserId from dotnet secret
    Password = builder.Configuration["Password"] //getting Password from dotnet secret
};

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(sqlConBuilder.ConnectionString));
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


app.MapGet("api/users", async (IUserRepository repo, IMapper mapper) =>
{
    var users = await repo.GetAllUserAsync();
    return Results.Ok(mapper.Map<IEnumerable<UserReadDto>>(users));
});

app.MapGet("api/users/{id}", async (IUserRepository repo, IMapper mapper,int id ) =>
{
    var user = await repo.GetUserByIdAsync(id);
    return user is null ? Results.NotFound() : Results.Ok(mapper.Map<UserReadDto>(user));
});

app.MapPost("api/users", async (IUserRepository repo, IMapper mapper, UserCreateDto userCreateDto) =>
{
    var userModel = mapper.Map<User>(userCreateDto);
    await repo.CreateUserAsync(userModel);
    await repo.SaveChangesAsync();

    var userReadDto = mapper.Map<UserReadDto>(userModel);
    return Results.Created($"api/users/{userReadDto.Id}",userReadDto);
});

app.MapPut("api/users/{id}", async (IUserRepository repo, IMapper mapper, int id, UserUpdateDto userUpdateDto) =>
{
    var user = await repo.GetUserByIdAsync(id);
    
    if (user is null)
        return Results.NotFound();

    mapper.Map(userUpdateDto, user);
    await repo.SaveChangesAsync();
    return Results.NoContent();
});

app.MapDelete("api/users/{id}", async (IUserRepository repo, IMapper mapper, int id) =>
{
    var user = await repo.GetUserByIdAsync(id);
    if (user is null)
        return Results.NotFound();
    
    repo.DeleteUser(user);
    return Results.NoContent();
});

app.Run("http://localhost:2222");

