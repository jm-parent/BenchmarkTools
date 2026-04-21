using BenchmarkTools.Core.ViewModels;
using Xunit;

namespace BenchmarkTools.Tests.ViewModels;

public class DashboardViewModelTests
{
    [Fact]
    public void TotalClicks_DefaultsToZero()
    {
        var vm = new DashboardViewModel();
        Assert.Equal(0, vm.TotalClicks);
    }

    [Fact]
    public void RefreshCommand_CanExecute_IsTrue()
    {
        var vm = new DashboardViewModel();
        Assert.True(vm.RefreshCommand.CanExecute(null));
    }

    [Fact]
    public void LastActivity_Initially_IsNotEmpty()
    {
        var vm = new DashboardViewModel();
        Assert.False(string.IsNullOrEmpty(vm.LastActivity));
    }
}
