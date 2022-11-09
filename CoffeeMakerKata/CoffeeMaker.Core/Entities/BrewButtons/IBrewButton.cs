using CoffeeMaker.Core.Enums;

namespace CoffeeMaker.Core.Entities.BrewButtons;

public interface IBrewButton
{
    BrewButtonStatus Status { get; }
}
