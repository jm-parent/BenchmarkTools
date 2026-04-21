using BenchmarkTools.Core.ViewModels;
using Xunit;

namespace BenchmarkTools.Tests.ViewModels;

public class HomeViewModelTests
{
    [Fact]
    public void CounterText_Initially_IsClickMe()
    {
        var vm = new HomeViewModel();
        Assert.Equal("Click me", vm.CounterText);
    }

    [Fact]
    public void IncrementCounter_Once_SetsClickCountTo1()
    {
        var vm = new HomeViewModel();
        vm.IncrementCounterCommand.Execute(null);
        Assert.Equal(1, vm.ClickCount);
    }

    [Fact]
    public void IncrementCounter_Once_SetsCounterTextSingular()
    {
        var vm = new HomeViewModel();
        vm.IncrementCounterCommand.Execute(null);
        Assert.Equal("Clicked 1 time", vm.CounterText);
    }

    [Fact]
    public void IncrementCounter_Twice_SetsCounterTextPlural()
    {
        var vm = new HomeViewModel();
        vm.IncrementCounterCommand.Execute(null);
        vm.IncrementCounterCommand.Execute(null);
        Assert.Equal("Clicked 2 times", vm.CounterText);
    }
}
