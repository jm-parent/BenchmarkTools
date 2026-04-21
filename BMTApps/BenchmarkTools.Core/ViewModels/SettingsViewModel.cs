using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using BenchmarkTools.Core.Models;

namespace BenchmarkTools.Core.ViewModels;

public partial class SettingsViewModel : BaseViewModel
{
    [ObservableProperty]
    private AppTheme selectedTheme = AppTheme.System;

    public IReadOnlyList<AppTheme> AvailableThemes { get; } =
        new[] { AppTheme.System, AppTheme.Light, AppTheme.Dark };

    public SettingsViewModel()
    {
        Title = "Settings";
    }

    [RelayCommand]
    private void ApplyTheme()
    {
        // La logique applicative (Application.Current.UserAppTheme) sera dans la View ou un service
        // Le ViewModel ne dépend pas de MAUI
    }
}
