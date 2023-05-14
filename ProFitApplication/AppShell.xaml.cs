
using ProFitApplication.Views;

namespace ProFitApplication;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(HomeWorkoutPageView),typeof(HomeWorkoutPageView));
        Routing.RegisterRoute(nameof(YogaPageView), typeof(YogaPageView));
        Routing.RegisterRoute(nameof(GymWorkoutPage), typeof(GymWorkoutPage));
        Routing.RegisterRoute(nameof(DetailsExerciseGroupView), typeof(DetailsExerciseGroupView));
        Routing.RegisterRoute(nameof(ExercisingPageView), typeof(ExercisingPageView));
    }


}
