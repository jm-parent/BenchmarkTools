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
        try
        {
            await Task.Delay(500);
            TotalClicks++;
            LastActivity = $"Refreshed at {DateTime.Now:HH:mm:ss}";
        }
        finally
        {
            IsBusy = false;
        }
    }
}
