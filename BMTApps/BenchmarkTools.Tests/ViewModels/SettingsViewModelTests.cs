using BenchmarkTools.Core.Models;
using BenchmarkTools.Core.Services;
using BenchmarkTools.Core.ViewModels;
using NSubstitute;
using Xunit;

namespace BenchmarkTools.Tests.ViewModels;

public class SettingsViewModelTests
{
    private static SettingsViewModel CreateViewModel() =>
        new SettingsViewModel(Substitute.For<IThemeService>());

    [Fact]
    public void SelectedTheme_DefaultsToSystem()
    {
        var vm = CreateViewModel();
        Assert.Equal(AppTheme.System, vm.SelectedTheme);
    }

    [Fact]
    public void ApplyThemeCommand_CanExecute_IsTrue()
    {
        var vm = CreateViewModel();
        Assert.True(vm.ApplyThemeCommand.CanExecute(null));
    }

    [Fact]
    public void AvailableThemes_ContainsAllThreeOptions()
    {
        var vm = CreateViewModel();
        Assert.Contains(AppTheme.System, vm.AvailableThemes);
        Assert.Contains(AppTheme.Light, vm.AvailableThemes);
        Assert.Contains(AppTheme.Dark, vm.AvailableThemes);
    }
}
