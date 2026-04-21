using BenchmarkTools.Core.ViewModels;
using Xunit;

namespace BenchmarkTools.Tests.ViewModels;

public class AboutViewModelTests
{
    [Fact]
    public void AppVersion_IsNotEmpty()
    {
        var vm = new AboutViewModel();
        Assert.False(string.IsNullOrEmpty(vm.AppVersion));
    }

    [Fact]
    public void AppName_IsNotEmpty()
    {
        var vm = new AboutViewModel();
        Assert.False(string.IsNullOrEmpty(vm.AppName));
    }

    [Fact]
    public void Description_IsNotEmpty()
    {
        var vm = new AboutViewModel();
        Assert.False(string.IsNullOrEmpty(vm.Description));
    }
}
