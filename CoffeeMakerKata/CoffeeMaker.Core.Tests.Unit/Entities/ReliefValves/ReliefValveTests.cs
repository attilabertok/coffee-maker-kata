using CoffeeMaker.Core.Entities.ReliefValves;
using FluentArrange;

using Arrange = FluentArrange.NSubstitute.Arrange;

namespace CoffeeMaker.Core.Tests.Unit.Entities.ReliefValves;

public partial class ReliefValveTests
{
    private readonly IReliefValve sut;
    private readonly FluentArrangeContext<ReliefValve> context;

    public ReliefValveTests()
    {
        context = Arrange.For<ReliefValve>();

        sut = context.BuildSut();
    }
}
