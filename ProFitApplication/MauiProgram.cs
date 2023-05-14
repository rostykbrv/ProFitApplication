using Microsoft.Extensions.Logging;
using ProFitApplication.Services;
using ProFitApplication.ViewModels;
using ProFitApplication.Views;

namespace ProFitApplication;

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
				fonts.AddFont("Rubik-Regular.ttf", "RubikRegular");
				fonts.AddFont("Rubik-Bold.ttf", "RubikBold");

            });

#if DEBUG
		builder.Logging.AddDebug();
#endif


		builder.Services.AddSingleton<StartPageView>();
		builder.Services.AddTransient<HomeWorkoutPageView>();
        builder.Services.AddTransient<YogaPageView>();
		builder.Services.AddTransient<GymWorkoutPage>();
		builder.Services.AddTransient<DetailsExerciseGroupView>();
		builder.Services.AddTransient<ExercisingPageView>();

        builder.Services.AddSingleton<StartPageViewModel>();
        builder.Services.AddTransient<HomeWorkoutPageViewModel>();
        builder.Services.AddTransient<YogaPageViewModel>();
        builder.Services.AddTransient<GymWorkoutPageViewModel>();
		builder.Services.AddTransient<DetailsExerciseGroupViewModel>();
		builder.Services.AddTransient<ExercisingPageViewModel>();

        return builder.Build();
	}
}
