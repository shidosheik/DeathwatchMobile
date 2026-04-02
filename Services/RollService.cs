namespace DeathwatchMobile.Services;

public class RollService
{
    public int CalculateTarget(int characteristic, int modifier = 0)
    {
        return characteristic + modifier;
    }

    public bool IsSuccess(int roll, int target)
    {
        return roll <= target;
    }

    public int CalculateDegrees(int roll, int target)
    {
        return Math.Abs(target - roll) / 10 + 1;
    }
}