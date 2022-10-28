namespace CoffeeMaker.Tests.Acceptance.Support.Factories;

public static class CustomPollCondition
{
    private static int runCount = 0;

    public static bool RunExactly(int expectedRunCount)
    {
        if (runCount >= expectedRunCount)
        {
            return false;
        }

        runCount++;
        return true;
    }
}
