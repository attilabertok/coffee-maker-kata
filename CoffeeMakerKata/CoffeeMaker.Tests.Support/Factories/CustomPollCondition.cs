namespace CoffeeMaker.Tests.Support.Factories;

public class CustomPollCondition
{
    private int runCount;

    public bool RunExactly(int expectedRunCount)
    {
        if (runCount >= expectedRunCount)
        {
            return false;
        }

        runCount++;
        return true;
    }
}
