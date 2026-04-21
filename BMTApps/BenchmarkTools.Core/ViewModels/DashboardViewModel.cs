using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BenchmarkTools.Core.ViewModels;

public partial class DashboardViewModel : BaseViewModel
{
    [ObservableProperty]
    private int totalClicks;

    [ObservableProperty]
    private string lastActivity = "No activity yet";

    public DashboardViewModel()
    {
        Title = "Dashboard";
    }

    [RelayCommand]
    private async Task RefreshAsync()
    {
        IsBusy = true;
        await Task.Delay(500); // simuler un chargement
        LastActivity = $"Refreshed at {DateTime.Now:HH:mm:ss}";
        IsBusy = false;
    }
}
