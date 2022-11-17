using Application;
using Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using Application.Sports.Commands.CreateSport;

var diContainer = new ServiceCollection()
    .AddScoped<ISportRepository, InMemorySportRepository>()
    .AddMediatR(typeof(ISportRepository))
    .BuildServiceProvider();

var mediator = diContainer.GetRequiredService<IMediator>();
var sportId = await mediator.Send(new CreateSportMessage 
{
    Name = "running"
});


