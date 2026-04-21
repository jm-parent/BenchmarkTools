using BenchmarkTools.Core.Services;
using CoreAppTheme = BenchmarkTools.Core.Models.AppTheme;
using MauiAppTheme = Microsoft.Maui.ApplicationModel.AppTheme;

namespace BenchmarkTools.Services;

public class ThemeService : IThemeService
{
    public void ApplyTheme(CoreAppTheme theme)
    {
        Application.Current!.UserAppTheme = theme switch
        {
            CoreAppTheme.Light => MauiAppTheme.Light,
            CoreAppTheme.Dark => MauiAppTheme.Dark,
            _ => MauiAppTheme.Unspecified
        };
    }
}
