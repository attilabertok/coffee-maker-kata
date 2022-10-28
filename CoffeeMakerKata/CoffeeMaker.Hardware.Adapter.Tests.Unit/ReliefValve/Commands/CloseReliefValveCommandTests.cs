using CoffeeMaker.Hardware.Adapter.ReliefValve.Commands;
using CoffeeMaker.Hardware.Interface;
using NSubstitute;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.ReliefValve.Commands;

public partial class CloseReliefValveCommandTests
{
    private readonly CloseReliefValveCommand sut;
    private ReliefValveState reliefValveState;

    public CloseReliefValveCommandTests()
    {
        reliefValveState = ReliefValveState.Open;
        var mockApi = Substitute.For<ICoffeeMakerApi>();
        mockApi.When(a => a.SetReliefValveState(Arg.Any<ReliefValveState>()))
            .Do(x => reliefValveState = x.Arg<ReliefValveState>());

        sut = new CloseReliefValveCommand(mockApi);
    }
}
