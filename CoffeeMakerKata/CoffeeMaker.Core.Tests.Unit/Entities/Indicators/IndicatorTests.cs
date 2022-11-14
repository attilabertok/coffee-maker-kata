using CoffeeMaker.Core.Entities.Indicators;
using FluentArrange;

using Arrange = FluentArrange.NSubstitute.Arrange;

namespace CoffeeMaker.Core.Tests.Unit.Entities.Indicators;

public partial class IndicatorTests
{
    private readonly IIndicator sut;
    private readonly FluentArrangeContext<Indicator> context;

    public IndicatorTests()
    {
        context = Arrange.For<Indicator>();

        sut = context.BuildSut();
    }
}
