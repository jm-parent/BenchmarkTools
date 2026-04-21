using BenchmarkTools.Core.Services;

namespace BenchmarkTools.Services;

public class NavigationService : INavigationService
{
    public Task NavigateToAsync(string route) =>
        Shell.Current.GoToAsync(route);

    public Task GoBackAsync() =>
        Shell.Current.GoToAsync("..");
}
