using CoffeeMaker.Hardware.Adapter.ReliefValves.Commands;
using CoffeeMaker.Hardware.Interface;
using NSubstitute;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.ReliefValve.Commands;

public partial class OpenReliefValveCommandTests
{
    private readonly OpenReliefValveCommand sut;
    private ReliefValveState reliefValveState;

    public OpenReliefValveCommandTests()
    {
        reliefValveState = ReliefValveState.Closed;
        var mockApi = Substitute.For<ICoffeeMakerApi>();
        mockApi.When(a => a.SetReliefValveState(Arg.Any<ReliefValveState>()))
            .Do(x => reliefValveState = x.Arg<ReliefValveState>());

        sut = new OpenReliefValveCommand(mockApi);
    }
}
