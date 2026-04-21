namespace BenchmarkTools.Core.ViewModels;

public partial class AboutViewModel : BaseViewModel
{
    public string AppName { get; } = "BenchmarkTools";
    public string AppVersion { get; } = "1.0";
    public string Description { get; } = "A .NET MAUI benchmark tool with MVVM architecture.";

    public AboutViewModel()
    {
        Title = "About";
    }
}
