using Application;
using Infrastructure.Data;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using MediatR;
using AutoMapper;
using System.Reflection;
using WebAPI.Controllers;
using Application.Roles.Commands.DeleteRole;
using Application.Roles.Commands.UpdateRole;
using Application.Roles.Queries.GetRoleByName;
using Application.Roles.Queries.GetAllRoles;
using Application.Sports.Commands.DeleteSport;
using Application.Sports.Commands.UpdateSport;
using Application.Sports.Queries.GetAllSports;
using Application.Users.Commands.CreateUser;
using Application.Users.Commands.DeleteUser;
using Application.Users.Commands.UpdateUser;
using Application.Users.Queries.GetUserByEmail;
using Application.Users.Queries.GetAllUsers;
using Application.Activities.Commands.CreateActivity;
using Application.Activities.Commands.DeleteActivity;
using Application.Activities.Commands.UpdateActivity;
using Application.Activities.Queries.GetActivityById;
using Application.Activities.Queries.GetAllActivities;
using Application.DetailsActivity.Commands.CreateDetailsActivity;
using Application.DetailsActivity.Commands.DeleteDetailsActivity;
using Application.DetailsActivity.Commands.UpdateDetailsActivity;
using Application.DetailsActivity.Queries.GetDetailsActivityById;
using Application.DetailsActivity.Queries.GetAllDetailsActivities;
using Application.PaceActivities.Commands.CreatePaceActivity;
using Application.PaceActivities.Commands.DeletePaceActivity;
using Application.PaceActivities.Commands.UpdatePaceActivity;
using Application.PaceActivities.Queries.GetPaceActivityById;
using Application.PaceActivities.Queries.GetAllPaceActivities;
using WebAPI.Profiles;
using System.Text.Json;
using WebAPI;
using Application.DTOs;

var builder = WebApplication.CreateBuilder(args);
// Add cors
builder.Services.AddCors(o =>
    o.AddDefaultPolicy(b =>
        b.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ISportRepository, SportRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<IActivityRepository, ActivityRepository>();
builder.Services.AddScoped<IDetailActivityRepository, DetailActivityRepository>();
builder.Services.AddScoped<IPaceActivityRepository, PaceActivityRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddDbContext<AppDbContext>();

builder.Services.AddMediatR(typeof(CreateRoleCommand));

builder.Services.AddAutoMapper(typeof(RoleMappingProfiles));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
