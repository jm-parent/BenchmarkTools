using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using BenchmarkTools.Core.Models;
using BenchmarkTools.Core.Services;

namespace BenchmarkTools.Core.ViewModels;

public partial class SettingsViewModel : BaseViewModel
{
    private readonly IThemeService _themeService;

    [ObservableProperty]
    private AppTheme selectedTheme = AppTheme.System;

    public IReadOnlyList<AppTheme> AvailableThemes { get; } =
        new[] { AppTheme.System, AppTheme.Light, AppTheme.Dark };

    public SettingsViewModel(IThemeService themeService)
    {
        _themeService = themeService;
        Title = "Settings";
    }

    [RelayCommand]
    private void ApplyTheme()
    {
        _themeService.ApplyTheme(SelectedTheme);
    }
}
