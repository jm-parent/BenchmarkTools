namespace BenchmarkTools.Core.Services;

public interface INavigationService
{
    Task NavigateToAsync(string route);
    Task GoBackAsync();
}
