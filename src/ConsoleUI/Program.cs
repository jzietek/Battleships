using Microsoft.Extensions.DependencyInjection;
using Domain;
using GameServices;

namespace ConsoleUI;

class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = BuildDi();

        var fleetBuilder = serviceProvider.GetService<IFleetBuilder>();
        var fleet = fleetBuilder.Build();

        var battle = new Battle(new [] { fleet })
        {
             AreaWidth = 10,
             AreaHeight = 10
        };
        
        var inputLoop = serviceProvider.GetService<BattleInputLoop>();
        inputLoop.Run(battle);
    }

    private static IServiceProvider BuildDi()
    {
        return new ServiceCollection()
            .AddTransient<BattleInputLoop>()
            .AddTransient<IFleetBuilder, RandomFleetBuilder>()
            .BuildServiceProvider();
    }
}