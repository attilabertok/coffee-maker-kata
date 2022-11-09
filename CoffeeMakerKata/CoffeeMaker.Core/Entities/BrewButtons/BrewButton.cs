using CoffeeMaker.Core.Api.Queries;
using CoffeeMaker.Core.Enums;

namespace CoffeeMaker.Core.Entities.BrewButtons;

public class BrewButton : IBrewButton
{
    private readonly IBrewButtonQueries brewButtonQueries;

    public BrewButton(IBrewButtonQueries brewButtonQueries)
    {
        this.brewButtonQueries = brewButtonQueries;
    }

    public BrewButtonStatus Status => brewButtonQueries.Status.Execute();
}
