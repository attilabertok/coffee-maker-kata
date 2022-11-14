using CoffeeMaker.Core.Api.Queries;
using CoffeeMaker.Core.Entities.BrewButtons;
using CoffeeMaker.Core.Services.Data;
using CoffeeMaker.Tests.Support.Factories;

using NSubstitute;

using Arrange = FluentArrange.NSubstitute.Arrange;

namespace CoffeeMaker.Core.Tests.Unit.Entities.BrewButtons;

public partial class BrewButtonTests
{
    private readonly SystemStatus status;
    private readonly BrewButton sut;

    public BrewButtonTests()
    {
        var systemStatusGenerator = new SystemStatusGenerator();
        status = systemStatusGenerator.GenerateStatus();

        sut = Arrange.For<BrewButton>()
            .WithDependency<IBrewButtonQueries>(q => q.Status.Execute().Returns(status.BrewButtonStatus))
            .BuildSut();
    }
}
