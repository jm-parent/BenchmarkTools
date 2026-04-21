using Microsoft.Extensions.Logging;
using BenchmarkTools.Core.Services;
using BenchmarkTools.Core.ViewModels;
using BenchmarkTools.Services;
using BenchmarkTools.Views;
#if DEBUG
using Microsoft.Maui.DevFlow.Agent;
#endif

namespace BenchmarkTools;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		// Services
		builder.Services.AddSingleton<INavigationService, NavigationService>();

#if DEBUG
		builder.AddMauiDevFlowAgent();
#endif

		// Pages + ViewModels
		builder.Services.AddTransient<HomeViewModel>();
		builder.Services.AddTransient<HomePage>();
		builder.Services.AddTransient<DashboardViewModel>();
		builder.Services.AddTransient<DashboardPage>();
		builder.Services.AddTransient<AboutViewModel>();
		builder.Services.AddTransient<AboutPage>();
		builder.Services.AddTransient<SettingsViewModel>();
		builder.Services.AddTransient<SettingsPage>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
