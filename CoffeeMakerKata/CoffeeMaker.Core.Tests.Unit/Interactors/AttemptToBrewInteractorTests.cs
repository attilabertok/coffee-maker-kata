using CoffeeMaker.Core.Enums;
using CoffeeMaker.Core.Interactors;
using CoffeeMaker.Core.Services.Data;
using FluentArrange;
using NSubstitute;

using Arrange = FluentArrange.NSubstitute.Arrange;

namespace CoffeeMaker.Core.Tests.Unit.Interactors;

public partial class AttemptToBrewInteractorTests
{
    private readonly ICanBrewInteractor canBrewInteractor;
    private readonly FluentArrangeContext<AttemptToBrewInteractor> context;
    private readonly IAttemptToBrewInteractor sut;

    public AttemptToBrewInteractorTests()
    {
        canBrewInteractor = Substitute.For<ICanBrewInteractor>();
        context = Arrange.For<AttemptToBrewInteractor>()
            .WithDependency(canBrewInteractor);

        sut = context.BuildSut();
    }
}
