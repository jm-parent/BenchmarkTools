using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BenchmarkTools.Core.ViewModels;

public partial class HomeViewModel : BaseViewModel
{
    [ObservableProperty]
    private int clickCount;

    [ObservableProperty]
    private string counterText = "Click me";

    public HomeViewModel()
    {
        Title = "Home";
    }

    [RelayCommand]
    private void IncrementCounter()
    {
        ClickCount++;
        CounterText = ClickCount == 1
            ? "Clicked 1 time"
            : $"Clicked {ClickCount} times";
    }
}
