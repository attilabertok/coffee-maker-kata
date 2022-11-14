using CoffeeMaker.Core.Api.Queries;
using CoffeeMaker.Core.Entities.WarmerPlates;
using CoffeeMaker.Core.Services.Data;
using CoffeeMaker.Tests.Support.Factories;
using FluentArrange;
using NSubstitute;

using Arrange = FluentArrange.NSubstitute.Arrange;

namespace CoffeeMaker.Core.Tests.Unit.Entities.WarmerPlates;

public partial class WarmerPlateTests
{
    private readonly IWarmerPlate sut;
    private readonly FluentArrangeContext<WarmerPlate> context;
    private readonly SystemStatus status;

    public WarmerPlateTests()
    {
        var systemStatusGenerator = new SystemStatusGenerator();
        status = systemStatusGenerator.GenerateStatus();

        context = Arrange.For<WarmerPlate>()
            .WithDependency<IWarmerPlateQueries>(q => q.Status.Execute().Returns(status.WarmerPlateStatus));

        sut = context.BuildSut();
    }
}
