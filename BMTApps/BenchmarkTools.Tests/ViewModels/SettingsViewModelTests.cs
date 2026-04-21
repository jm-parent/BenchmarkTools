using BenchmarkTools.Core.Models;
using BenchmarkTools.Core.ViewModels;
using Xunit;

namespace BenchmarkTools.Tests.ViewModels;

public class SettingsViewModelTests
{
    [Fact]
    public void SelectedTheme_DefaultsToSystem()
    {
        var vm = new SettingsViewModel();
        Assert.Equal(AppTheme.System, vm.SelectedTheme);
    }

    [Fact]
    public void ApplyThemeCommand_CanExecute_IsTrue()
    {
        var vm = new SettingsViewModel();
        Assert.True(vm.ApplyThemeCommand.CanExecute(null));
    }

    [Fact]
    public void AvailableThemes_ContainsAllThreeOptions()
    {
        var vm = new SettingsViewModel();
        Assert.Contains(AppTheme.System, vm.AvailableThemes);
        Assert.Contains(AppTheme.Light, vm.AvailableThemes);
        Assert.Contains(AppTheme.Dark, vm.AvailableThemes);
    }
}
