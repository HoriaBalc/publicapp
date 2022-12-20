using Application;
using Data;
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


var builder = WebApplication.CreateBuilder(args);

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

//builder.Services.AddMediatR(typeof(Assembly));

builder.Services.AddMediatR(typeof(CreateRoleCommand));
builder.Services.AddMediatR(typeof(DeleteRoleCommand));
builder.Services.AddMediatR(typeof(UpdateRoleCommand));
builder.Services.AddMediatR(typeof(GetRoleByNameQuery));
builder.Services.AddMediatR(typeof(GetAllRolesQuery));

builder.Services.AddMediatR(typeof(CreateSportCommand));
builder.Services.AddMediatR(typeof(DeleteSportCommand));
builder.Services.AddMediatR(typeof(UpdateSportCommand));
builder.Services.AddMediatR(typeof(GetSportByNameQuery));
builder.Services.AddMediatR(typeof(GetAllSportsQuery));

builder.Services.AddMediatR(typeof(CreateUserCommand));
builder.Services.AddMediatR(typeof(DeleteUserCommand));
builder.Services.AddMediatR(typeof(UpdateUserCommand));
builder.Services.AddMediatR(typeof(GetUserByEmailQuery));
builder.Services.AddMediatR(typeof(GetAllUsersQuery));

builder.Services.AddMediatR(typeof(CreateActivityCommand));
builder.Services.AddMediatR(typeof(DeleteActivityCommand));
builder.Services.AddMediatR(typeof(UpdateActivityCommand));
builder.Services.AddMediatR(typeof(GetActivityByIdQuery));
builder.Services.AddMediatR(typeof(GetAllActivitiesQuery));

builder.Services.AddMediatR(typeof(CreateDetailsActivityCommand));
builder.Services.AddMediatR(typeof(DeleteDetailsActivityCommand));
builder.Services.AddMediatR(typeof(UpdateDetailsActivityCommand));
builder.Services.AddMediatR(typeof(GetDetailsActivityByIdQuery));
builder.Services.AddMediatR(typeof(GetAllDetailsActivitiesQuery));

builder.Services.AddMediatR(typeof(CreatePaceActivityCommand));
builder.Services.AddMediatR(typeof(DeletePaceActivityCommand));
builder.Services.AddMediatR(typeof(UpdatePaceActivityCommand));
builder.Services.AddMediatR(typeof(GetPaceActivityByIdQuery));
builder.Services.AddMediatR(typeof(GetAllPaceActivitiesQuery));

builder.Services.AddMediatR(typeof(SportController));
builder.Services.AddMediatR(typeof(RoleController));
builder.Services.AddMediatR(typeof(UserController));
builder.Services.AddMediatR(typeof(ActivityController));
builder.Services.AddMediatR(typeof(PaceActivityController));
builder.Services.AddMediatR(typeof(DetailActivityController));

//builder.Services.AddAutoMapper(typeof(Assembly));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
