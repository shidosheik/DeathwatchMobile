using DeathwatchMobile.Services;
using Xunit;

namespace DeathwatchMobile.Tests;

public class RollServiceTests
{
    [Fact]
    public void CalculateTarget_AddsPositiveModifier()
    {
        var service = new RollService();

        var result = service.CalculateTarget(40, 10);

        Assert.Equal(40+10, result);
    }

    [Fact]
    public void CalculateTarget_AddsNegativeModifier()
    {
        var service = new RollService();

        var result = service.CalculateTarget(40, -10);

        Assert.Equal(40-10, result);
    }

    [Fact]
    public void IsSuccess_ReturnsTrue_WhenRollIsBelowTarget()
    {
        var service = new RollService();

        var result = service.IsSuccess(32, 40);

        Assert.True(result);
    }

    [Fact]
    public void IsSuccess_ReturnsTrue_WhenRollEqualsTarget()
    {
        var service = new RollService();

        var result = service.IsSuccess(40, 40);

        Assert.True(result);
    }

    [Fact]
    public void IsSuccess_ReturnsFalse_WhenRollIsAboveTarget()
    {
        var service = new RollService();

        var result = service.IsSuccess(41, 40);

        Assert.False(result);
    }

    [Fact]
    public void CalculateDegrees_ReturnsOne_WhenDifferenceIsLessThanTen()
    {
        var service = new RollService();

        var result = service.CalculateDegrees(37, 40);

        Assert.Equal(1, result);
    }

    [Fact]
    public void CalculateDegrees_ReturnsTwo_WhenDifferenceIsTenToNineteen()
    {
        var service = new RollService();

        var result = service.CalculateDegrees(28, 40);

        Assert.Equal(2, result);
    }
}