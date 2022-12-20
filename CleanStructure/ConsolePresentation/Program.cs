using Application;
using Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System.Text.RegularExpressions;
using Data;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System.Reflection;
using Microsoft.IdentityModel.Tokens;
using System.Xml;
using Domain;
using Application.Sports.Commands.UpdateSport;
using Application.Sports.Commands.DeleteSport;
using Application.Sports.Queries.GetAllSports;
using Application.Sports;

var mediator = Init();

Console.WriteLine("Hello!");


//var addedSport = await CreateSport(mediator);
//Console.WriteLine(addedSport);

//var getSport = await GetSport(mediator);
//Console.WriteLine(getSport.Name);

//var getSports = await GetSports(mediator);
//getSports.ForEach(s => { Console.WriteLine(s.Name); });

//var updatedSport = await UpdateSport(mediator);
//Console.WriteLine(updatedSport.Name);

//var deleteSport = await DeleteSport(mediator);
//Console.WriteLine(deleteSport.Name);

var addedRole = await CreateSport(mediator);
Console.WriteLine(addedRole);

var getSport = await GetSport(mediator);
Console.WriteLine(getSport.Name);

var getSports = await GetSports(mediator);
getSports.ForEach(s => { Console.WriteLine(s.Name); });

var updatedSport = await UpdateSport(mediator);
Console.WriteLine(updatedSport.Name);

var deleteSport = await DeleteSport(mediator);
Console.WriteLine(deleteSport.Name);

//var addedSport = await CreateSport(mediator);
//Console.WriteLine(addedSport);

//var getSport = await GetSport(mediator);
//Console.WriteLine(getSport.Name);

//var getSports = await GetSports(mediator);
//getSports.ForEach(s => { Console.WriteLine(s.Name); });

//var updatedSport = await UpdateSport(mediator);
//Console.WriteLine(updatedSport.Name);

//var deleteSport = await DeleteSport(mediator);
//Console.WriteLine(deleteSport.Name);

//var addedSport = await CreateSport(mediator);
//Console.WriteLine(addedSport);

//var getSport = await GetSport(mediator);
//Console.WriteLine(getSport.Name);

//var getSports = await GetSports(mediator);
//getSports.ForEach(s => { Console.WriteLine(s.Name); });

//var updatedSport = await UpdateSport(mediator);
//Console.WriteLine(updatedSport.Name);

//var deleteSport = await DeleteSport(mediator);
//Console.WriteLine(deleteSport.Name);

//var addedSport = await CreateSport(mediator);
//Console.WriteLine(addedSport);

//var getSport = await GetSport(mediator);
//Console.WriteLine(getSport.Name);

//var getSports = await GetSports(mediator);
//getSports.ForEach(s => { Console.WriteLine(s.Name); });

//var updatedSport = await UpdateSport(mediator);
//Console.WriteLine(updatedSport.Name);

//var deleteSport = await DeleteSport(mediator);
//Console.WriteLine(deleteSport.Name);



static IMediator Init()
{
    var diContainer = new ServiceCollection()
        .AddDbContext<AppDbContext>()
        .AddMediatR(typeof(Assembly)) 
        .AddMediatR(typeof(ISportRepository))
        .AddMediatR(typeof(IActivityRepository))
        .AddMediatR(typeof(IPaceActivityRepository))
        .AddMediatR(typeof(IDetailActivityRepository))
        .AddMediatR(typeof(IUserRepository))
        .AddMediatR(typeof(IRoleRepository))
         .AddMediatR(typeof(IUnitOfWork))

        .AddScoped<IUnitOfWork, UnitOfWork>()
        .AddScoped<ISportRepository, SportRepository>()
        .AddScoped<IRoleRepository, RoleRepository>()
        .AddScoped<IActivityRepository, ActivityRepository>()
        .AddScoped<IDetailActivityRepository, DetailActivityRepository>()
        .AddScoped<IPaceActivityRepository, PaceActivityRepository>()
        .AddScoped<IUserRepository, UserRepository>()
        .BuildServiceProvider();

    return diContainer.GetRequiredService<IMediator>();
}



static async Task<string> CreateSport(IMediator mediator)
{
    var addSportCommand = new CreateSportCommand();
    addSportCommand.dto = new SportDTO("run");
    return await mediator.Send(addSportCommand);
}

static async Task<Sport> GetSport(IMediator mediator)
{
    var getSportCommand = new GetSportByNameQuery();
    getSportCommand.Name = "cycle";
    return await mediator.Send(getSportCommand);
}

static async Task<List<Sport>> GetSports(IMediator mediator)
{
    var getSportsCommand = new GetAllSportsQuery();
    return await mediator.Send(getSportsCommand);
}

static async Task<Sport> UpdateSport(IMediator mediator)
{
    var updateSportCommand = new UpdateSportCommand();
    Sport s = await GetSport(mediator);
    SportDTO dto = new SportDTO(s.Name);
    dto.Id = s.Id;
    dto.Activities = s.Activities;
    updateSportCommand.dto = dto ;
    return await mediator.Send(updateSportCommand);
}

static async Task<Sport> DeleteSport(IMediator mediator)
{
    var deleteSportCommand = new DeleteSportCommand();
    deleteSportCommand.Name = "cycle";
    return await mediator.Send(deleteSportCommand);
}



