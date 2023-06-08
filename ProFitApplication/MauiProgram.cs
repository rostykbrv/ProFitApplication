using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using ProFitApplication.Services;
using ProFitApplication.ViewModels;
using SkiaSharp.Views.Maui.Controls.Hosting;
using ProFitApplication.Views;
using ProFitApplication.Views.Exercises;
using ProFitApplication.Views.WeightTraining;
using ProFitApplication.Views.UpperBodyTraining;
using ProFitApplication.Views.LowerBodyTraining;

namespace ProFitApplication;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseSkiaSharp()
            .UseMauiCommunityToolkit()
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

		builder.Services.AddSingleton<ProFitApplication.Models.User>();

		builder.Services.AddSingleton<SuccessWorkoutDone>();
		builder.Services.AddTransient<LoginPage>();
		builder.Services.AddTransient<StartPageView>();
		builder.Services.AddTransient<ProfileView>();
		builder.Services.AddTransient<HomeWorkoutPageView>();
        builder.Services.AddTransient<YogaPageView>();
		builder.Services.AddTransient<GymWorkoutPage>();
		builder.Services.AddTransient<DetailsExerciseGroupView>();
		builder.Services.AddSingleton<JumpingJackPage>();
        builder.Services.AddSingleton<HighKnees>();
        builder.Services.AddSingleton<Burpee>();
        builder.Services.AddSingleton<Crunches>();
        builder.Services.AddSingleton<Lunges>();
        builder.Services.AddSingleton<Plank>();
        builder.Services.AddSingleton<PushUps>();
        builder.Services.AddSingleton<Squat>();
        builder.Services.AddSingleton<ChairDips>();
        builder.Services.AddSingleton<DiamondPushUps>();
        builder.Services.AddSingleton<PikePushUps>();
        builder.Services.AddSingleton<PlankUpperBody>();
        builder.Services.AddSingleton<PushUp>();
        builder.Services.AddSingleton<Superman>();
        builder.Services.AddSingleton<RunningPlace>();
        builder.Services.AddSingleton<BodyweightSquats>();
        builder.Services.AddSingleton<GluteBridges>();
        builder.Services.AddSingleton<Walking_Lunges>();
        builder.Services.AddSingleton<WallSit>();


        builder.Services.AddSingleton<StartPageViewModel>();
        builder.Services.AddSingleton<ProfileViewModel>();
        builder.Services.AddTransient<HomeWorkoutPageViewModel>();
        builder.Services.AddTransient<YogaPageViewModel>();
        builder.Services.AddTransient<GymWorkoutPageViewModel>();
		builder.Services.AddTransient<DetailsExerciseGroupViewModel>();
		builder.Services.AddTransient<ExercisingPageViewModel>();

        return builder.Build();
	}
}
