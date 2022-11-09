using CoffeeMaker.Core.Api.Commands;
using CoffeeMaker.Core.Api.Queries;
using CoffeeMaker.Core.Enums;

namespace CoffeeMaker.Core.Entities.Boilers;

public class Boiler : IBoiler
{
    private readonly IBoilerCommands boilerCommandsImplementation;
    private readonly IBoilerQueries boilerQueriesImplementation;

    public Boiler(IBoilerCommands boilerCommandsImplementation, IBoilerQueries boilerQueriesImplementation)
    {
        this.boilerCommandsImplementation = boilerCommandsImplementation;
        this.boilerQueriesImplementation = boilerQueriesImplementation;
    }

    public BoilerStatus Status => boilerQueriesImplementation.Status.Execute();

    public void TurnOn()
    {
        boilerCommandsImplementation.TurnOn.Execute();
    }

    public void TurnOff()
    {
        boilerCommandsImplementation.TurnOff.Execute();
    }
}
