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




//static IMediator Init() {

//var diContainer = new ServiceCollection()
//    .AddDbContext<AppDbContext>() 
//    .AddMediatR(typeof(Assembly))
//    .AddScoped<ISportRepository, InMemorySportRepository>()
//    .BuildServiceProvider();

//    return diContainer.GetRequiredService<IMediator>();
//}


//Init();
//var productId = await mediator.Send(new CreateProductCommand { Name = "test", Price = 10 });
//var diContainer = new ServiceCollection()
//               .AddMediatR(typeof(ISportRepository))   
//               .AddDbContext<AppDbContext>()
//               .AddScoped<ISportRepository, InMemorySportRepository>()
//               .BuildServiceProvider();

//var mediator = diContainer.GetRequiredService<IMediator>();

//var sportId = await mediator.Send(new CreateSportCommand
//{
//    dto = new SportDTO("run")
//});

//var sportId1 = await mediator.Send(new CreateSportCommand
//{
//    dto = new SportDTO("cycle")
//}); 


//Console.WriteLine(sportId);
//Console.WriteLine(sportId1);

var mediator = Init();

Console.WriteLine("Hello!");

//InMemorySportRepository i = new InMemorySportRepository();

var addedSport = await CreateSport(mediator);
Console.WriteLine(addedSport);
          
//static void DisplayItem<T>(T item)
//{
//    var serializedProduct = JsonConvert.SerializeObject(item, new JsonSerializerSettings
//    {
//        PreserveReferencesHandling = PreserveReferencesHandling.Objects,
//        Formatting = Formatting.Indented,
//    });

//    Console.WriteLine(serializedProduct);
//    Console.WriteLine();

//}

 static IMediator Init()
{
    var diContainer = new ServiceCollection()
        .AddDbContext<AppDbContext>()
        .AddMediatR(typeof(Assembly))
        .AddMediatR(typeof(ISportRepository))

        // .AddScoped<IUnitOfWork, UnitOfWork>()
        .AddScoped<ISportRepository, InMemorySportRepository>()
        //.AddScoped<ICategoryRepository, CategoryRepository>()
        .BuildServiceProvider();

    return diContainer.GetRequiredService<IMediator>();
}



static async Task<string> CreateSport(IMediator mediator)
{
    var addSportCommand = new CreateSportCommand();
    addSportCommand.dto = new SportDTO("run");
    return await mediator.Send(addSportCommand);
}





