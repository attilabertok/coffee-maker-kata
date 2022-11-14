using CoffeeMaker.Core.Api.Queries;
using CoffeeMaker.Core.Entities.Boilers;
using CoffeeMaker.Core.Services.Data;
using CoffeeMaker.Tests.Support.Factories;
using FluentArrange;
using NSubstitute;

using Arrange = FluentArrange.NSubstitute.Arrange;

namespace CoffeeMaker.Core.Tests.Unit.Entities.Boilers;

public partial class BoilerTests
{
    private readonly IBoiler sut;
    private readonly FluentArrangeContext<Boiler> context;
    private readonly SystemStatus status;

    public BoilerTests()
    {
        var systemStatusGenerator = new SystemStatusGenerator();
        status = systemStatusGenerator.GenerateStatus();

        context = Arrange.For<Boiler>()
            .WithDependency<IBoilerQueries>(q => q.Status.Execute().Returns(status.BoilerStatus));

        sut = context.BuildSut();
    }
}
