using CoffeeMaker.Hardware.Adapter.Tests.Unit.TestData;
using CoffeeMaker.Hardware.Interface;
using FluentAssertions;
using NSubstitute;

namespace CoffeeMaker.Hardware.Adapter.Tests.Unit.Boiler.Queries;

public partial class BoilerStatusQueryTests
{
    public class Execute : BoilerStatusQueryTests
    {
        public static EnumTheoryData<BoilerStatus> BoilerStatusValues { get; } = new();

        [Theory]
        [MemberData(nameof(BoilerStatusValues))]
        public void Should_ReturnBoilerStatusFromApi(BoilerStatus boilerStatus)
        {
            mockApi.GetBoilerStatus()
                .Returns(boilerStatus);

            var result = sut.Execute();

            result.Should()
                .Be(boilerStatus);
        }
    }
}
