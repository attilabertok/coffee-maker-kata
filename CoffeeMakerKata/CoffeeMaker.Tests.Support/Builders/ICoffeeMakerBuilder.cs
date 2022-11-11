using CoffeeMaker.Core.Enums;
using CoffeeMaker.Entities;

using FluentArrange;

namespace CoffeeMaker.Tests.Support.Builders;

public interface ICoffeeMakerBuilder
{
    public FluentArrangeContext<Mark4CoffeeMaker> Context { get; set; }

    ICoffeeMakerBuilder InState(CoffeeMakerState desiredState);

    ICoffeeMakerBuilder ThatRunsExactly(int cycles);

    ICoffeeMaker Build();
}
