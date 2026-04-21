namespace BenchmarkTools;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(Views.HomePage), typeof(Views.HomePage));
        Routing.RegisterRoute(nameof(Views.DashboardPage), typeof(Views.DashboardPage));
        Routing.RegisterRoute(nameof(Views.AboutPage), typeof(Views.AboutPage));
        Routing.RegisterRoute(nameof(Views.SettingsPage), typeof(Views.SettingsPage));
    }
}
